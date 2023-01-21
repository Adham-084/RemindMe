using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RemindMe
{
	public partial class FrmThemeMaker : Form
	{
		#region Fields

		Color[] colors;
		string currentPath;
		int currentColor;
		bool userChange = true;

		#endregion

		public FrmThemeMaker()
		{
			InitializeComponent();
			Initialize();
		}

		#region Events

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (currentPath == "")
				SaveTheme(ThemeManager.themesFolder + '\\' + NameText.Text + ".ptf");
			else
				SaveTheme(currentPath);
		}

		private void ButtonSaveAs_Click(object sender, EventArgs e)
		{
			SaveThemeDialog.FileName = NameText.Text;
			SaveThemeDialog.InitialDirectory = ThemeManager.themesFolder;
			if (SaveThemeDialog.ShowDialog() != DialogResult.Cancel)
				SaveTheme(SaveThemeDialog.FileName);
		}

		private void ColorsList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ChangeColor(ColorsList.SelectedIndex);
		}

		private void ColorChanged(object sender, EventArgs e)
		{
			if (userChange)
			{
				colors[currentColor] = Color.FromArgb((int)RedText.Value, (int)GreenText.Value, (int)BlueText.Value);
				ColorPreview.BackColor = colors[currentColor];
				ButtonSave.Enabled = true;
			}
		}

		private void ButtonNew_Click(object sender, EventArgs e)
		{
			Initialize();
		}

		private void ButtonOpen_Click(object sender, EventArgs e)
		{
			OpenThemeDialog.InitialDirectory = ThemeManager.themesFolder;
			if (OpenThemeDialog.ShowDialog() == DialogResult.Cancel) return;
			NameText.Text = OpenThemeDialog.FileName.Substring(OpenThemeDialog.FileName.LastIndexOf("\\") + 1).Replace(".ptf", "");
			string text = File.ReadAllText(OpenThemeDialog.FileName);
			string[] lines = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			Initialize();
			
			for (int i = 0; i < lines.Length; i++)
			{
				if (lines[i].StartsWith("#"))
				{
					try
					{
						colors[i] = ColorTranslator.FromHtml(lines[i]);
					}
					catch
					{
						colors[i] = Color.White;
					}
				}
			}

			ChangeColor(currentColor);
			currentPath = OpenThemeDialog.FileName;
			ButtonSave.Enabled = false;
		}

		private void ButtonColor_Click(object sender, EventArgs e)
		{
			if (ColorPanel.ShowDialog() == DialogResult.Cancel) return;

			colors[currentColor] = ColorPanel.Color;
			ChangeColor(ColorPanel.Color);
		}

		#endregion

		#region Methods

		void Initialize()
		{
			colors = new Color[] {
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
			};

			
			currentPath = "";
			NameText.Text = "New Theme";
			ChangeColor(0);
			ColorsList.SelectedIndex = 0;
			ButtonSave.Enabled = false;
		}

		void ChangeColor(int color)
		{
			currentColor = color;
			ColorPreview.BackColor = colors[color];
			userChange = false;
			RedText.Value = colors[color].R;
			GreenText.Value = colors[color].G;
			BlueText.Value = colors[color].B;
			userChange = true;
		}

		void ChangeColor(Color color)
		{
			ColorPreview.BackColor = color;
			userChange = false;
			RedText.Value = color.R;
			GreenText.Value = color.G;
			BlueText.Value = color.B;
			userChange = true;
		}

		void SaveTheme(string path)
		{
			string fileText = "";

			foreach (Color color in colors)
			{
				fileText += "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + Environment.NewLine;
			}

			File.WriteAllText(path, fileText);

			ButtonSave.Enabled = false;
		}

		#endregion

		private void FormThemeMaker_FormClosing(object sender, FormClosingEventArgs e)
		{
			ThemeManager.LoadThemes();
		}
	}
}
