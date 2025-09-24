using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MouseRotator
{
	public class Hotkey : IMessageFilter
	{
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern int UnregisterHotKey(IntPtr hWnd, int id);

		public event HandledEventHandler Pressed;

		public Hotkey()
			: this(Keys.None, false, false, false, false)
		{
		}

		public Hotkey(Keys keyCode, bool shift, bool control, bool alt, bool windows)
		{
			this.KeyCode = keyCode;
			this.Shift = shift;
			this.Control = control;
			this.Alt = alt;
			this.Windows = windows;
			Application.AddMessageFilter(this);
		}

		~Hotkey()
		{
			if (this.Registered)
			{
				this.Unregister();
			}
		}

		public Hotkey Clone()
		{
			return new Hotkey(this.keyCode, this.shift, this.control, this.alt, this.windows);
		}

		public bool GetCanRegister(Control windowControl)
		{
			bool flag;
			try
			{
				if (!this.Register(windowControl))
				{
					flag = false;
				}
				else
				{
					this.Unregister();
					flag = true;
				}
			}
			catch (Win32Exception)
			{
				flag = false;
			}
			catch (NotSupportedException)
			{
				flag = false;
			}
			return flag;
		}

		public bool Register(Control windowControl)
		{
			if (this.registered)
			{
				throw new NotSupportedException("You cannot register a hotkey that is already registered");
			}
			if (this.Empty)
			{
				throw new NotSupportedException("You cannot register an empty hotkey");
			}
			this.id = Hotkey.currentID;
			Hotkey.currentID++;
			uint num = (this.Alt ? 1U : 0U) | (this.Control ? 2U : 0U) | (this.Shift ? 4U : 0U) | (this.Windows ? 8U : 0U);
			if (Hotkey.RegisterHotKey(windowControl.Handle, this.id, num, this.keyCode) != 0)
			{
				this.registered = true;
				this.windowControl = windowControl;
				return true;
			}
			if ((long)Marshal.GetLastWin32Error() == 1409L)
			{
				return false;
			}
			throw new Win32Exception();
		}

		public void Unregister()
		{
			if (!this.registered)
			{
				throw new NotSupportedException("You cannot unregister a hotkey that is not registered");
			}
			if (!this.windowControl.IsDisposed && Hotkey.UnregisterHotKey(this.windowControl.Handle, this.id) == 0)
			{
				throw new Win32Exception();
			}
			this.registered = false;
			this.windowControl = null;
		}

		private void Reregister()
		{
			if (!this.registered)
			{
				return;
			}
			Control control = this.windowControl;
			this.Unregister();
			this.Register(control);
		}

		public bool PreFilterMessage(ref Message message)
		{
			return (long)message.Msg == 786L && (this.registered && message.WParam.ToInt32() == this.id) && this.OnPressed();
		}

		private bool OnPressed()
		{
			HandledEventArgs handledEventArgs = new HandledEventArgs(false);
			if (this.Pressed != null)
			{
				this.Pressed(this, handledEventArgs);
			}
			return handledEventArgs.Handled;
		}

		public override string ToString()
		{
			if (this.Empty)
			{
				return "(none)";
			}
			string text = Enum.GetName(typeof(Keys), this.keyCode);
			switch (this.keyCode)
			{
			case Keys.D0:
			case Keys.D1:
			case Keys.D2:
			case Keys.D3:
			case Keys.D4:
			case Keys.D5:
			case Keys.D6:
			case Keys.D7:
			case Keys.D8:
			case Keys.D9:
				text = text.Substring(1);
				break;
			}
			string text2 = "";
			if (this.shift)
			{
				text2 += "Shift+";
			}
			if (this.control)
			{
				text2 += "Control+";
			}
			if (this.alt)
			{
				text2 += "Alt+";
			}
			if (this.windows)
			{
				text2 += "Windows+";
			}
			return text2 + text;
		}

		public bool Empty
		{
			get
			{
				return this.keyCode == Keys.None;
			}
		}

		public bool Registered
		{
			get
			{
				return this.registered;
			}
		}

		public Keys KeyCode
		{
			get
			{
				return this.keyCode;
			}
			set
			{
				this.keyCode = value;
				this.Reregister();
			}
		}

		public bool Shift
		{
			get
			{
				return this.shift;
			}
			set
			{
				this.shift = value;
				this.Reregister();
			}
		}

		public bool Control
		{
			get
			{
				return this.control;
			}
			set
			{
				this.control = value;
				this.Reregister();
			}
		}

		public bool Alt
		{
			get
			{
				return this.alt;
			}
			set
			{
				this.alt = value;
				this.Reregister();
			}
		}

		public bool Windows
		{
			get
			{
				return this.windows;
			}
			set
			{
				this.windows = value;
				this.Reregister();
			}
		}

		private const uint WM_HOTKEY = 786U;

		private const uint MOD_ALT = 1U;

		private const uint MOD_CONTROL = 2U;

		private const uint MOD_SHIFT = 4U;

		private const uint MOD_WIN = 8U;

		private const uint ERROR_HOTKEY_ALREADY_REGISTERED = 1409U;

		private const int maximumID = 49151;

		private static int currentID;

		private Keys keyCode;

		private bool shift;

		private bool control;

		private bool alt;

		private bool windows;

		[XmlIgnore]
		private int id;

		[XmlIgnore]
		private bool registered;

		[XmlIgnore]
		private Control windowControl;
	}
}
