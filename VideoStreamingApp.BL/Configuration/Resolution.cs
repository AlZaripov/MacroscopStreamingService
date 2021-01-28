using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStreamingApp.BL
{
    public class Resolution
    {
        public int X { get; }
        public int Y { get; }

        public override string ToString()
        {
            return $"{X}x{Y}";
        }

        public Resolution(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Resolution GetResolution(string str)
        {
            var array = str.Split('x');
            return new Resolution(int.Parse(array[0]), int.Parse(array[1]));
        }
    }
}
