using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MouseInverter.Properties
{
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool InvertX
		{
			get
			{
				return (bool)this["InvertX"];
			}
			set
			{
				this["InvertX"] = value;
			}
		}

		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool InvertY
		{
			get
			{
				return (bool)this["InvertY"];
			}
			set
			{
				this["InvertY"] = value;
			}
		}

		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
