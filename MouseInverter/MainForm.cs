using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MouseInverter.Properties;

namespace MouseInverter
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.InitializeComponent();
			this.invert = new Inverter(Settings.Default.InvertX, Settings.Default.InvertY);
			this.invert.InvertSettingsChanged += this.invert_InvertSettingsChanged;
			this.UpdateCheckBoxes();
		}

		private void UpdateCheckBoxes()
		{
			this.chkInvertX.Checked = this.invert.InvertX;
			this.chkInvertY.Checked = this.invert.InvertY;
			this.tsmiInvertX.Checked = this.invert.InvertX;
			this.tsmiInvertY.Checked = this.invert.InvertY;
		}

		private void invert_InvertSettingsChanged(object sender, EventArgs e)
		{
			Settings.Default.InvertX = this.invert.InvertX;
			Settings.Default.InvertY = this.invert.InvertY;
			Settings.Default.Save();
			this.UpdateCheckBoxes();
		}

		private void RegisterHotkeys()
		{

			this.hotkeyX.KeyCode = Keys.X;
			this.hotkeyX.Windows = true;
			this.hotkeyX.Alt = true;
			this.hotkeyX.Pressed += delegate
			{
				this.invert.InvertX = !this.invert.InvertX;
			};
            this.hotkeyY.KeyCode = Keys.Y;
            this.hotkeyY.Windows = true;
            this.hotkeyY.Alt = true;
            this.hotkeyY.Pressed += delegate
            {
                this.invert.InvertY = !this.invert.InvertY;
            };

            if (!this.hotkeyX.Register(this) || !this.hotkeyY.Register(this))
			{
				if (this.hotkeyX.Registered)
					this.hotkeyX.Unregister();
                if (this.hotkeyY.Registered)
					this.hotkeyY.Unregister();

				this.hotkeyX.Alt = false;
				this.hotkeyY.Alt = false;
                this.hotkeyX.Shift = true;
                this.hotkeyY.Shift = true;

				if (!this.hotkeyX.Register(this))
				{
                    MessageBox.Show("Could not register Win-Alt-X hotkey or its Win-Shift-X fallback. Hotkey will not work.");
                }
                if (!this.hotkeyY.Register(this))
                {
                    MessageBox.Show("Could not register Win-Alt-Y hotkey or its Win-Shift-Y fallback. Hotkey will not work.");
                }
				if (this.hotkeyX.Registered && this.hotkeyY.Registered)
				{
                    MessageBox.Show("The default hotkeys could not be registered.\nWin-Shift-X / Win-Shift-Y fallback hotkeys are being used.");
                }
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.SetHighPriority();
			this.RegisterHotkeys();
			this.invert.Start();
		}

		private void SetHighPriority()
		{
			Process currentProcess = Process.GetCurrentProcess();
			try
			{
				currentProcess.PriorityClass = ProcessPriorityClass.RealTime;
			}
			catch
			{
			}
			if (currentProcess.PriorityClass != ProcessPriorityClass.RealTime)
			{
				currentProcess.PriorityClass = ProcessPriorityClass.High;
			}
		}

		private void chkInvertX_CheckedChanged(object sender, EventArgs e)
		{
			this.invert.InvertX = this.chkInvertX.Checked;
		}

		private void chkInvertY_CheckedChanged(object sender, EventArgs e)
		{
			this.invert.InvertY = this.chkInvertY.Checked;
		}

		private void tsmiInvertX_Click(object sender, EventArgs e)
		{
			this.invert.InvertX = this.tsmiInvertX.Checked;
		}

		private void tsmiInvertY_Click(object sender, EventArgs e)
		{
			this.invert.InvertY = this.tsmiInvertY.Checked;
		}

		private void MainForm_LocationChanged(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Normal;
				base.Hide();
			}
		}

		private void notifiyIcon_DoubleClick(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Normal;
			base.Show();
		}

		private Inverter invert;

		private Hotkey hotkeyX = new Hotkey();

		private Hotkey hotkeyY = new Hotkey();
	}
}
