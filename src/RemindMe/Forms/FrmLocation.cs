using System;
using System.Windows.Forms;

namespace RemindMe
{
	public partial class FrmLocation : Form
	{
		private int time;
		private bool LocationSet;

		public FrmLocation()
		{
			InitializeComponent();
		}

		private void TryingTimer_Tick(object sender, EventArgs e)
		{
			if (time <= 0)
			{
				if (Core.GetLocation())
				{
					pictureBox1.Image = Properties.Resources.Done;
					label1.Text = "تم الحصول على الموقع";
					label2.Text = Properties.Settings.Default.Country + ", " + Properties.Settings.Default.City;
					button1.Text = "متابعة";
					LocationSet = true;
					TryingTimer.Stop();
				}
				else
				{
					label1.Text = "حصل خطأ أثناء الاتصال بالإنترنت." + Environment.NewLine + "يجب توفير اتصال بالانترنت من أجل تحديد موقعك.";
					label2.Text = "إعادة المحاولة بعد 10";
					time = 10;
				}
			}
			else
			{
				time--;
				label2.Text = "إعادة المحاولة بعد " + time;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (LocationSet)
			{
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				DialogResult = DialogResult.Cancel;
				Application.Exit();
			}
		}
	}
}
