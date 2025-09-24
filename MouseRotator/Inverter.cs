using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MouseRotator
{
    internal class Inverter
    {
        public Inverter(bool rotate90, bool rotate270)
        {
            this.rotate90 = rotate90;
            this.rotate270 = rotate270;
            this.pos = Cursor.Position;
        }

        public bool Running
        {
            get
            {
                return this.running;
            }
        }

        public bool Rotate90
        {
            get => this.rotate90;
            set
            {
                this.rotate90 = value;
                this.InvertSettingsChanged?.Invoke(this, EventArgs.Empty);

            }
        }

        public bool Rotate270
        {
            get => this.rotate270;
            set
            {
                this.rotate270 = value;
                this.InvertSettingsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void MouseLoop()
        {
            Thread.CurrentThread.IsBackground = true;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            while (!this.exit)
            {
                Point currentPos = Cursor.Position;
                int dx = currentPos.X - this.pos.X;
                int dy = currentPos.Y - this.pos.Y;

                int newX = currentPos.X;
                int newY = currentPos.Y;

                if (rotate90 && !rotate270)
                {
                    // Rotate 90° CW: (dx, dy) -> (dy, -dx)
                    newX = this.pos.X + dy;
                    newY = this.pos.Y - dx;
                }
                else if (rotate270 && !rotate90)
                {
                    // Rotate 270° CW (90° CCW): (dx, dy) -> (-dy, dx)
                    newX = this.pos.X - dy;
                    newY = this.pos.Y + dx;
                }
                else
                {
                    // No rotation
                    newX = currentPos.X;
                    newY = currentPos.Y;
                }

                // Clamp to screen bounds
                Rectangle bounds = Screen.FromPoint(currentPos).Bounds;
                newX = Math.Max(bounds.Left + 2, Math.Min(bounds.Right - 2, newX));
                newY = Math.Max(bounds.Top + 2, Math.Min(bounds.Bottom - 2, newY));

                Cursor.Position = new Point(newX, newY);
                this.pos = Cursor.Position;

                Thread.Sleep(1);

            }

            this.exit = false;
        }

        public void Start()
        {
            this.pos = Cursor.Position;
            this.running = true;
            Thread thread = new Thread(new ThreadStart(this.MouseLoop)) { IsBackground = true };
            thread.Start();
        }

        public void Stop()
        {
            this.running = false;
            this.exit = true;
        }

        private Point pos = Cursor.Position;
        private bool rotate90;
        private bool rotate270;
        private bool running;
        private bool exit;

        public EventHandler InvertSettingsChanged;
    }
}
