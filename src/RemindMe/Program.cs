using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RemindMe
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			bool portable = false;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			foreach (DriveInfo drive in DriveInfo.GetDrives())
			{
				if (drive.DriveType == DriveType.Removable)
				{
					if (Application.ExecutablePath.StartsWith(drive.Name))
					{
						portable = true;
						MessageBox.Show("البرنامج يعمل من قرص قابل للإزالة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						//DialogResult result = MessageBox.Show("البرنامج يعمل من قرص قابل للإزالة." + Environment.NewLine + "هل تريد نقله إلى التخزين الثابت؟" , "تنبيه", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

						//switch (result)
						//{
						//	case DialogResult.Yes: //Need Testing
						//		FolderBrowserDialog browseDialog = new FolderBrowserDialog();
						//		if (browseDialog.ShowDialog() == DialogResult.Cancel)
						//			return;

						//		foreach(string file in Directory.GetFiles(Application.StartupPath))
						//		{//Make sure this file is the program's before copy
						//			File.Copy(file, browseDialog.SelectedPath, true);
						//		}

						//		Process.Start(browseDialog.SelectedPath + @"\RemindMe.exe");
						//		return;

						//	case DialogResult.Cancel:
						//		return;
						//}

						break;
					}
				}
			}

			Mutex mutex = new Mutex(true, Application.ProductName, out bool createdNew);

			if (!createdNew)
			{
				MessageBox.Show("البرنامج يعمل في الخلفية." + Environment.NewLine + "اضغط على الأيقونة بجوار الساعة لعرضه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (Properties.Settings.Default.FirstRun)
			{
				using (FrmSetup form = new FrmSetup(portable))
				{
					if (form.ShowDialog() == DialogResult.Cancel) return;
				}

				Properties.Settings.Default.FirstRun = false;
				Properties.Settings.Default.Save();
			}

			Application.Run(new FrmTimes());

			if (portable)
			{
				Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Application.CompanyName);
			}
		}
	}
}
