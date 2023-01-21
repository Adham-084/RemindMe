using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RemindMe
{
	internal partial class FrmAbout : Form
	{
		public FrmAbout()
		{
			InitializeComponent();
			ThemeManager.SetTheme(this);
		}

		private void FormAbout_Load(object sender, EventArgs e)
		{	
			VersionLbl.Text = "v" + Application.ProductVersion;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/Adham-084/RemindMe");
		}
	}
}
