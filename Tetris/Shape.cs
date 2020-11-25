using System;

namespace Tetris
{
    class Shape
    {
        public Shape(int row, int column, Square[] squares)
        {
            Row = row;
            Column = column;
            Grid = squares;
        }

        public int Row { get; set; }
        public int Column { get; set; }
        public Square[] Grid { get; set; }

        public static Shape GenerateTetromino()
        {
            int random = new Random().Next(0, 7);

            switch (random)
            {
                //I
                case 0:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 0, ShapeColors.Cyan),
                        new Square(0, 1, ShapeColors.Cyan),
                        new Square(0, 2, ShapeColors.Cyan),
                        new Square(0, 3, ShapeColors.Cyan)
                    });
                //J
                case 1:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 0, ShapeColors.Blue),
                        new Square(1, 0, ShapeColors.Blue),
                        new Square(1, 1, ShapeColors.Blue),
                        new Square(1, 2, ShapeColors.Blue)
                    });
                //L
                case 2:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 2, ShapeColors.Orange),
                        new Square(1, 0, ShapeColors.Orange),
                        new Square(1, 1, ShapeColors.Orange),
                        new Square(1, 2, ShapeColors.Orange)
                    });
                //O
                case 3:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 0, ShapeColors.Yellow),
                        new Square(0, 1, ShapeColors.Yellow),
                        new Square(1, 0, ShapeColors.Yellow),
                        new Square(1, 1, ShapeColors.Yellow)
                    });
                //S
                case 4:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 1, ShapeColors.Green),
                        new Square(0, 2, ShapeColors.Green),
                        new Square(1, 0, ShapeColors.Green),
                        new Square(1, 1, ShapeColors.Green)
                    });
                //T
                case 5:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 1, ShapeColors.Purple),
                        new Square(1, 0, ShapeColors.Purple),
                        new Square(1, 1, ShapeColors.Purple),
                        new Square(1, 2, ShapeColors.Purple)
                    });
                //Z
                case 6:
                    return new Shape(0, 0, new Square[] {
                        new Square(0, 0, ShapeColors.Red),
                        new Square(0, 1, ShapeColors.Red),
                        new Square(1, 1, ShapeColors.Red),
                        new Square(1, 2, ShapeColors.Red)
                    });
                default:
                    throw new Exception();
            }
        }
    }
}
