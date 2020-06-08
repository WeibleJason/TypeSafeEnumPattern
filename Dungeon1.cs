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
    public class Dungeon1 : AEnum
    {
        public static Dungeon1 Room1 { get; } = new Dungeon1(1, "Room1");
        public static Dungeon1 Room2 { get; } = new Dungeon1(2, "Room2");
        public static Dungeon1 Room3 { get; } = new Dungeon1(3, "Room3");
        public static Dungeon1 Room4 { get; } = new Dungeon1(4, "Room4");
        public static Dungeon1 Room5 { get; } = new Dungeon1(5, "Room5");
        public static Dungeon1 Room6 { get; } = new Dungeon1(6, "Room6");
        public static Dungeon1 Room7 { get; } = new Dungeon1(7, "Room7");
        public static Dungeon1 Room8 { get; } = new Dungeon1(8, "Room8");
        public static Dungeon1 Room9 { get; } = new Dungeon1(9, "Room9");
        public static Dungeon1 Room10 { get; } = new Dungeon1(10, "Room10");
        public static Dungeon1 Room11 { get; } = new Dungeon1(11, "Room11");
        public static Dungeon1 Room12 { get; } = new Dungeon1(12, "Room12");
        public static Dungeon1 Room13 { get; } = new Dungeon1(13, "Room13");
        public static Dungeon1 Room14 { get; } = new Dungeon1(14, "Room14");
        public static Dungeon1 Room15 { get; } = new Dungeon1(15, "Room15");
        public static Dungeon1 Room16 { get; } = new Dungeon1(16, "Room16");
        public static Dungeon1 Room17 { get; } = new Dungeon1(17, "Room17");
        public static Dungeon1 Room18 { get; } = new Dungeon1(18, "Room18");
        public static Dungeon1 Room19 { get; } = new Dungeon1(19, "Room19");
        public static Dungeon1 Room20 { get; } = new Dungeon1(20, "Room20");
        public static Dungeon1 Room21 { get; } = new Dungeon1(21, "Room21");
        public static Dungeon1 Room22 { get; } = new Dungeon1(22, "Room22");
        public static Dungeon1 Room23 { get; } = new Dungeon1(23, "Room23");
        public static Dungeon1 Room24 { get; } = new Dungeon1(24, "Room24");
        public static Dungeon1 Room25 { get; } = new Dungeon1(25, "Room25");
        public static Dungeon1 Room26 { get; } = new Dungeon1(26, "Room26");
        public static Dungeon1 Room27 { get; } = new Dungeon1(27, "Room27");
        public static Dungeon1 Room28 { get; } = new Dungeon1(28, "Room28");
        public static Dungeon1 Room29 { get; } = new Dungeon1(29, "Room29");
        public static Dungeon1 Room30 { get; } = new Dungeon1(30, "Room30");
        public static Dungeon1 Room31 { get; } = new Dungeon1(31, "Room31");
        public static Dungeon1 Room32 { get; } = new Dungeon1(32, "Room32");
        public static Dungeon1 Room33 { get; } = new Dungeon1(33, "Room33");
        public static Dungeon1 Room34 { get; } = new Dungeon1(34, "Room34");
        public static Dungeon1 Room35 { get; } = new Dungeon1(35, "Room35");
        public static Dungeon1 Room36 { get; } = new Dungeon1(36, "Room36");
        public static Dungeon1 Room37 { get; } = new Dungeon1(37, "Room37");
        public static Dungeon1 Room38 { get; } = new Dungeon1(38, "Room38");
        public static Dungeon1 Room39 { get; } = new Dungeon1(39, "Room39");
        public static Dungeon1 Room40 { get; } = new Dungeon1(40, "Room40");
        public static Dungeon1 Room41 { get; } = new Dungeon1(41, "Room41");
        public static Dungeon1 Room42 { get; } = new Dungeon1(42, "Room42");
        private Dungeon1(int val, string name)
        {
            Value = val;
            Name = name;
        }

        public static Dungeon1 FromString(string name)
        {
            return List().Single(r => String.Equals(r.Name, name, StringComparison.Ordinal));
        }

        public static Dungeon1 FromValue(int value)
        {
            return List().Single(r => r.Value == value);
        }

        public static IEnumerable<Dungeon1> List()
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
                Room42,
            };
        }
    }
}
