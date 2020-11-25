using System.Drawing;

namespace Tetris
{
    class Painter
    {
        public void DrawGuide(Graphics g)
        {
            for (int i = 0; i < Config.COLUMNS; i++)
            {
                g.DrawLine(new Pen(UiColors.Guide), i * Config.SQUARE_SIZE, 0, i * Config.SQUARE_SIZE, Config.WINDOW_HEIGHT);
            }
            for (int i = 0; i < Config.ROWS; i++)
            {
                g.DrawLine(new Pen(UiColors.Guide), 0, i * Config.SQUARE_SIZE, Config.WINDOW_WIDTH, i * Config.SQUARE_SIZE);
            }
        }

        private void DrawSquare(Graphics g, Square square, int refRow, int refColumn)
        {
            int X = (refColumn + square.Column) * Config.SQUARE_SIZE;
            int Y = (refRow + square.Row) * Config.SQUARE_SIZE;
            g.FillRectangle(new SolidBrush(square.Color), X, Y, Config.SQUARE_SIZE, Config.SQUARE_SIZE);
        }

        public void DrawBackground(Graphics g)
        {
            g.Clear(UiColors.Background);
        }

        public void DrawShape(Graphics g, Shape shape)
        {
            foreach (Square square in shape.Grid)
            {
                DrawSquare(g, square, shape.Row, shape.Column);
            }
        }
    }
}
