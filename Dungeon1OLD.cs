using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fuckaround2
{
    /*
     * Uses the type safe enum pattern
     * source: https://ardalis.com/enum-alternatives-in-c
     */
    public class Dungeon1OLD : AEnum
    {
        public static Dungeon1OLD Room1 { get; } = new Dungeon1OLD(0, "Room1");
        public static Dungeon1OLD Room2 { get; } = new Dungeon1OLD(1, "Room2");
        public static Dungeon1OLD Room3 { get; } = new Dungeon1OLD(2, "Room3");
        public static Dungeon1OLD Room4 { get; } = new Dungeon1OLD(3, "Room4");
        public static Dungeon1OLD Room5 { get; } = new Dungeon1OLD(4, "Room5");
        public static Dungeon1OLD Room6 { get; } = new Dungeon1OLD(5, "Room6");
        public static Dungeon1OLD Room7 { get; } = new Dungeon1OLD(6, "Room7");
        public static Dungeon1OLD Room8 { get; } = new Dungeon1OLD(7, "Room8");
        public static Dungeon1OLD Room9 { get; } = new Dungeon1OLD(8, "Room9");
        public static Dungeon1OLD Room10 { get; } = new Dungeon1OLD(9, "Room10");
        public static Dungeon1OLD Room11 { get; } = new Dungeon1OLD(10, "Room11");
        public static Dungeon1OLD Room12 { get; } = new Dungeon1OLD(11, "Room12");
        public static Dungeon1OLD Room13 { get; } = new Dungeon1OLD(12, "Room13");
        public static Dungeon1OLD Room14 { get; } = new Dungeon1OLD(13, "Room14");
        public static Dungeon1OLD Room15 { get; } = new Dungeon1OLD(14, "Room15");
        public static Dungeon1OLD Room16 { get; } = new Dungeon1OLD(15, "Room16");
        public static Dungeon1OLD Room17 { get; } = new Dungeon1OLD(16, "Room17");
        public static Dungeon1OLD Room18 { get; } = new Dungeon1OLD(17, "Room18");
        public static Dungeon1OLD Room19 { get; } = new Dungeon1OLD(18, "Room19");
        public static Dungeon1OLD Room20 { get; } = new Dungeon1OLD(19, "Room20");
        public static Dungeon1OLD Room21 { get; } = new Dungeon1OLD(20, "Room21");
        public static Dungeon1OLD Room22 { get; } = new Dungeon1OLD(21, "Room22");
        public static Dungeon1OLD Room23 { get; } = new Dungeon1OLD(22, "Room23");
        public static Dungeon1OLD Room24 { get; } = new Dungeon1OLD(23, "Room24");
        public static Dungeon1OLD Room25 { get; } = new Dungeon1OLD(24, "Room25");
        public static Dungeon1OLD Room26 { get; } = new Dungeon1OLD(25, "Room26");
        public static Dungeon1OLD Room27 { get; } = new Dungeon1OLD(26, "Room27");
        public static Dungeon1OLD Room28 { get; } = new Dungeon1OLD(27, "Room28");
        public static Dungeon1OLD Room29 { get; } = new Dungeon1OLD(28, "Room29");
        public static Dungeon1OLD Room30 { get; } = new Dungeon1OLD(29, "Room30");
        public static Dungeon1OLD Room31 { get; } = new Dungeon1OLD(30, "Room31");
        public static Dungeon1OLD Room32 { get; } = new Dungeon1OLD(31, "Room32");
        public static Dungeon1OLD Room33 { get; } = new Dungeon1OLD(32, "Room33");
        public static Dungeon1OLD Room34 { get; } = new Dungeon1OLD(33, "Room34");
        public static Dungeon1OLD Room35 { get; } = new Dungeon1OLD(34, "Room35");
        public static Dungeon1OLD Room36 { get; } = new Dungeon1OLD(35, "Room36");
        public static Dungeon1OLD Room37 { get; } = new Dungeon1OLD(36, "Room37");
        public static Dungeon1OLD Room38 { get; } = new Dungeon1OLD(37, "Room38");
        public static Dungeon1OLD Room39 { get; } = new Dungeon1OLD(38, "Room39");
        public static Dungeon1OLD Room40 { get; } = new Dungeon1OLD(39, "Room40");
        public static Dungeon1OLD Room41 { get; } = new Dungeon1OLD(40, "Room41");
        public static Dungeon1OLD Room42 { get; } = new Dungeon1OLD(41, "Room42");



       // public string Name { get; private set; }
        //public int Value { get; private set; }

        //private ImageValues imageValues { get;  set; }

        //private ImageList imageList { get; set; }
        



        private Dungeon1OLD(int val, string name)
        {
            Value = val;
            Name = name;
        }

        //public ImageValues ImageValues()
        //{
        //    if (imageValues.X == -1 || imageValues.Y == -1 || imageValues.Width == -1 || imageValues.Height == -1)
        //    {
        //        // Should declare string message in String file so that enum is thrown with easily searchable error message
        //        throw new InvalidOperationException("Image value not set, attempting to access undefined image");
        //    }

        //    return imageValues;
        //}

        //public ImageList ImageList()
        //{
        //    if (imageList.IsEmpty())
        //    {
        //        // Should declare string message in String file so that enum is thrown with easily searchable error message
        //        throw new InvalidOperationException("Image list is empty");
        //    }

        //    return imageList;
        //}

        //public void setFrame(ImageValues imVals)
        //{
        //    imageValues = imVals;
        //}

        //public void setFrames(ImageList imList)
        //{
        //    imageList = imList;
        //}

        public static Dungeon1OLD FromString(string dungeonString)
        {
            return List().Single(r => String.Equals(r.Name, dungeonString, StringComparison.Ordinal));
        }

        public static Dungeon1OLD FromValue(int value)
        {
            return List().Single(r => r.Value == value);
        }

        public static IEnumerable<Dungeon1OLD> List()
        {
            return new[]
            {
                Room1,
                Room2,
                Room3,
                Room4,
                Room5,
                Room6,
                Room7,
                Room8,
                Room9,
                Room10,
                Room11,
                Room12,
                Room13,
                Room14,
                Room15,
                Room16,
                Room17,
                Room18,
                Room19,
                Room20,
                Room21,
                Room22,
                Room23,
                Room24,
                Room25,
                Room26,
                Room27,
                Room28,
                Room29,
                Room30,
                Room31,
                Room32,
                Room33,
                Room34,
                Room35,
                Room36,
                Room37,
                Room38,
                Room39,
                Room40,
                Room41,
                Room42
           };



        }

    }
}
