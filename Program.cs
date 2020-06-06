using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace fuckaround2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageValues img1 = new ImageValues(1, 2, 3, 4);
            ImageValues img2 = new ImageValues(5, 6, 7, 8);
            Dungeon1.FromString("Room1").setFrame(img1);
            Dungeon1.FromString("Room2").setFrame(img2);
            List<ImageValues> imageList = new List<ImageValues>();
            imageList.Add(img1);
            imageList.Add(img2);
            ImageList imList = new ImageList(imageList);
            Dungeon1.FromString("Room3").setFrames(imList);

            // this maps 1 image to 1 image name
            // now need something that maps multiple images to 1 name
            try
            {
                Console.WriteLine(Dungeon1.FromString("Room1").ImageValues().X);
                Console.WriteLine(Dungeon1.FromString("Room2").ImageValues().X);
                Console.WriteLine(Dungeon1.FromString("Room3").ImageValues().X);
            }
            catch (InvalidOperationException e)
            {
                if (e.Source != null)
                {
                    Console.Error.WriteLine(e.Message);
                    Environment.Exit(1);

                }

            }



        }
    }
}
