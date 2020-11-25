using System.Drawing;

namespace Tetris
{
    class Square
    {
        public Square(int row, int column, Color color)
        {
            Row = row;
            Column = column;
            Color = color;
        }

        public Color Color { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
    }
}
