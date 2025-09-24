using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MouseInverter
{
	internal class Inverter
	{
		public Inverter(bool x, bool y)
		{
			this.invertX = x;
			this.invertY = y;
			this.pos = Cursor.Position;
		}

		public bool Running
		{
			get
			{
				return this.running;
			}
		}

		public bool InvertX
		{
			get
			{
				return this.invertX;
			}
			set
			{
				this.invertX = value;
				if (this.InvertSettingsChanged != null)
				{
					this.InvertSettingsChanged(this, new EventArgs());
				}
			}
		}

		public bool InvertY
		{
			get
			{
				return this.invertY;
			}
			set
			{
				this.invertY = value;
				if (this.InvertSettingsChanged != null)
				{
					this.InvertSettingsChanged(this, new EventArgs());
				}
			}
		}

		private void MouseLoop()
		{
			Thread.CurrentThread.IsBackground = true;
			Thread.CurrentThread.Priority = ThreadPriority.Highest;
			while (!this.exit)
			{
				Point position = Cursor.Position;
				int x = (this.invertX ? (this.pos.X - (position.X - this.pos.X)) : position.X);
				if (this.invertX)
				{
					if (x < 2)
					{
						x = 2;
					}
					if (x > Screen.FromPoint(position).Bounds.Right - 2)
					{
						x = Screen.FromPoint(position).Bounds.Right - 2;
					}
				}
				int y = (this.invertY ? (this.pos.Y - (position.Y - this.pos.Y)) : position.Y);
				if (this.invertY)
				{
					if (y < 2)
					{
						y = 2;
					}
					if (y > Screen.FromPoint(position).Bounds.Bottom - 2)
					{
						y = Screen.FromPoint(position).Bounds.Bottom - 2;
					}
				}
				Cursor.Position = new Point(x, y);
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

		private bool invertX;

		private bool invertY;

		private bool running;

		private bool exit;

		public EventHandler InvertSettingsChanged;
	}
}
