namespace img2pok
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntLoadImg = new System.Windows.Forms.Button();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.cmsRtbOuput = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBitMode = new System.Windows.Forms.GroupBox();
            this.rb16 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.lbPalette = new System.Windows.Forms.ListBox();
            this.cmsPalette = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndexes = new System.Windows.Forms.Button();
            this.btnLoadPaletteJson = new System.Windows.Forms.Button();
            this.btnLoadPaletteImg = new System.Windows.Forms.Button();
            this.btnSavePaletteJson = new System.Windows.Forms.Button();
            this.btnExtractPalette = new System.Windows.Forms.Button();
            this.pbIndexed = new System.Windows.Forms.PictureBox();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.numRow = new System.Windows.Forms.NumericUpDown();
            this.btnExtractPaletteAll = new System.Windows.Forms.Button();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnReloadImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tbSpriteName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.cmsRtbOuput.SuspendLayout();
            this.gbBitMode.SuspendLayout();
            this.cmsPalette.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIndexed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntLoadImg
            // 
            this.bntLoadImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntLoadImg.Location = new System.Drawing.Point(3, 2);
            this.bntLoadImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntLoadImg.Name = "bntLoadImg";
            this.bntLoadImg.Size = new System.Drawing.Size(163, 38);
            this.bntLoadImg.TabIndex = 0;
            this.bntLoadImg.Text = "Load Image..";
            this.toolTipInfo.SetToolTip(this.bntLoadImg, "Load original image");
            this.bntLoadImg.UseVisualStyleBackColor = true;
            this.bntLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // pbOriginal
            // 
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOriginal.Location = new System.Drawing.Point(3, 92);
            this.pbOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(507, 219);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 1;
            this.pbOriginal.TabStop = false;
            this.toolTipInfo.SetToolTip(this.pbOriginal, "Original image");
            this.pbOriginal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbOriginal_Paint);
            // 
            // rtbOut
            // 
            this.rtbOut.ContextMenuStrip = this.cmsRtbOuput;
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOut.Location = new System.Drawing.Point(516, 315);
            this.rtbOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(508, 412);
            this.rtbOut.TabIndex = 3;
            this.rtbOut.Text = "";
            this.toolTipInfo.SetToolTip(this.rtbOut, "Code result, copy and past to your pokitto project.");
            this.rtbOut.WordWrap = false;
            // 
            // cmsRtbOuput
            // 
            this.cmsRtbOuput.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRtbOuput.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.cmsRtbOuput.Name = "cmsRtbOuput";
            this.cmsRtbOuput.Size = new System.Drawing.Size(113, 52);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // gbBitMode
            // 
            this.gbBitMode.Controls.Add(this.rb16);
            this.gbBitMode.Controls.Add(this.rb1);
            this.gbBitMode.Controls.Add(this.rb2);
            this.gbBitMode.Controls.Add(this.rb4);
            this.gbBitMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBitMode.Location = new System.Drawing.Point(3, 2);
            this.gbBitMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbBitMode.Name = "gbBitMode";
            this.gbBitMode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.SetRowSpan(this.gbBitMode, 3);
            this.gbBitMode.Size = new System.Drawing.Size(247, 131);
            this.gbBitMode.TabIndex = 5;
            this.gbBitMode.TabStop = false;
            this.gbBitMode.Text = "Bit Mode";
            this.toolTipInfo.SetToolTip(this.gbBitMode, "Select render mode for pokitto");
            // 
            // rb16
            // 
            this.rb16.AutoSize = true;
            this.rb16.Location = new System.Drawing.Point(6, 22);
            this.rb16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb16.Name = "rb16";
            this.rb16.Size = new System.Drawing.Size(154, 21);
            this.rb16.TabIndex = 8;
            this.rb16.Text = "8bit (max 256 color)";
            this.rb16.UseVisualStyleBackColor = true;
            this.rb16.CheckedChanged += new System.EventHandler(this.rb16_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 101);
            this.rb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(138, 21);
            this.rb1.TabIndex = 7;
            this.rb1.Text = "1bit (max 2 color)";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(6, 74);
            this.rb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(138, 21);
            this.rb2.TabIndex = 7;
            this.rb2.Text = "2bit (max 4 color)";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Checked = true;
            this.rb4.Location = new System.Drawing.Point(6, 47);
            this.rb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(146, 21);
            this.rb4.TabIndex = 7;
            this.rb4.TabStop = true;
            this.rb4.Text = "4bit (max 16 color)";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
            // 
            // lbPalette
            // 
            this.lbPalette.AllowDrop = true;
            this.lbPalette.ContextMenuStrip = this.cmsPalette;
            this.lbPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPalette.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbPalette.FormattingEnabled = true;
            this.lbPalette.Location = new System.Drawing.Point(3, 17);
            this.lbPalette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPalette.Name = "lbPalette";
            this.lbPalette.Size = new System.Drawing.Size(241, 254);
            this.lbPalette.TabIndex = 6;
            this.toolTipInfo.SetToolTip(this.lbPalette, "Show actual palette (Drag and drop to reorder)");
            this.lbPalette.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbPalette_DrawItem);
            this.lbPalette.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbPalette_DragDrop);
            this.lbPalette.DragOver += new System.Windows.Forms.DragEventHandler(this.lbPalette_DragOver);
            this.lbPalette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbPalette_MouseDown);
            // 
            // cmsPalette
            // 
            this.cmsPalette.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPalette.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.cmsPalette.Name = "cmsPalette";
            this.cmsPalette.Size = new System.Drawing.Size(126, 76);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPalette);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 6);
            this.groupBox1.Size = new System.Drawing.Size(247, 273);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palette";
            // 
            // btnIndexes
            // 
            this.btnIndexes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIndexes.Location = new System.Drawing.Point(256, 362);
            this.btnIndexes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIndexes.Name = "btnIndexes";
            this.btnIndexes.Size = new System.Drawing.Size(248, 48);
            this.btnIndexes.TabIndex = 8;
            this.btnIndexes.Text = "Indexes Image (Build C file)";
            this.toolTipInfo.SetToolTip(this.btnIndexes, "Indexes original image (refresh c code)");
            this.btnIndexes.UseVisualStyleBackColor = true;
            this.btnIndexes.Click += new System.EventHandler(this.btnIndexes_Click);
            // 
            // btnLoadPaletteJson
            // 
            this.btnLoadPaletteJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadPaletteJson.Location = new System.Drawing.Point(256, 227);
            this.btnLoadPaletteJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadPaletteJson.Name = "btnLoadPaletteJson";
            this.btnLoadPaletteJson.Size = new System.Drawing.Size(248, 41);
            this.btnLoadPaletteJson.TabIndex = 10;
            this.btnLoadPaletteJson.Text = "Load palette from json..";
            this.toolTipInfo.SetToolTip(this.btnLoadPaletteJson, "Load palette from saved json");
            this.btnLoadPaletteJson.UseVisualStyleBackColor = true;
            this.btnLoadPaletteJson.Click += new System.EventHandler(this.btnLoadPaletteJson_Click);
            // 
            // btnLoadPaletteImg
            // 
            this.btnLoadPaletteImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadPaletteImg.Location = new System.Drawing.Point(256, 137);
            this.btnLoadPaletteImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadPaletteImg.Name = "btnLoadPaletteImg";
            this.btnLoadPaletteImg.Size = new System.Drawing.Size(248, 41);
            this.btnLoadPaletteImg.TabIndex = 11;
            this.btnLoadPaletteImg.Text = "Load image as palette..";
            this.toolTipInfo.SetToolTip(this.btnLoadPaletteImg, "Load an image and use all colors as palette");
            this.btnLoadPaletteImg.UseVisualStyleBackColor = true;
            this.btnLoadPaletteImg.Click += new System.EventHandler(this.btnLoadPaletteImg_Click);
            // 
            // btnSavePaletteJson
            // 
            this.btnSavePaletteJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSavePaletteJson.Location = new System.Drawing.Point(256, 272);
            this.btnSavePaletteJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePaletteJson.Name = "btnSavePaletteJson";
            this.btnSavePaletteJson.Size = new System.Drawing.Size(248, 41);
            this.btnSavePaletteJson.TabIndex = 12;
            this.btnSavePaletteJson.Text = "Save palette as json..";
            this.toolTipInfo.SetToolTip(this.btnSavePaletteJson, "Save actual palette to json");
            this.btnSavePaletteJson.UseVisualStyleBackColor = true;
            this.btnSavePaletteJson.Click += new System.EventHandler(this.btnSavePaletteJson_Click);
            // 
            // btnExtractPalette
            // 
            this.btnExtractPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtractPalette.Location = new System.Drawing.Point(256, 2);
            this.btnExtractPalette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExtractPalette.Name = "btnExtractPalette";
            this.btnExtractPalette.Size = new System.Drawing.Size(248, 41);
            this.btnExtractPalette.TabIndex = 14;
            this.btnExtractPalette.Text = "Extract Palette from image";
            this.toolTipInfo.SetToolTip(this.btnExtractPalette, "Extract an avarage palette from image");
            this.btnExtractPalette.UseVisualStyleBackColor = true;
            this.btnExtractPalette.Click += new System.EventHandler(this.btnExtractPalette_Click);
            // 
            // pbIndexed
            // 
            this.pbIndexed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIndexed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIndexed.Location = new System.Drawing.Point(516, 92);
            this.pbIndexed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIndexed.Name = "pbIndexed";
            this.pbIndexed.Size = new System.Drawing.Size(508, 219);
            this.pbIndexed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIndexed.TabIndex = 1;
            this.pbIndexed.TabStop = false;
            this.toolTipInfo.SetToolTip(this.pbIndexed, "Indexed image");
            this.pbIndexed.Paint += new System.Windows.Forms.PaintEventHandler(this.pbIndexed_Paint);
            // 
            // numColumns
            // 
            this.numColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numColumns.Location = new System.Drawing.Point(3, 45);
            this.numColumns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numColumns.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(248, 38);
            this.numColumns.TabIndex = 15;
            this.toolTipInfo.SetToolTip(this.numColumns, "Split image in columns number tiles");
            this.numColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColumns.ValueChanged += new System.EventHandler(this.numColumns_ValueChanged);
            // 
            // numRow
            // 
            this.numRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRow.Location = new System.Drawing.Point(257, 45);
            this.numRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRow.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow.Name = "numRow";
            this.numRow.Size = new System.Drawing.Size(248, 38);
            this.numRow.TabIndex = 16;
            this.toolTipInfo.SetToolTip(this.numRow, "Split image in row number tiles");
            this.numRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRow.ValueChanged += new System.EventHandler(this.numRow_ValueChanged);
            // 
            // btnExtractPaletteAll
            // 
            this.btnExtractPaletteAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtractPaletteAll.Location = new System.Drawing.Point(256, 47);
            this.btnExtractPaletteAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExtractPaletteAll.Name = "btnExtractPaletteAll";
            this.btnExtractPaletteAll.Size = new System.Drawing.Size(248, 41);
            this.btnExtractPaletteAll.TabIndex = 17;
            this.btnExtractPaletteAll.Text = "Extract All Colors";
            this.toolTipInfo.SetToolTip(this.btnExtractPaletteAll, "Get all colors from image (Slow with many colors!)");
            this.btnExtractPaletteAll.UseVisualStyleBackColor = true;
            this.btnExtractPaletteAll.Click += new System.EventHandler(this.btnExtractPaletteAll_Click);
            // 
            // btnReloadImage
            // 
            this.btnReloadImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReloadImage.Location = new System.Drawing.Point(172, 2);
            this.btnReloadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReloadImage.Name = "btnReloadImage";
            this.btnReloadImage.Size = new System.Drawing.Size(163, 38);
            this.btnReloadImage.TabIndex = 1;
            this.btnReloadImage.Text = "Reload Image";
            this.toolTipInfo.SetToolTip(this.btnReloadImage, "Reload image from disk");
            this.btnReloadImage.UseVisualStyleBackColor = true;
            this.btnReloadImage.Click += new System.EventHandler(this.btnReloadImage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbIndexed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbOriginal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbOut, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1027, 729);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnExtractPalette, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExtractPaletteAll, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnLoadPaletteImg, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnLoadPaletteJson, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnIndexes, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.gbBitMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSavePaletteJson, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 315);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(507, 412);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.numColumns, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.numRow, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(516, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(508, 86);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Columns";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Rows";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnReloadImage, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.bntLoadImg, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbSpriteName, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSettings, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(507, 84);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // tbSpriteName
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.tbSpriteName, 2);
            this.tbSpriteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSpriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpriteName.Location = new System.Drawing.Point(172, 45);
            this.tbSpriteName.Name = "tbSpriteName";
            this.tbSpriteName.Size = new System.Drawing.Size(332, 38);
            this.tbSpriteName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sprite Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Location = new System.Drawing.Point(341, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(163, 36);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1023, 766);
            this.Name = "Form1";
            this.Text = "img2pok";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.cmsRtbOuput.ResumeLayout(false);
            this.gbBitMode.ResumeLayout(false);
            this.gbBitMode.PerformLayout();
            this.cmsPalette.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIndexed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntLoadImg;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.GroupBox gbBitMode;
        private System.Windows.Forms.ListBox lbPalette;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnIndexes;
        private System.Windows.Forms.Button btnLoadPaletteJson;
        private System.Windows.Forms.Button btnLoadPaletteImg;
        private System.Windows.Forms.Button btnSavePaletteJson;
        private System.Windows.Forms.Button btnExtractPalette;
        private System.Windows.Forms.PictureBox pbIndexed;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.NumericUpDown numRow;
        private System.Windows.Forms.Button btnExtractPaletteAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsRtbOuput;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPalette;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnReloadImage;
        private System.Windows.Forms.RadioButton rb16;
        private System.Windows.Forms.TextBox tbSpriteName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSettings;
    }
}

