using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using File = System.IO.File;

namespace RemindMe
{
	public class Core
	{
		public static Thread playerThread;

		//public static void StartupItemOld(bool enable)
		//{
		//	if (enable)
		//	{
		//		TryAgain:
		//		try
		//		{
		//			object shStartup = (object)"Startup";
		//			WshShell shell = new WshShell();
		//			string shortcutAddress = (string)shell.SpecialFolders.Item(ref shStartup) + @"\RemindMe.lnk";
		//			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);

		//			shortcut.TargetPath = Application.ExecutablePath;
		//			shortcut.Arguments = "win";
		//			shortcut.WorkingDirectory = Application.StartupPath;
		//			shortcut.Description = "التنبيه بأوقات الأذان والصلاة.";
		//			shortcut.Save();
		//		}
		//		catch
		//		{
		//			if (MessageBox.Show("حدث خطأ أثناء محاولة إضافة البرنامج إلى عناصر بدء التشغيل.", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
		//			{
		//				goto TryAgain;
		//			}
		//			else
		//			{
		//				Properties.Settings.Default.Tray = false;
		//				foreach(Form frm in Application.OpenForms)
		//				{
		//					if (frm.Name == "FormOptions")
		//					{
		//						((FormOptions)frm).checkBox4.Checked = false;
		//						break;
		//					}
		//				}
		//			}
		//		}
		//	}
		//	else
		//	{
		//		string startUpFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

		//		if (File.Exists(startUpFolderPath + @"\RemindMe.lnk"))
		//			File.Delete(startUpFolderPath + @"\RemindMe.lnk");
		//	}
		//}

		public static void StartupItem(bool enable)
		{
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			if (enable)
			{
				while (true)
				{
					try
					{
						rk.SetValue(Application.ProductName, "\"" + Application.ExecutablePath + "\" win");
					}
					catch
					{
						if (MessageBox.Show("حدث خطأ أثناء محاولة إضافة البرنامج إلى عناصر بدء التشغيل.", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
						{
							Properties.Settings.Default.Tray = false;
							foreach (Form frm in Application.OpenForms)
							{
								if (frm.Name == "FormOptions")
								{
									((FrmOptions)frm).StartupChk.Checked = false;
									break;
								}
							}

							break;
						}
					}
				}
			}
			else
			{
				rk.DeleteValue(Application.ProductName, false);
			}
		}

		public static bool GetLocation()
		{
			try
			{
				string response = "";

				using (WebClient client = new WebClient())
				{
					response = client.DownloadString("http://www.geoplugin.net/json.gp");
				}

				JObject data = (JObject)JsonConvert.DeserializeObject(response);
				
				string lat = data["geoplugin_latitude"].Value<string>();
				string lng = data["geoplugin_longitude"].Value<string>();
				string city = data["geoplugin_city"].Value<string>();
				string country = data["geoplugin_countryName"].Value<string>();

				Properties.Settings.Default.Lat = double.Parse(lat);
				Properties.Settings.Default.Long = double.Parse(lng);
				Properties.Settings.Default.City = city;
				Properties.Settings.Default.Country = country;

				if (!Properties.Settings.Default.LocationSet) Properties.Settings.Default.LocationSet = true;

				Properties.Settings.Default.Save();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
