using System;
using System.Windows.Forms;

namespace RemindMe
{
	internal partial class FrmMonth : Form
	{
		public FrmMonth()
		{
			InitializeComponent();
			ThemeManager.SetTheme(this);
		}

		private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
