namespace RemindMe
{
	partial class FrmThemeMaker
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemeMaker));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ColorsList = new System.Windows.Forms.ListBox();
			this.RedText = new System.Windows.Forms.NumericUpDown();
			this.BlueText = new System.Windows.Forms.NumericUpDown();
			this.GreenText = new System.Windows.Forms.NumericUpDown();
			this.NameText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ButtonOpen = new System.Windows.Forms.Button();
			this.ButtonSaveAs = new System.Windows.Forms.Button();
			this.OpenThemeDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveThemeDialog = new System.Windows.Forms.SaveFileDialog();
			this.ColorPreview = new System.Windows.Forms.PictureBox();
			this.ButtonNew = new System.Windows.Forms.Button();
			this.RGBGroup = new System.Windows.Forms.GroupBox();
			this.ButtonColor = new System.Windows.Forms.Button();
			this.ColorPanel = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.RedText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenText)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).BeginInit();
			this.RGBGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Blue:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Green:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Red:";
			// 
			// ColorsList
			// 
			this.ColorsList.FormattingEnabled = true;
			this.ColorsList.Items.AddRange(new object[] {
            "Main Color",
            "Secondary Color",
            "Title Bar Color",
            "Text Box Color",
            "Text Color",
            "Selected Text Color",
            "Aya Color",
            "Alarm Color",
            "Athan Color",
            "X Close Color"});
			this.ColorsList.Location = new System.Drawing.Point(12, 187);
			this.ColorsList.Name = "ColorsList";
			this.ColorsList.Size = new System.Drawing.Size(156, 134);
			this.ColorsList.TabIndex = 12;
			this.ColorsList.SelectedIndexChanged += new System.EventHandler(this.ColorsList_SelectedIndexChanged);
			// 
			// RedText
			// 
			this.RedText.Location = new System.Drawing.Point(52, 19);
			this.RedText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.RedText.Name = "RedText";
			this.RedText.Size = new System.Drawing.Size(50, 20);
			this.RedText.TabIndex = 13;
			this.RedText.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.RedText.ValueChanged += new System.EventHandler(this.ColorChanged);
			// 
			// BlueText
			// 
			this.BlueText.Location = new System.Drawing.Point(52, 71);
			this.BlueText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.BlueText.Name = "BlueText";
			this.BlueText.Size = new System.Drawing.Size(50, 20);
			this.BlueText.TabIndex = 14;
			this.BlueText.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.BlueText.ValueChanged += new System.EventHandler(this.ColorChanged);
			// 
			// GreenText
			// 
			this.GreenText.Location = new System.Drawing.Point(52, 45);
			this.GreenText.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.GreenText.Name = "GreenText";
			this.GreenText.Size = new System.Drawing.Size(50, 20);
			this.GreenText.TabIndex = 15;
			this.GreenText.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.GreenText.ValueChanged += new System.EventHandler(this.ColorChanged);
			// 
			// NameText
			// 
			this.NameText.Location = new System.Drawing.Point(12, 25);
			this.NameText.MaxLength = 32;
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(156, 20);
			this.NameText.TabIndex = 16;
			this.NameText.Text = "New Theme";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Theme Name:";
			// 
			// ButtonSave
			// 
			this.ButtonSave.Location = new System.Drawing.Point(12, 327);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(75, 23);
			this.ButtonSave.TabIndex = 18;
			this.ButtonSave.Text = "Save";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// ButtonOpen
			// 
			this.ButtonOpen.Location = new System.Drawing.Point(93, 356);
			this.ButtonOpen.Name = "ButtonOpen";
			this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
			this.ButtonOpen.TabIndex = 19;
			this.ButtonOpen.Text = "Open";
			this.ButtonOpen.UseVisualStyleBackColor = true;
			this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
			// 
			// ButtonSaveAs
			// 
			this.ButtonSaveAs.Location = new System.Drawing.Point(93, 327);
			this.ButtonSaveAs.Name = "ButtonSaveAs";
			this.ButtonSaveAs.Size = new System.Drawing.Size(75, 23);
			this.ButtonSaveAs.TabIndex = 20;
			this.ButtonSaveAs.Text = "Save As";
			this.ButtonSaveAs.UseVisualStyleBackColor = true;
			this.ButtonSaveAs.Click += new System.EventHandler(this.ButtonSaveAs_Click);
			// 
			// OpenThemeDialog
			// 
			this.OpenThemeDialog.Filter = "Theme files|*.ptf";
			this.OpenThemeDialog.Title = "Open Theme File";
			// 
			// SaveThemeDialog
			// 
			this.SaveThemeDialog.DefaultExt = "ptf";
			this.SaveThemeDialog.Filter = "Theme files|*.ptf";
			this.SaveThemeDialog.Title = "Save Theme As";
			// 
			// ColorPreview
			// 
			this.ColorPreview.BackColor = System.Drawing.Color.White;
			this.ColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ColorPreview.Location = new System.Drawing.Point(132, 58);
			this.ColorPreview.Name = "ColorPreview";
			this.ColorPreview.Size = new System.Drawing.Size(36, 123);
			this.ColorPreview.TabIndex = 0;
			this.ColorPreview.TabStop = false;
			// 
			// ButtonNew
			// 
			this.ButtonNew.Location = new System.Drawing.Point(12, 356);
			this.ButtonNew.Name = "ButtonNew";
			this.ButtonNew.Size = new System.Drawing.Size(75, 23);
			this.ButtonNew.TabIndex = 21;
			this.ButtonNew.Text = "New";
			this.ButtonNew.UseVisualStyleBackColor = true;
			this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
			// 
			// RGBGroup
			// 
			this.RGBGroup.Controls.Add(this.ButtonColor);
			this.RGBGroup.Controls.Add(this.RedText);
			this.RGBGroup.Controls.Add(this.label1);
			this.RGBGroup.Controls.Add(this.label2);
			this.RGBGroup.Controls.Add(this.label3);
			this.RGBGroup.Controls.Add(this.BlueText);
			this.RGBGroup.Controls.Add(this.GreenText);
			this.RGBGroup.Location = new System.Drawing.Point(12, 51);
			this.RGBGroup.Name = "RGBGroup";
			this.RGBGroup.Size = new System.Drawing.Size(114, 130);
			this.RGBGroup.TabIndex = 22;
			this.RGBGroup.TabStop = false;
			this.RGBGroup.Text = "Color";
			// 
			// ButtonColor
			// 
			this.ButtonColor.Location = new System.Drawing.Point(9, 97);
			this.ButtonColor.Name = "ButtonColor";
			this.ButtonColor.Size = new System.Drawing.Size(93, 23);
			this.ButtonColor.TabIndex = 24;
			this.ButtonColor.Text = "Color Panel";
			this.ButtonColor.UseVisualStyleBackColor = true;
			this.ButtonColor.Click += new System.EventHandler(this.ButtonColor_Click);
			// 
			// ColorPanel
			// 
			this.ColorPanel.Color = System.Drawing.Color.White;
			this.ColorPanel.FullOpen = true;
			// 
			// FormThemeMaker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(180, 391);
			this.Controls.Add(this.ButtonNew);
			this.Controls.Add(this.ButtonSaveAs);
			this.Controls.Add(this.ButtonOpen);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NameText);
			this.Controls.Add(this.ColorsList);
			this.Controls.Add(this.RGBGroup);
			this.Controls.Add(this.ColorPreview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormThemeMaker";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Prayer Times Theme Maker";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThemeMaker_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.RedText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenText)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).EndInit();
			this.RGBGroup.ResumeLayout(false);
			this.RGBGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox ColorPreview;
		private System.Windows.Forms.ListBox ColorsList;
		private System.Windows.Forms.NumericUpDown RedText;
		private System.Windows.Forms.NumericUpDown BlueText;
		private System.Windows.Forms.NumericUpDown GreenText;
		private System.Windows.Forms.TextBox NameText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Button ButtonOpen;
		private System.Windows.Forms.Button ButtonSaveAs;
		private System.Windows.Forms.OpenFileDialog OpenThemeDialog;
		private System.Windows.Forms.SaveFileDialog SaveThemeDialog;
		private System.Windows.Forms.Button ButtonNew;
		private System.Windows.Forms.GroupBox RGBGroup;
		private System.Windows.Forms.Button ButtonColor;
		private System.Windows.Forms.ColorDialog ColorPanel;
	}
}

