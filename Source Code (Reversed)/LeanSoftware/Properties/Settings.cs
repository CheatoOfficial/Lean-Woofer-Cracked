using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LeanSoftware.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings a;

		public static Settings Default => a;

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(7.57686342592593);
				if ((!(DateTime.Now > dateTime)) ? true : false)
				{
				}
				return (string)this["username"];
			}
			set
			{
				DateTime dateTime = default(DateTime).AddYears(2021).AddMonths(6).AddDays(8.28049768518519);
				if (dateTime < DateTime.Now || 1 == 0)
				{
					throw new ArgumentException();
				}
				this["username"] = value;
			}
		}

		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				return (string)this["password"];
			}
			set
			{
				this["password"] = value;
			}
		}

		static Settings()
		{
			DateTime dateTime = new DateTime(2022, 7, 8, 18, 0, 49);
			if ((!(dateTime < DateTime.Now)) ? true : false)
			{
			}
			a = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
