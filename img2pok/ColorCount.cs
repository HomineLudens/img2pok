using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace img2pok
{
    class ColorCount : IEquatable<ColorCount>
    {
        public Color Color { get; set; }
        public int Count { get; set; }

        public ColorCount(Color color, int count)
        {
            this.Color = color;
            this.Count = count;
        }

        public bool Equals(ColorCount other)
        {
            return this.Color.ToArgb() == other.Color.ToArgb();
        }
    }
}
