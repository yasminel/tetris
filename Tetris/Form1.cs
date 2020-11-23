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
        private Timers.Timer timer;
        private const float FPS = 120f;
        private float FRAMESIZE = 1000f / FPS;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ClientSize = new Size(Config.WINDOW_WIDTH, Config.WINDOW_HEIGHT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Tetris";
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
            BuildFrame();
            Invalidate();
        }

        private void BuildFrame()
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(Color.FromArgb(33, 33, 33));

            for (int i = 0; i < Config.COLUMNS; i++)
            {
                g.DrawLine(new Pen(Color.Gray), i * Config.SQUARE_SIZE, 0, i * Config.SQUARE_SIZE, Config.WINDOW_HEIGHT);
            }
            for (int i = 0; i < Config.ROWS; i++)
            {
                g.DrawLine(new Pen(Color.Gray), 0, i * Config.SQUARE_SIZE, Config.WINDOW_WIDTH, i * Config.SQUARE_SIZE);
            }

            // draw player

            // draw opponent
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {

        }
    }
}


