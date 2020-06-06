using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace fuckaround2
{
    public class SpriteSheetParameters
    {
        public Vector2 Origin;
        public int RowHeight;
        public int ColumnWidth;
        public int NumberRows;
        public int NumberColumns;
        public int RowBuffer;
        public int ColumnBuffer;


        public SpriteSheetParameters(Vector2 origin, int rowHeight, int columnWidth, int numberRows, int numberColumns, int rowBuffer, int columnBuffer)
        {
            Origin = origin;
            RowHeight = rowHeight;
            ColumnWidth = columnWidth;
            NumberRows = numberRows;
            NumberColumns = numberColumns;
            RowBuffer = rowBuffer;
            ColumnBuffer = columnBuffer;
        }
    }
}
