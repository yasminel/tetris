using System;
using Timers = System.Timers;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Timers.Timer timer;
        private int WIDTH = 800;
        private int HEIGHT = 600;
        private float FPS = 120f;
        private float FRAMESIZE = 1000f / 120f;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Size = new Size(WIDTH, HEIGHT);
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

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {

        }
    }
}


