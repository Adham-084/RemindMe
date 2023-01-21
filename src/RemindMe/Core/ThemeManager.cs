using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindMe
{
	internal static class ThemeManager
	{
		public const int THEME_SIZE = 10;
		public const int MAIN_COLOR = 0,
			SECONDERY_COLOR = 1,
			TITLE_BAR_COLOR = 2,
			TEXT_BOX_COLOR = 3,
			TEXT_COLOR = 4,
			SELECTED_TEXT_COLOR = 5,
			AYA_COLOR = 6,
			ALARM_COLOR = 7,
			ATHAN_COLOR = 8,
			X_COLOR = 9;

		public static Dictionary<string, Color[]> themes = new Dictionary<string, Color[]>();
		public static Color[] currentTheme;

		public static readonly string themesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\RemindMe Themes";
		public static PrivateFontCollection myFont = new PrivateFontCollection();

		public static void LoadThemes()
		{
			themes.Add("Light", new Color[]
			{
				ColorTranslator.FromHtml("#F6F6F6"),
				ColorTranslator.FromHtml("#F0F0F5"),
				ColorTranslator.FromHtml("#C8C8D2"),
				ColorTranslator.FromHtml("#FFFFFF"),
				Color.Black,
				ColorTranslator.FromHtml("#006EB4"),
				Color.Black,
				Color.Green,
				Color.Red,
				Color.Red
			});

			themes.Add("Dark", new Color[]
			{
				ColorTranslator.FromHtml("#2D2D30"),
				ColorTranslator.FromHtml("#252525"),
				ColorTranslator.FromHtml("#1C1C1C"),
				ColorTranslator.FromHtml("#323238"),
				Color.White,
				ColorTranslator.FromHtml("#008CE6"),
				Color.White,
				Color.Green,
				Color.Red,
				Color.Red
			});

			if (Directory.Exists(themesFolder))
			{
				string theme = "";
				int color;

				foreach (string file in Directory.GetFiles(themesFolder, "*.ptf"))
				{
					theme = file.Substring(file.LastIndexOf('\\') + 1).Replace(".ptf", "");
					themes.Add(theme, new Color[THEME_SIZE]);
					color = 0;

					string text = File.ReadAllText(file);

					string[] lines = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

					for (int i = 0; i < lines.Length; i++)
					{
						if (lines[i].StartsWith("#") && lines[i].Length == 7)
						{
							if (color > THEME_SIZE - 1)
								break;

							try
							{
								Color c = ColorTranslator.FromHtml(lines[i]);
								themes[theme][color] = ColorTranslator.FromHtml(lines[i]);
							}
							catch
							{
								themes[theme][color] = Color.Black;
							}

							color++;
						}
					}
				}
			}
			else
			{
				Directory.CreateDirectory(themesFolder);
			}
		}

		public static void SetTheme(Control mainCtrl)
		{
			currentTheme = themes[Properties.Settings.Default.Theme];

			if (mainCtrl is Form) mainCtrl.BackColor = currentTheme[MAIN_COLOR];

			foreach (Control ctrl in mainCtrl.Controls)
			{
				ctrl.ForeColor = currentTheme[TEXT_COLOR];

				if (ctrl.Name.StartsWith("Title"))
				{
					ctrl.BackColor = currentTheme[TITLE_BAR_COLOR];
					if (ctrl.Name == "TitleBar") ((PictureBox)ctrl.Controls[0]).Image = ColorReplace(Properties.Resources.Cross, currentTheme[X_COLOR]);
					else SetTheme(ctrl);
				}
				else if (ctrl.Name.StartsWith("Line"))
				{
					ctrl.BackColor = currentTheme[TEXT_COLOR];
				}
				else if (ctrl.Name == "AyaPicture")
				{
					ctrl.BackColor = currentTheme[SECONDERY_COLOR];
					((PictureBox)ctrl).Image = ColorReplace(Properties.Resources.AyaImg, currentTheme[AYA_COLOR]);
				}
				else if (ctrl is Button || ctrl is ListView)
				{
					if (ctrl.Name != "DateBtn") ctrl.BackColor = currentTheme[SECONDERY_COLOR];
				}
				else if (ctrl is Panel || ctrl is GroupBox || ctrl.Name == "AyaBack")
				{
					if (!(ctrl is GroupBox)) ctrl.BackColor = currentTheme[SECONDERY_COLOR];

					SetTheme(ctrl);
				}
				else if (ctrl is TextBox || ctrl is ComboBox || ctrl is NumericUpDown)
				{
					ctrl.BackColor = currentTheme[TEXT_BOX_COLOR];
				}
			}
		}

		private static Image ColorReplace(Image inputImage, Color color)
		{
			Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);
			Graphics g = Graphics.FromImage(outputImage);
			g.DrawImage(inputImage, 0, 0);
			for (int y = 0; y < outputImage.Height; y++)
				for (int x = 0; x < outputImage.Width; x++)
				{
					Color PixelColor = outputImage.GetPixel(x, y);
					if (PixelColor.A > 0)
					{
						outputImage.SetPixel(x, y, Color.FromArgb(PixelColor.A, color));
					}
				}

			return outputImage;
		}

		public static void LoadCustomFontToMemory()
		{
			int fontLength = Properties.Resources.Digital.Length;
			byte[] fontdata = Properties.Resources.Digital;
			IntPtr data = Marshal.AllocCoTaskMem(fontLength);
			Marshal.Copy(fontdata, 0, data, fontLength);
			myFont.AddMemoryFont(data, fontLength);
		}
	}
}
