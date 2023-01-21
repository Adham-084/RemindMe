namespace RemindMe
{
	partial class FrmSetup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
			this.DesktopChk = new System.Windows.Forms.CheckBox();
			this.StartupChk = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// DesktopChk
			// 
			this.DesktopChk.AutoSize = true;
			this.DesktopChk.Checked = true;
			this.DesktopChk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.DesktopChk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DesktopChk.ForeColor = System.Drawing.Color.Black;
			this.DesktopChk.Location = new System.Drawing.Point(12, 204);
			this.DesktopChk.Name = "DesktopChk";
			this.DesktopChk.Size = new System.Drawing.Size(165, 20);
			this.DesktopChk.TabIndex = 0;
			this.DesktopChk.Text = "إنشاء اختصار على سطح المكتب";
			this.DesktopChk.UseVisualStyleBackColor = true;
			// 
			// StartupChk
			// 
			this.StartupChk.AutoSize = true;
			this.StartupChk.Checked = true;
			this.StartupChk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.StartupChk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartupChk.ForeColor = System.Drawing.Color.Black;
			this.StartupChk.Location = new System.Drawing.Point(12, 234);
			this.StartupChk.Name = "StartupChk";
			this.StartupChk.Size = new System.Drawing.Size(114, 20);
			this.StartupChk.TabIndex = 1;
			this.StartupChk.Text = "تشغيل عند بدء النظام";
			this.StartupChk.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::RemindMe.Properties.Resources.Prayers_Times;
			this.pictureBox1.Location = new System.Drawing.Point(28, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseUp);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 47);
			this.label1.TabIndex = 4;
			this.label1.Text = "مرحباً بك في\r\nبرنامج ذكرني بصلاتي";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseMove);
			this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(FormHandle.MoveBar_MouseUp);
			// 
			// ButtonStart
			// 
			this.ButtonStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonStart.ForeColor = System.Drawing.Color.Black;
			this.ButtonStart.Location = new System.Drawing.Point(12, 276);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(160, 36);
			this.ButtonStart.TabIndex = 7;
			this.ButtonStart.Text = "بدء";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// FrmSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(184, 324);
			this.ControlBox = false;
			this.Controls.Add(this.ButtonStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.StartupChk);
			this.Controls.Add(this.DesktopChk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FrmSetup";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox DesktopChk;
		private System.Windows.Forms.CheckBox StartupChk;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonStart;
	}
}