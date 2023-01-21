namespace RemindMe
{
	partial class FrmOptions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptions));
			this.LongText = new System.Windows.Forms.TextBox();
			this.LatText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.AlarmTimeUpDown = new System.Windows.Forms.NumericUpDown();
			this.TitleBar = new System.Windows.Forms.Panel();
			this.CloseBtn = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.TrayChk = new System.Windows.Forms.CheckBox();
			this.AlarmChk = new System.Windows.Forms.CheckBox();
			this.AthanChk = new System.Windows.Forms.CheckBox();
			this.StartupChk = new System.Windows.Forms.CheckBox();
			this.ThemeList = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.MethodList = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.FormatList = new System.Windows.Forms.ComboBox();
			this.GetLocationBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.LocationLabel = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.AlarmTimeUpDown)).BeginInit();
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// LongText
			// 
			this.LongText.BackColor = System.Drawing.Color.White;
			this.LongText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LongText.Font = new System.Drawing.Font("Tahoma", 8F);
			this.LongText.ForeColor = System.Drawing.Color.Black;
			this.LongText.Location = new System.Drawing.Point(22, 29);
			this.LongText.MaxLength = 8;
			this.LongText.Name = "LongText";
			this.LongText.ReadOnly = true;
			this.LongText.Size = new System.Drawing.Size(110, 20);
			this.LongText.TabIndex = 0;
			// 
			// LatText
			// 
			this.LatText.BackColor = System.Drawing.Color.White;
			this.LatText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LatText.Font = new System.Drawing.Font("Tahoma", 8F);
			this.LatText.ForeColor = System.Drawing.Color.Black;
			this.LatText.Location = new System.Drawing.Point(22, 55);
			this.LatText.MaxLength = 8;
			this.LatText.Name = "LatText";
			this.LatText.ReadOnly = true;
			this.LatText.Size = new System.Drawing.Size(110, 20);
			this.LatText.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(142, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "خط الطول";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(133, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "دائرة العرض";
			// 
			// SaveBtn
			// 
			this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaveBtn.ForeColor = System.Drawing.Color.Black;
			this.SaveBtn.Location = new System.Drawing.Point(226, 299);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(212, 26);
			this.SaveBtn.TabIndex = 3;
			this.SaveBtn.Text = "حفظ";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelBtn.ForeColor = System.Drawing.Color.Black;
			this.CancelBtn.Location = new System.Drawing.Point(334, 331);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(102, 26);
			this.CancelBtn.TabIndex = 4;
			this.CancelBtn.Text = "إلغاء";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// AlarmTimeUpDown
			// 
			this.AlarmTimeUpDown.BackColor = System.Drawing.Color.White;
			this.AlarmTimeUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AlarmTimeUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AlarmTimeUpDown.ForeColor = System.Drawing.Color.Black;
			this.AlarmTimeUpDown.Location = new System.Drawing.Point(142, 50);
			this.AlarmTimeUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.AlarmTimeUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.AlarmTimeUpDown.Name = "AlarmTimeUpDown";
			this.AlarmTimeUpDown.Size = new System.Drawing.Size(35, 21);
			this.AlarmTimeUpDown.TabIndex = 1;
			this.AlarmTimeUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
			this.TitleBar.Controls.Add(this.CloseBtn);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(453, 30);
			this.TitleBar.TabIndex = 14;
			this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseDown);
			this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseMove);
			this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseUp);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Image = global::RemindMe.Properties.Resources.Cross;
			this.CloseBtn.Location = new System.Drawing.Point(0, 0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(30, 30);
			this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.TabStop = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(107, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(28, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "دقائق";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(226, 331);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(102, 26);
			this.button3.TabIndex = 5;
			this.button3.Text = "نبذة";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// TrayChk
			// 
			this.TrayChk.AutoSize = true;
			this.TrayChk.Checked = true;
			this.TrayChk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.TrayChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TrayChk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrayChk.ForeColor = System.Drawing.Color.Black;
			this.TrayChk.Location = new System.Drawing.Point(80, 99);
			this.TrayChk.Name = "TrayChk";
			this.TrayChk.Size = new System.Drawing.Size(112, 20);
			this.TrayChk.TabIndex = 3;
			this.TrayChk.Text = "تصغير بجوار الساعة";
			this.TrayChk.UseVisualStyleBackColor = true;
			// 
			// AlarmChk
			// 
			this.AlarmChk.AutoSize = true;
			this.AlarmChk.Checked = true;
			this.AlarmChk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AlarmChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AlarmChk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AlarmChk.ForeColor = System.Drawing.Color.Black;
			this.AlarmChk.Location = new System.Drawing.Point(97, 25);
			this.AlarmChk.Name = "AlarmChk";
			this.AlarmChk.Size = new System.Drawing.Size(95, 20);
			this.AlarmChk.TabIndex = 0;
			this.AlarmChk.Text = "تنبيه قبل الأذان بـ";
			this.AlarmChk.UseVisualStyleBackColor = true;
			this.AlarmChk.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// AthanChk
			// 
			this.AthanChk.AutoSize = true;
			this.AthanChk.Checked = true;
			this.AthanChk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AthanChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AthanChk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AthanChk.ForeColor = System.Drawing.Color.Black;
			this.AthanChk.Location = new System.Drawing.Point(86, 77);
			this.AthanChk.Name = "AthanChk";
			this.AthanChk.Size = new System.Drawing.Size(106, 20);
			this.AthanChk.TabIndex = 2;
			this.AthanChk.Text = "تشغيل صوت الأذان";
			this.AthanChk.UseVisualStyleBackColor = true;
			// 
			// StartupChk
			// 
			this.StartupChk.AutoSize = true;
			this.StartupChk.Checked = true;
			this.StartupChk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StartupChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartupChk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartupChk.ForeColor = System.Drawing.Color.Black;
			this.StartupChk.Location = new System.Drawing.Point(114, 122);
			this.StartupChk.Name = "StartupChk";
			this.StartupChk.Size = new System.Drawing.Size(78, 20);
			this.StartupChk.TabIndex = 4;
			this.StartupChk.Text = "بدء مع النظام";
			this.StartupChk.UseVisualStyleBackColor = true;
			// 
			// ThemeList
			// 
			this.ThemeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ThemeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ThemeList.Font = new System.Drawing.Font("Tahoma", 8F);
			this.ThemeList.ForeColor = System.Drawing.Color.Black;
			this.ThemeList.FormattingEnabled = true;
			this.ThemeList.Location = new System.Drawing.Point(27, 50);
			this.ThemeList.Name = "ThemeList";
			this.ThemeList.Size = new System.Drawing.Size(175, 21);
			this.ThemeList.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(167, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "المظهر";
			// 
			// MethodList
			// 
			this.MethodList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MethodList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.MethodList.Font = new System.Drawing.Font("Tahoma", 8F);
			this.MethodList.ForeColor = System.Drawing.Color.Black;
			this.MethodList.FormattingEnabled = true;
			this.MethodList.Items.AddRange(new object[] {
            "الهيئة المصرية العامة للمساحة",
            "أم القرى مكة",
            "الجمعية الإسلامية لأمريكا الشمالية",
            "رابطة العالم الإسلامي",
            "جامعة العلوم الإسلامية بكراتشي"});
			this.MethodList.Location = new System.Drawing.Point(27, 150);
			this.MethodList.Name = "MethodList";
			this.MethodList.Size = new System.Drawing.Size(175, 21);
			this.MethodList.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(136, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 24;
			this.label5.Text = "طريقة الحساب";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(145, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 16);
			this.label6.TabIndex = 26;
			this.label6.Text = "صيغة الوقت";
			// 
			// FormatList
			// 
			this.FormatList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FormatList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.FormatList.Font = new System.Drawing.Font("Tahoma", 8F);
			this.FormatList.ForeColor = System.Drawing.Color.Black;
			this.FormatList.FormattingEnabled = true;
			this.FormatList.Items.AddRange(new object[] {
            "24 ساعة",
            "12 ساعة"});
			this.FormatList.Location = new System.Drawing.Point(27, 100);
			this.FormatList.Name = "FormatList";
			this.FormatList.Size = new System.Drawing.Size(175, 21);
			this.FormatList.TabIndex = 1;
			// 
			// GetLocationBtn
			// 
			this.GetLocationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GetLocationBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GetLocationBtn.ForeColor = System.Drawing.Color.Black;
			this.GetLocationBtn.Location = new System.Drawing.Point(22, 81);
			this.GetLocationBtn.Name = "GetLocationBtn";
			this.GetLocationBtn.Size = new System.Drawing.Size(167, 28);
			this.GetLocationBtn.TabIndex = 2;
			this.GetLocationBtn.Text = "تحديد الموقع من الانترنت";
			this.GetLocationBtn.UseVisualStyleBackColor = true;
			this.GetLocationBtn.Click += new System.EventHandler(this.GetLocationBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.LocationLabel);
			this.groupBox1.Controls.Add(this.LongText);
			this.groupBox1.Controls.Add(this.LatText);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.GetLocationBtn);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(17, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(199, 158);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "الموقع";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(19, 118);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(51, 14);
			this.label8.TabIndex = 30;
			this.label8.Text = "Location:";
			// 
			// LocationLabel
			// 
			this.LocationLabel.AutoSize = true;
			this.LocationLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LocationLabel.Location = new System.Drawing.Point(22, 132);
			this.LocationLabel.Name = "LocationLabel";
			this.LocationLabel.Size = new System.Drawing.Size(11, 14);
			this.LocationLabel.TabIndex = 29;
			this.LocationLabel.Text = "-";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.MethodList);
			this.groupBox2.Controls.Add(this.ThemeList);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.FormatList);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(226, 39);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox2.Size = new System.Drawing.Size(212, 190);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "الواجهة";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.AlarmTimeUpDown);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.TrayChk);
			this.groupBox3.Controls.Add(this.AlarmChk);
			this.groupBox3.Controls.Add(this.StartupChk);
			this.groupBox3.Controls.Add(this.AthanChk);
			this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(17, 39);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox3.Size = new System.Drawing.Size(199, 155);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "عام";
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Theme files|*.ptf";
			this.openFileDialog.Title = "حدد ملف المظهر";
			// 
			// FrmOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(453, 378);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.TitleBar);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.SaveBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmOptions";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.AlarmTimeUpDown)).EndInit();
			this.TitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox LongText;
		private System.Windows.Forms.TextBox LatText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.NumericUpDown AlarmTimeUpDown;
		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox TrayChk;
		private System.Windows.Forms.CheckBox AlarmChk;
		private System.Windows.Forms.CheckBox AthanChk;
		private System.Windows.Forms.ComboBox ThemeList;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox MethodList;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox FormatList;
		private System.Windows.Forms.Button GetLocationBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label LocationLabel;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.CheckBox StartupChk;
        private System.Windows.Forms.PictureBox CloseBtn;
	}
}
