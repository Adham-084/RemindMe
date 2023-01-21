using System;
using System.Drawing;
using System.Windows.Forms;

namespace RemindMe
{
	public partial class FrmNotification : Form
	{
		public FrmNotification()
		{
			InitializeComponent();
			ThemeManager.SetTheme(this);
		}
		
		#region Events

		private void FormNotification_Load(object sender, EventArgs e)
		{
			Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Size.Width, Screen.PrimaryScreen.WorkingArea.Height - Size.Height);
			Time.Font = new Font(ThemeManager.myFont.Families[0], 20);
		}

		private void FormNotification_Clicked(object sender, EventArgs e)
		{
			Core.playerThread.Interrupt();
		}

		#endregion
	}
}
