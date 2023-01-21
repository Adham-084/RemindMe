using Microsoft.Win32;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace RemindMe
{
	public partial class FrmTimes : Form
	{
		#region Fields

		private readonly string[] athanNames = { "الفجر", "الشروق", "الظهر", "العصر", "المغرب", "العشاء" };
		private readonly string[] arDays = { "الأحد", "الإثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة", "السبت" };
		private TimeSpan[] athanTimes = new TimeSpan[6];

		private bool alarmDone;
		private bool athanDone;

		private TimeSpan timeRemains;
		private DateTime dateTimeNow;
		private TimesCalculator calculater;
		private int nextAthan;
		private readonly Label[] texts = new Label[6];

		private SoundPlayer player;
		private FrmNotification notify;
		private string day;

		#endregion

		public FrmTimes()
		{
			InitializeComponent();

			texts[0] = FajrLbl;
			texts[1] = SunriseLbl;
			texts[2] = DhuhrLbl;
			texts[3] = AsrLbl;
			texts[4] = MaghribLbl;
			texts[5] = IshaLbl;

			ThemeManager.LoadCustomFontToMemory();
			SetCustomFont();

			ThemeManager.LoadThemes();
			ThemeManager.SetTheme(this);

			SetSystemEvents();
		}

		#region Event

		private void Form_Load(object sender, EventArgs e)
		{
			if (!Properties.Settings.Default.LocationSet)
				if (!Core.GetLocation())
					Application.Exit();
			
			dateTimeNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
			calculater = new TimesCalculator(
				dateTimeNow,
				Properties.Settings.Default.Lat,
				Properties.Settings.Default.Long,
				Properties.Settings.Default.TimeFormat,
				Properties.Settings.Default.Method
			);

			CalculateTimes();
			SelectNextAthan(true);
			Tick();
		}

		private void FormTimes_Shown(object sender, EventArgs e)
		{
			if (Environment.GetCommandLineArgs().Length > 1)
				if (Environment.GetCommandLineArgs()[1] == "win")
					Hide();

			ShowInTaskbar = true;
			Opacity = 100;
		}

		private void MainTimer_Tick(object sender, EventArgs e)
		{
			Tick();

			if (Properties.Settings.Default.Alarm)
			{
				if (TimeSpan.Parse(TimeLbl.Text) == new TimeSpan(0, Properties.Settings.Default.AlarmBefore, 0))
				{
					if (!alarmDone)
					{
						alarmDone = true;
						ViewNotification(GetCountWord() + athanNames[nextAthan], 
							texts[nextAthan].Text, 0, ThemeManager.currentTheme[ThemeManager.ALARM_COLOR]);
					}
				}
			}
		
			if (TimeSpan.Parse(TimeLbl.Text) <= TimeSpan.Zero)
			{
				if (!athanDone)
				{
					athanDone = true;

					if (timeRemains < new TimeSpan(0, -1, 0))
						goto TooLate;

					ViewNotification("حان الآن موعد أذان " + athanNames[nextAthan], 
						texts[nextAthan].Text, nextAthan == 0 ? 2 : 1, ThemeManager.currentTheme[ThemeManager.ATHAN_COLOR]);
				}

			TooLate: SelectNextAthan(true);
			}
		}

		private void FormTimes_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Space)
			{
				DateBtn.Size -= new Size(0, 1);
				System.Diagnostics.Debug.WriteLine(DateBtn.Size.Height);
			}

			if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.T)
			{
				FrmThemeMaker themeMaker = new FrmThemeMaker();
				themeMaker.ShowDialog();
			}
		}

		private void FormTimes_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				if (Properties.Settings.Default.Tray)
				{
					e.Cancel = true;
					Hide();
					
					if (Properties.Settings.Default.FirstClose)
					{
						TrayIcon.ShowBalloonTip(5000);

						Properties.Settings.Default.FirstClose = false;
						Properties.Settings.Default.Save();
					}
				}
			}
		}

		private void OptionsBtn_Click(object sender, EventArgs e)
		{
			using (FrmOptions frm = new FrmOptions())
			{
				frm.ShowDialog();
			}

			ThemeManager.SetTheme(this);
			CalculateTimes();
			SelectNextAthan(true);
		}

		private void XBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		//-{Tray Icon}---------------------------------------------------------------------

		private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Show();
			}
		}

		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//-{System Events}-----------------------------------------------------------------

		private void SystemEvents_TimeChanged(object sender, EventArgs e)
		{
			dateTimeNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
			CalculateTimes();
			SelectNextAthan(false);
		}

		private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
		{
			if (e.Mode == PowerModes.Resume)
				SelectNextAthan(false);
		}

		#endregion

		#region Methods

		private void Tick()
		{
			dateTimeNow = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
			RemainingTime();
			TimeLbl.Text = timeRemains.ToString().Remove(5);
			TrayIcon.Text = "الوقت المتبقي للأذان: " + TimeLbl.Text;
			DayLbl.Text = day;
			DateBtn.Text = string.Format("{0:00}-{1:00}-{2}", dateTimeNow.Day, dateTimeNow.Month, dateTimeNow.Year);
		}

		private void CalculateTimes()
		{
			string[] times12 = calculater.GetTimes();
			calculater.TimeFormat = 0;
			string[] times24 = calculater.GetTimes();
			calculater.TimeFormat = 1;

			for (int i = 0; i < times12.Length; i++)
			{
				texts[i].Text = times12[i];
				athanTimes[i] = TimeSpan.Parse(times24[i]);
			}
		}

		public void SelectNextAthan(bool resetAlarms)
		{
			if (resetAlarms)
			{
				alarmDone = false;
				athanDone = false;
			}

			day = arDays[(int)dateTimeNow.DayOfWeek];

			for (int i = 0; i < 6; i++)
			{
				if (athanTimes[i] - dateTimeNow.TimeOfDay > TimeSpan.Zero)
				{
					texts[nextAthan].ForeColor = ThemeManager.currentTheme[4];
					texts[i].ForeColor = ThemeManager.currentTheme[5];
					nextAthan = i == 1 ? 2 : i;
					return;
				}
			}

			//Calculate times for tomorrow
			texts[nextAthan].ForeColor = ThemeManager.currentTheme[4];
			texts[0].ForeColor = ThemeManager.currentTheme[5];
			nextAthan = 0;

			if (dateTimeNow.Day == DateTime.Now.Day)
			{
				dateTimeNow = dateTimeNow.AddDays(1);
				calculater.AddDay();
			}

			day = "غداً, " + arDays[(int)dateTimeNow.DayOfWeek];
			CalculateTimes();
		}

		private void RemainingTime()
		{
			if (nextAthan != 0)
			{
				timeRemains = athanTimes[nextAthan] - dateTimeNow.TimeOfDay;
			}
			else
			{
				timeRemains = (athanTimes[0] + TimeSpan.FromDays(1)) - dateTimeNow.TimeOfDay;
			}
		}

		private void ViewNotification(string msg, string time, int type, Color color)
		{
			notify = new FrmNotification();
			notify.CaptionLbl.Text = msg;
			notify.Time.Text = time;
			notify.ColorBar.BackColor = color;
			notify.Show();

			Core.playerThread = new Thread(new ThreadStart(() => NotificationThread(type)));
			Core.playerThread.Start();
		}

		private string GetCountWord()
		{
			return Properties.Settings.Default.AlarmBefore <= 10 ? " باقي من الوقت " + Properties.Settings.Default.AlarmBefore + " دقائق حتى أذان " :
				" باقي من الوقت " + Properties.Settings.Default.AlarmBefore + " دقيقة حتى أذان ";
		}

		private void NotificationThread(int type)
		{
			switch (type)
			{
				case 0:
					player = new SoundPlayer(Properties.Resources.Alarm);
					player.PlayLooping();

					try { Thread.Sleep(TimeSpan.FromSeconds(30)); } catch { }
					break;

				case 1:
					if (Properties.Settings.Default.Athan)
					{
						player = new SoundPlayer(Properties.Resources.Athan);
						player.Play();
					}

					try { Thread.Sleep(new TimeSpan(0, 3, 31)); } catch { }

					break;

				case 2:
					if (Properties.Settings.Default.Athan)
					{
						player = new SoundPlayer(Properties.Resources.Fajr);
						player.Play();
					}

					try { Thread.Sleep(new TimeSpan(0, 3, 5)); } catch { }

					break;
			}

			try { player.Stop(); } catch { }
			
			Invoke((MethodInvoker) delegate
			{
				notify.Close();
				notify.Dispose();
			});
		}

		private void SetCustomFont()
		{
			FajrLbl.Font = new Font(ThemeManager.myFont.Families[0], 16);
			SunriseLbl.Font = new Font(ThemeManager.myFont.Families[0], 16);
			DhuhrLbl.Font = new Font(ThemeManager.myFont.Families[0], 16);
			AsrLbl.Font = new Font(ThemeManager.myFont.Families[0], 16);
			MaghribLbl.Font = new Font(ThemeManager.myFont.Families[0], 16);
			IshaLbl.Font = new Font(ThemeManager.myFont.Families[0], 16);

			TimeLbl.Font = new Font(ThemeManager.myFont.Families[0], 20);
			DateBtn.Font = new Font(ThemeManager.myFont.Families[0], 16);
		}

		private void DateBtn_Click(object sender, EventArgs e)
		{
			using (FrmMonth frm = new FrmMonth())
			{
				DateTime date = new DateTime(dateTimeNow.Year, dateTimeNow.Month, 1);
				int n = (int)date.DayOfWeek;

				frm.label1.Text = "مواقيت الصلاة عن شهر " + dateTimeNow.Month + " لعام " + dateTimeNow.Year;

				TimesCalculator tCalculater = new TimesCalculator(
					date,
					Properties.Settings.Default.Lat,
					Properties.Settings.Default.Long,
					Properties.Settings.Default.TimeFormat,
					Properties.Settings.Default.Method
				);

				string[] times;
				string[] items;

				for (int i = 1; i <= DateTime.DaysInMonth(dateTimeNow.Year, dateTimeNow.Month); i++)
				{
					times = tCalculater.GetTimes();
					items = new string[] { i.ToString(), arDays[(i + n - 1) % 7],times[0], times[1], times[2], times[3], times[4], times[5] };

					frm.listView1.Items.Add(new ListViewItem(items));
					tCalculater.AddDay();
				}

				frm.listView1.Items[dateTimeNow.Day - 1].BackColor = ThemeManager.currentTheme[ThemeManager.SELECTED_TEXT_COLOR];
				frm.ShowDialog();
			}
		}

		public void SetSystemEvents()
		{
			SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
			SystemEvents.TimeChanged += SystemEvents_TimeChanged;
		}
		#endregion
	}
}
