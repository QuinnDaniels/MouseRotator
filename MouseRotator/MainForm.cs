using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MouseRotator.Properties;

namespace MouseRotator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.InitializeComponent();
			this.invert = new Inverter(Settings.Default.Rotate90, Settings.Default.Rotate270);
			this.invert.InvertSettingsChanged += this.invert_InvertSettingsChanged;
			this.UpdateCheckBoxes();
		}

		private void UpdateCheckBoxes()
		{
			this.chkRotate90.Checked = this.invert.Rotate90;
			this.chkRotate270.Checked = this.invert.Rotate270;
			this.tsmiRotate90.Checked = this.invert.Rotate90;
			this.tsmiRotate270.Checked = this.invert.Rotate270;
		}

		private void invert_InvertSettingsChanged(object sender, EventArgs e)
		{
			Settings.Default.Rotate90 = this.invert.Rotate90;
			Settings.Default.Rotate270 = this.invert.Rotate270;
			Settings.Default.Save();
			this.UpdateCheckBoxes();
		}

		private void RegisterHotkeys()
		{

			this.hotkeyX.KeyCode = Keys.Home; // Left; //Keys.F18; // X --> Left	// MS PowerToys - Keyboard Remapper: Allow Chords; [Alt (right)] + [Left] > [Apps/Menu]
            this.hotkeyX.Windows = true;	// true --> false
			this.hotkeyX.Alt = false;        // true --> false

			this.hotkeyX.Control = true; // added just in case

            this.hotkeyX.Shift = true;

			this.hotkeyX.Pressed += delegate
			{
				this.invert.Rotate90 = !this.invert.Rotate90;
			};
			this.hotkeyY.KeyCode = Keys.End; // Right; // Keys.F17; //Y --> Right	// MS PowerToys - Keyboard Remapper: Allow Chords; [Alt (right)] + [Right] > [Apps/Menu]
            this.hotkeyY.Windows = true;	// true --> false
            this.hotkeyY.Alt = false;       // true --> false

			this.hotkeyY.Control = true; // added just in case
			this.hotkeyY.Shift = true;

			this.hotkeyY.Pressed += delegate
            {
                this.invert.Rotate270 = !this.invert.Rotate270;
            };

            if (!this.hotkeyX.Register(this) || !this.hotkeyY.Register(this))
			{
				if (this.hotkeyX.Registered)
					this.hotkeyX.Unregister();
                if (this.hotkeyY.Registered)
					this.hotkeyY.Unregister();

				this.hotkeyX.Alt = false;
				this.hotkeyY.Alt = false;
				this.hotkeyX.Shift = false; // true
                this.hotkeyY.Shift = false; // true

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
		// Click check box
		private void chkRotate90_CheckedChanged(object sender, EventArgs e)
		{
			this.invert.Rotate90 = this.chkRotate90.Checked;
            if (this.chkRotate270.Checked)
            {
                this.invert.Rotate270 = !this.invert.Rotate90;
            }
        }
		// Click check box
		private void chkRotate270_CheckedChanged(object sender, EventArgs e)
		{
			this.invert.Rotate270 = this.chkRotate270.Checked;
			if (this.chkRotate90.Checked) 
			{
				this.invert.Rotate90 = !this.invert.Rotate270;
			}
		}

		private void tsmiRotate90_Click(object sender, EventArgs e)
		{
			this.invert.Rotate90 = this.tsmiRotate90.Checked;
            if (this.chkRotate270.Checked)
            {
                this.invert.Rotate90 = !this.invert.Rotate270;
            }
        }

		private void tsmiRotate270_Click(object sender, EventArgs e)
		{
			this.invert.Rotate270 = this.tsmiRotate270.Checked;
            if (this.chkRotate90.Checked)
            {
                this.invert.Rotate270 = !this.invert.Rotate90;
            }
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
