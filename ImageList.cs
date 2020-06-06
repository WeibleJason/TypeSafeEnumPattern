using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fuckaround2
{
    public class ImageList
    {
        private List<ImageValues> imageList;
        public ImageList(List<ImageValues> imList)
        {
            imageList = imList;
        }

        public List<ImageValues> Frames
        {
            get { return imageList;  }
        }

        public bool IsEmpty()
        {
            return !imageList.Any();
        }
        
    }
}
