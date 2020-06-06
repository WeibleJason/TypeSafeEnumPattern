using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace fuckaround2
{
    public struct ImageValues
    {
        /* nullable types idea from:
         * https://stackoverflow.com/questions/39846708/how-to-make-a-default-value-for-the-struct-in-c
         */

        private int? x;
        private int? y;
        private int? width;
        private int? height;

        public int X { get { return x ?? -1; }  }
        public int Y {  get { return y ?? -1; } }
        public int Width {  get { return width ?? -1; } }
        public int Height {  get { return height ?? -1; } }

        

        public ImageValues(int _x, int _y, int _width, int _height)
        {
            x = _x;
            y = _y;
            width = _width;
            height = _height;
        }
    }
}
