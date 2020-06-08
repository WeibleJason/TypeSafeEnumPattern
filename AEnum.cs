using System;
using System.Collections.Generic;
using System.Text;

namespace fuckaround2
{
    public abstract class AEnum : IEnum
    {
        /* protected members are only accessible wihtin class and derived class */
        public string Name { get; protected set; }
        public int Value { get; protected set; }

        protected ImageValues imageValues { get; private set; }

        protected ImageList imageList { get; private set; }

        public ImageValues ImageValues()
        {
            if (imageValues.X == -1 || imageValues.Y == -1 || imageValues.Width == -1 || imageValues.Height == -1)
            {
                // Should declare string message in String file so that enum is thrown with easily searchable error message
                throw new InvalidOperationException("Image value not set, attempting to access undefined image");
            }

            return imageValues;
        }

        public ImageList ImageList()
        {
            if (imageList.IsEmpty())
            {
                // Should declare string message in String file so that enum is thrown with easily searchable error message
                throw new InvalidOperationException("Image list is empty");
            }

            return imageList;
        }

        public void setFrame(ImageValues imVals)
        {
            imageValues = imVals;
        }

        public void setFrames(ImageList imList)
        {
            imageList = imList;
        }

      


    }
}
