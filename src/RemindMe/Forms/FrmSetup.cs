using IWshRuntimeLibrary;
using System;
using System.Windows.Forms;
using File = System.IO.File;

namespace RemindMe
{
	public partial class FrmSetup : Form
	{
		public FrmSetup(bool portable)
		{
			InitializeComponent();

			if (portable)
			{
				DesktopChk.Enabled = false;
				DesktopChk.Checked = false;
				StartupChk.Enabled = false;
				StartupChk.Checked = false;
			}
		}

		#region Events

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			if (DesktopChk.Checked)
			{
				try
				{
					object shDesktop = "Desktop";
					WshShell shell = new WshShell();
					string desktopAddress = (string)shell.SpecialFolders.Item(ref shDesktop);

					IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(desktopAddress + @"\Remind Me.lnk");

					shortcut.TargetPath = Application.ExecutablePath;
					shortcut.WorkingDirectory = Application.StartupPath;
					shortcut.Description = "Remind Me." + Environment.NewLine + "Version: " + Application.ProductVersion;
					shortcut.Save();

					if (File.Exists(desktopAddress + @"\ذكرني.lnk"))
						File.Delete(desktopAddress + @"\ذكرني.lnk");

					File.Move(desktopAddress + @"\Remind Me.lnk", desktopAddress + @"\ذكرني.lnk");
				}
				catch
				{
					//TODO: Message
				}
			}

			Core.StartupItem(StartupChk.Checked);
			
			using (FrmLocation location = new FrmLocation())
			{
				DialogResult = location.ShowDialog();
			}

			Properties.Settings.Default.Startup = StartupChk.Checked;
			Properties.Settings.Default.Save();

			Close();
		}

		#endregion
	}
}
