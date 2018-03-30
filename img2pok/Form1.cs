using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace img2pok
{
    public partial class Form1 : Form
    {
        string imgPath = "";
        int numBit = 4;
        List<ColorCount> palette;

        public Form1()
        {
            InitializeComponent();
            this.Text = "img2pok V" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void LoadImage()
        {
            try
            {
                using (Image img = Image.FromFile(imgPath))
                {
                    pbOriginal.Image = new Bitmap(img);
                }
                ProcessImage();
            }
            catch
            {
                rtbOut.Text = "Error reading file";
            }
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgPath = ofd.FileName;
                    tbSpriteName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                    LoadImage();
                }
            }
        }

        private void btnReloadImage_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void ProcessImage()
        {
            var originalImage = (Bitmap)pbOriginal.Image;
            if (originalImage != null && palette != null)
            {
                //Map image with reduced palette
                Bitmap bmpIndexed = new Bitmap(originalImage.Width, originalImage.Height);
                for (int x = 0; x < originalImage.Width; x++)
                {
                    for (int y = 0; y < originalImage.Height; y++)
                    {
                        Color c = originalImage.GetPixel(x, y);
                        var newC = ConverToPalette(c, palette);
                        bmpIndexed.SetPixel(x, y, newC);
                    }
                }
                //update image output
                pbIndexed.Image = bmpIndexed;

                //Build C file
                if (palette.Count() <= Math.Pow(2, numBit))
                {
                    //Scan image and extract indexed pixels
                    int[,] pixels = scanImage((Bitmap)pbIndexed.Image, palette);

                    string sSpriteName = "sprite";
                    if (!string.IsNullOrWhiteSpace(tbSpriteName.Text))
                        sSpriteName = tbSpriteName.Text.Trim();

                    //Create sub images
                    string OutputC = "";
                    OutputC += buildCFilePalette(sSpriteName, palette);

                    if (numColumns.Value > 1 || numRow.Value > 1)
                    {
                        //Multiple sprites
                        using (var g = Graphics.FromImage(bmpIndexed))
                        {
                            int wc = (int)(bmpIndexed.Width / numColumns.Value);
                            int hc = (int)(bmpIndexed.Height / numRow.Value);
                            int index = 0;


                            int size = 2 + (hc * (wc / (8 / numBit)));
                            OutputC += "//Sprite sheet:" + numColumns.Value + "x" + numRow.Value + "\r\n";
                            OutputC += "const uint8_t " + sSpriteName + " [][" + size + "] ={\r\n";

                            for (int y = 0; y < numRow.Value; y++)
                            {
                                g.DrawLine(Pens.Red, 0, y * hc, bmpIndexed.Width, y * hc);
                                for (int x = 0; x < numColumns.Value; x++)
                                {
                                    g.DrawLine(Pens.Red, x * wc, 0, x * wc, bmpIndexed.Height);
                                    //Copy sub pixels 
                                    var sub = new int[wc, hc];
                                    for (int xs = 0; xs < wc; xs++)
                                    {
                                        for (int ys = 0; ys < hc; ys++)
                                        {
                                            sub[xs, ys] = pixels[x * wc + xs, y * hc + ys];
                                        }
                                    }
                                    OutputC += "//[" + index + "] cell:" + x + "x" + y + " \r\n";
                                    OutputC += buildCFileSprites(wc, hc, palette, sub) + ",\r\n";
                                    index++;
                                }
                            }
                            OutputC += "};";
                        }
                    }
                    else
                    {
                        //Single sprite                        
                        OutputC += "const uint8_t " + sSpriteName + "[] =\r\n";
                        OutputC += buildCFileSprites(bmpIndexed.Width, bmpIndexed.Height, palette, pixels) + ";\r\n";
                    }

                    //update text box
                    rtbOut.Text = OutputC;
                    //Select all text and scroll to top
                    rtbOut.SelectAll();
                    rtbOut.Focus();
                    rtbOut.SelectionStart = 0;
                    rtbOut.ScrollToCaret();
                }
                else
                {
                    rtbOut.Text = String.Format("Your image have {0} colors. Max colors in this mode are {1}",
                        palette.Count(),
                        Math.Pow(2, numBit));
                }
            }
        }

        private void PopulatePaletteListBox()
        {
            lbPalette.Items.Clear();
            foreach (var p in palette)
            {
                lbPalette.Items.Add(p);
            }
        }

        private List<ColorCount> ExtractFullPalette(Bitmap bmp)
        {
            List<ColorCount> palette = new List<ColorCount>();
            if (bmp != null)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        ColorCount c = new ColorCount(bmp.GetPixel(x, y), 0);
                        if (palette.Contains(c))
                        {
                            var index = palette.IndexOf(c);
                            palette[index].Count++;
                        }
                        else
                        {
                            palette.Add(c);
                        }
                    }
                }
            }
            return palette;
        }

        private List<ColorCount> ExtractBestPalette(Image bmp, int maxColors)
        {
            Bitmap thumb;
            if (bmp.Width > 32 || bmp.Height > 32)
                thumb = new Bitmap(32, 32);
            else
                thumb = new Bitmap(bmp.Width, bmp.Height);

            using (var g = Graphics.FromImage(thumb))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                if (bmp != null)
                {
                    if (bmp.Width > 32 || bmp.Height > 32)
                        g.DrawImage(bmp, 0, 0, 32, 32);
                    else
                        g.DrawImage(bmp, 0, 0);
                }
            }
            var allPal = ExtractFullPalette(thumb);
            allPal.Sort((p1, p2) => (p1.Count.CompareTo(p2.Count)));
            allPal.Reverse();

            //Reset count
            foreach (var p in allPal) { p.Count = 0; }

            return allPal.Take(maxColors).ToList();
        }

        private int[,] scanImage(Bitmap bmp, List<ColorCount> palette)
        {
            int[,] pixels = new int[bmp.Width, bmp.Height];
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    ColorCount c = new ColorCount(bmp.GetPixel(x, y), 0);

                    if (palette.Contains(c))
                    {
                        pixels[x, y] = palette.IndexOf(c);
                    }
                    else
                    {
                        pixels[x, y] = 0;
                    }


                }
            }
            return pixels;
        }

        private ushort ColorTo565(ColorCount c)
        {
            var r = (ushort)c.Color.R >> 3;
            var g = (ushort)c.Color.G >> 2;
            var b = (ushort)c.Color.B >> 3;

            var c565 = (r << 11) | (g << 5) | b;
            return (ushort)c565;
        }

        private string buildCFilePalette(string name, List<ColorCount> palette)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("#include <stdint.h>");
            sb.AppendLine();
            sb.AppendLine(string.Format("//Total colors {0}", palette.Count()));
            sb.AppendLine("const uint16_t " + name + "_pal[] = {");
            //Append colors in palette in 565 mode
            string sPal = "";
            foreach (var c in palette)
            {
                sPal += ColorTo565(c) + ",";
            }
            sb.AppendLine(sPal);
            sb.AppendLine("};");
            sb.AppendLine();
            return sb.ToString();
        }

        private string buildCFileSprites(int width, int height, List<ColorCount> palette, int[,] pixels)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("{");
            sb.AppendLine(String.Format("{0},{1},", width, height));

            //Calc offset
            int offSet = 8 / numBit;
            //line by line
            for (int y = 0; y < height; y++)
            {
                string line = "";
                for (int x = 0; x < width; x += offSet)
                {
                    //sum bit color
                    int pc = 0;
                    for (int i = 0; i < offSet; i++)
                    {
                        if (x + (offSet - 1 - i) < width)
                        {
                            pc += pixels[x + (offSet - 1 - i), y] << numBit * i;
                        }
                    }
                    line += pc + ",";
                }
                sb.AppendLine(line);
            }
            sb.Append("}");

            return sb.ToString();
        }

        private void lbPalette_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                ColorCount col = lbPalette.Items[e.Index] as ColorCount;
                if (col != null)
                {
                    e.DrawBackground();
                    Graphics g = e.Graphics;
                    // draw the background color you want
                    g.FillRectangle(new SolidBrush(col.Color),
                        new RectangleF(e.Bounds.X + (e.Bounds.Width * 2 / 3), e.Bounds.Y, (e.Bounds.Width), e.Bounds.Height));
                    // draw the text
                    string sColor = string.Format("[{0}]  ({1},{2},{3})",
                        e.Index,
                        col.Color.R,
                        col.Color.G,
                        col.Color.B);
                    g.DrawString(sColor, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
                    e.DrawFocusRectangle();
                }
            }
        }

        private void ChangeNumBit(object sender, int numBit)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    this.numBit = numBit;
                    ProcessImage();
                }
            }
        }

        private Color ConverToPalette(Color c, List<ColorCount> palette)
        {
            int minIndx = 0;
            double minDst = double.MaxValue;
            double distance;
            for (int i = 0; i < palette.Count(); i++)
            {
                distance = ColorDst(c, palette[i].Color);
                if (distance < minDst)
                {
                    minDst = distance;
                    minIndx = i;
                }
            }

            //Alpha to color
            if (c.A == 0)
                return palette[0].Color;
            else
                return palette[minIndx].Color;
        }

        private double ColorDst(Color a, Color b)
        {
            //double h = a.GetHue() - b.GetHue();
            //double u = a.GetSaturation() - b.GetSaturation();
            //double e = a.GetBrightness() - b.GetBrightness();
            //return (h * h + u * u + e * e);

            int dr = (a.R - b.R);
            int dg = (a.G - b.G);
            int db = (a.B - b.B);
            return (dr * dr + dg * dg + db * db);
        }

        private void rb16_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumBit(sender, 8);
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumBit(sender, 4);
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumBit(sender, 2);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNumBit(sender, 1);
        }

        private void btnIndexes_Click(object sender, EventArgs e)
        {
            ProcessImage();
        }

        private void btnExtractPalette_Click(object sender, EventArgs e)
        {
            palette = ExtractBestPalette(pbOriginal.Image, (int)Math.Pow(2, numBit));
            PopulatePaletteListBox();
            ProcessImage();
        }

        private void btnExtractPaletteAll_Click(object sender, EventArgs e)
        {
            palette = ExtractFullPalette((Bitmap)pbOriginal.Image);
            PopulatePaletteListBox();
            ProcessImage();
        }

        private void btnLoadPaletteJson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var txt = File.ReadAllText(ofd.FileName);
                        var loadPalette = JsonConvert.DeserializeObject<List<ColorCount>>(txt);
                        palette = loadPalette;
                        PopulatePaletteListBox();
                        ProcessImage();
                    }
                    catch
                    {
                        rtbOut.Text = "Can't read " + ofd.FileName;
                    }
                }
            }
        }

        private void btnLoadPaletteImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var extBmp = (Bitmap)Image.FromFile(ofd.FileName);
                        palette = ExtractFullPalette(extBmp);
                        PopulatePaletteListBox();
                        ProcessImage();
                    }
                    catch
                    {
                        rtbOut.Text = "Can't process image as palette: " + ofd.FileName;
                    }
                }
            }
        }

        private void btnSavePaletteJson_Click(object sender, EventArgs e)
        {
            var json = JsonConvert.SerializeObject(palette);
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "Palette.json";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, json);
                }
            }
        }

        private void numColumns_ValueChanged(object sender, EventArgs e)
        {
            ProcessImage();
        }

        private void numRow_ValueChanged(object sender, EventArgs e)
        {
            ProcessImage();
        }

        private void lbPalette_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.lbPalette.SelectedItem == null) return;
                this.lbPalette.DoDragDrop(this.lbPalette.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lbPalette_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lbPalette_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lbPalette.PointToClient(new Point(e.X, e.Y));
            int index = this.lbPalette.IndexFromPoint(point);
            if (index < 0) index = this.lbPalette.Items.Count - 1;
            object data = e.Data.GetData(typeof(ColorCount));
            this.lbPalette.Items.Remove(data);
            this.lbPalette.Items.Insert(index, data);

            palette = this.lbPalette.Items.Cast<ColorCount>().ToList();
            ProcessImage();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbOut.Text);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbOut.Text = "";
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                ColorCount selectedColor = lbPalette.SelectedItem as ColorCount;
                if (selectedColor != null)
                {
                    cd.AllowFullOpen = true;
                    cd.FullOpen = true;
                    cd.Color = selectedColor.Color;
                    cd.CustomColors = new int[] { ToInt(cd.Color) };
                    if (cd.ShowDialog() == DialogResult.OK)
                    {
                        selectedColor.Color = cd.Color;

                        palette = this.lbPalette.Items.Cast<ColorCount>().ToList();
                        ProcessImage();
                    }
                }
            }
        }
        static int ToInt(Color c)
        {
            return c.R + c.G * 0x100 + c.B * 0x10000;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorCount selectedColor = lbPalette.SelectedItem as ColorCount;
            if (selectedColor != null)
            {
                lbPalette.Items.Remove(selectedColor);

                palette = this.lbPalette.Items.Cast<ColorCount>().ToList();
                ProcessImage();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AllowFullOpen = true;
                cd.FullOpen = true;
                cd.CustomColors = new int[] { ToInt(cd.Color) };
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    ColorCount newColor = new ColorCount(cd.Color, 0);
                    lbPalette.Items.Add(newColor);

                    palette = this.lbPalette.Items.Cast<ColorCount>().ToList();
                    ProcessImage();
                }

            }
        }

        private void DrawPictureBoxPixelPerfect(PictureBox pb, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            e.Graphics.Clear(pb.BackColor);
            if (pb.Image != null)
            {
                Size sourceSize = pb.Image.Size;
                Size targetSize = pb.Size;
                float scale = Math.Min((float)targetSize.Width / sourceSize.Width, (float)targetSize.Height / sourceSize.Height);
                var rect = new RectangleF();
                rect.Width = scale * (float)sourceSize.Width;
                rect.Height = scale * (float)sourceSize.Height;
                rect.X = (targetSize.Width - rect.Width) / 2.0f;
                rect.Y = (targetSize.Height - rect.Height) / 2.0f;
                e.Graphics.DrawImage(pb.Image, rect);
            }
        }

        private void pbIndexed_Paint(object sender, PaintEventArgs e)
        {
            DrawPictureBoxPixelPerfect((PictureBox)sender, e);
        }      

        private void pbOriginal_Paint(object sender, PaintEventArgs e)
        {
            DrawPictureBoxPixelPerfect((PictureBox)sender,e);
        }
    }
}
