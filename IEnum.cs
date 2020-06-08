using System;
using System.Collections.Generic;
using System.Text;

namespace fuckaround2
{
    public interface IEnum
    {

        public ImageValues ImageValues();
        public ImageList ImageList();
        public void setFrame(ImageValues imVals);
        public void setFrames(ImageList imList);
       

    }
}
