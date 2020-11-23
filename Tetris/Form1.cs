using System;
using Timers = System.Timers;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Drawing2D;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Player player;
        private Timers.Timer timer;
        private int WIDTH = 800;
        private int HEIGHT = 600;
        private float FPS = 120f;
        private float FRAMESIZE = 1000f / 120f;
        private bool isUpDown = false;
        private bool isDownDown = false;
        private bool isLeftDown = false;
        private bool isRightDown = false;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Size = new Size(WIDTH, HEIGHT);
            player = new Player(45, 31, 90);

            Load += OnLoad;
        }

        protected void OnLoad(object sender, EventArgs e)
        {
            timer = new Timers.Timer(FRAMESIZE);
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            float dt = 1 / FPS;
            float speed = 400f * dt;
         
            if (isUpDown)
            {
                player.Y -= speed;
            }
            if (isDownDown)
            {
                player.Y += speed;
            }
            if (isLeftDown)
            {
                player.X -= speed;
            }
            if (isRightDown)
            {
                player.X += speed;
            }

            if (player.X >= WIDTH)
            {
                player.X = -player.Radius;
            }
            if (player.X < -player.Radius)
            {
                player.X = WIDTH;
            }

            if (player.Y >= HEIGHT)
            {
                player.Y = -player.Radius;
            }
            if (player.Y < -player.Radius)
            {
                player.Y = HEIGHT;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.FromArgb(33, 33, 33));
            Brush b = new SolidBrush(Color.Pink);
            e.Graphics.FillEllipse(b, player.X, player.Y, player.Radius, player.Radius);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    isUpDown = true;
                    break;
                case "Down":
                    isDownDown = true;
                    break;
                case "Left":
                    isLeftDown = true;
                    break;
                case "Right":
                    isRightDown = true;
                    break;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    isUpDown = false;
                    break;
                case "Down":
                    isDownDown = false;
                    break;
                case "Left":
                    isLeftDown = false;
                    break;
                case "Right":
                    isRightDown = false;
                    break;
            }
        }
    }

    class Player
    {
        public float Radius { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public Player(float x, float y, float radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
}


