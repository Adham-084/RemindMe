using System;
using System.Windows.Forms;

namespace RemindMe
{
	public partial class FrmOptions : Form
	{
		public FrmOptions()
		{
			InitializeComponent();
			ThemeManager.SetTheme(this);

			foreach (string theme in ThemeManager.themes.Keys)
			{
				ThemeList.Items.Add(theme);
			}

			AlarmTimeUpDown.Value = Properties.Settings.Default.AlarmBefore;
			LatText.Text = Properties.Settings.Default.Lat.ToString();
			LongText.Text = Properties.Settings.Default.Long.ToString();
			LocationLabel.Text = Properties.Settings.Default.Country + ", " + Properties.Settings.Default.City;
			ThemeList.Text = Properties.Settings.Default.Theme;
			MethodList.SelectedIndex = Properties.Settings.Default.Method;
			FormatList.SelectedIndex = Properties.Settings.Default.TimeFormat;
			TrayChk.Checked = Properties.Settings.Default.Tray;
			StartupChk.Checked = Properties.Settings.Default.Startup;
			AlarmChk.Checked = Properties.Settings.Default.Alarm;
			AthanChk.Checked = Properties.Settings.Default.Athan;

			AlarmTimeUpDown.Enabled = AlarmChk.Checked;
		}

		#region Events

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
            if(Properties.Settings.Default.Startup != StartupChk.Checked)
            {
                Core.StartupItem(TrayChk.Checked);
                Properties.Settings.Default.Startup = StartupChk.Checked;
            }

			Properties.Settings.Default.AlarmBefore = (int)AlarmTimeUpDown.Value;
			Properties.Settings.Default.Lat = double.Parse(LatText.Text);
			Properties.Settings.Default.Long = double.Parse(LongText.Text);
			Properties.Settings.Default.Theme = ThemeList.Text;
			Properties.Settings.Default.Tray = TrayChk.Checked;
			Properties.Settings.Default.Alarm = AlarmChk.Checked;
			Properties.Settings.Default.Athan = AthanChk.Checked;
			Properties.Settings.Default.Method = MethodList.SelectedIndex;
			Properties.Settings.Default.TimeFormat = FormatList.SelectedIndex;

			Properties.Settings.Default.Save();
			Close();
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			AlarmTimeUpDown.Enabled = AlarmChk.Checked;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (FrmAbout frm = new FrmAbout())
			{
				frm.ShowDialog();
			}
		}

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetLocationBtn_Click(object sender, EventArgs e)
		{
			LatText.Text = "";
			LongText.Text = "";
			LocationLabel.Text = "-";

			using (FrmLocation location = new FrmLocation())
			{
				DialogResult = location.ShowDialog();
			}

			LatText.Text = Properties.Settings.Default.Lat.ToString();
			LongText.Text = Properties.Settings.Default.Long.ToString();
			LocationLabel.Text = Properties.Settings.Default.Country + ", " + Properties.Settings.Default.City;
		}

		#endregion

		private void TitleBar_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void TitleBar_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void TitleBar_MouseUp(object sender, MouseEventArgs e)
		{

		}
	}
}
