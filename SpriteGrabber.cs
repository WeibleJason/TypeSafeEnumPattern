using System;
using System.Collections.Generic;
using System.Text;

namespace fuckaround2

{
    /*
     * singleton
     */
    public class SpriteGrabber
    {
        private static SpriteGrabber instance = new SpriteGrabber();

        private SpriteGrabber() { }

        public static SpriteGrabber Instance
        {
            get { return instance; }
        }


        public Stack<ImageValues> CalculateRectangle(SpriteSheetParameters spriteSheetParameters)
        {
            int x, y, width, height;
            int deltaX, deltaY;

            Stack<ImageValues> rectangleStack = new Stack<ImageValues>();

            //x = (int)spriteSheetParameters.Origin.X;
            y = (int)spriteSheetParameters.Origin.Y;
            width = spriteSheetParameters.ColumnWidth;
            height = spriteSheetParameters.RowHeight;

            //rectangleStack.Push(new ImageValues(x,y,width,height));

            deltaX = spriteSheetParameters.ColumnWidth + spriteSheetParameters.ColumnBuffer;
            deltaY = spriteSheetParameters.RowHeight + spriteSheetParameters.RowBuffer;

            for (int currentRow = 1; currentRow <= spriteSheetParameters.NumberRows; currentRow++)
            {
                x = (int)spriteSheetParameters.Origin.X;
                for (int currentColumn = 1; currentColumn <= spriteSheetParameters.NumberColumns; currentColumn++)
                {
                    rectangleStack.Push(new ImageValues(x, y, width, height));
                    x += deltaX;
                }

                y += deltaY;

            }

            return rectangleStack;
        }

    }
}
