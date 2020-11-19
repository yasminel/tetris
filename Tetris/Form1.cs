using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Player p = new Player(45, 31, 30);

        public Form1()
        {
            InitializeComponent();
            Size = new Size(800, 600);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(33, 33, 33));
            Brush b = new SolidBrush(Color.Pink);
            e.Graphics.FillEllipse(b, p.X, p.Y, p.Radius, p.Radius);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    p.Y -= 20;
                    break;
                case "Down":
                    p.Y += 20;
                    break;
                case "Left":
                    p.X -= 20;
                    break;
                case "Right":
                    p.X += 20;
                    break;
            }
            Invalidate();
        }
    }

    class Player
    {
        public int Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Player(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
}


