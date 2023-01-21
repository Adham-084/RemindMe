namespace RemindMe
{
	partial class FrmNotification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotification));
			this.TitlePicture = new System.Windows.Forms.PictureBox();
			this.CaptionLbl = new System.Windows.Forms.Label();
			this.Time = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ColorBar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorBar)).BeginInit();
			this.SuspendLayout();
			// 
			// TitlePicture
			// 
			this.TitlePicture.BackColor = System.Drawing.Color.Transparent;
			this.TitlePicture.Image = ((System.Drawing.Image)(resources.GetObject("TitlePicture.Image")));
			this.TitlePicture.Location = new System.Drawing.Point(-1, 0);
			this.TitlePicture.Name = "TitlePicture";
			this.TitlePicture.Size = new System.Drawing.Size(119, 120);
			this.TitlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.TitlePicture.TabIndex = 0;
			this.TitlePicture.TabStop = false;
			this.TitlePicture.Click += new System.EventHandler(this.FormNotification_Clicked);
			// 
			// CaptionLbl
			// 
			this.CaptionLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CaptionLbl.ForeColor = System.Drawing.Color.Black;
			this.CaptionLbl.Location = new System.Drawing.Point(124, 0);
			this.CaptionLbl.Name = "CaptionLbl";
			this.CaptionLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CaptionLbl.Size = new System.Drawing.Size(256, 59);
			this.CaptionLbl.TabIndex = 1;
			this.CaptionLbl.Text = " باقي من الوقت 10 دقائق حتى أذان العصر";
			this.CaptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CaptionLbl.Click += new System.EventHandler(this.FormNotification_Clicked);
			// 
			// Time
			// 
			this.Time.ForeColor = System.Drawing.Color.Black;
			this.Time.Location = new System.Drawing.Point(131, 68);
			this.Time.Name = "Time";
			this.Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Time.Size = new System.Drawing.Size(217, 31);
			this.Time.TabIndex = 2;
			this.Time.Text = "00:00";
			this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Time.UseCompatibleTextRendering = true;
			this.Time.Click += new System.EventHandler(this.FormNotification_Clicked);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(298, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "اضغط للإيقاف";
			this.label1.Click += new System.EventHandler(this.FormNotification_Clicked);
			// 
			// ColorBar
			// 
			this.ColorBar.BackColor = System.Drawing.Color.Red;
			this.ColorBar.Dock = System.Windows.Forms.DockStyle.Right;
			this.ColorBar.Location = new System.Drawing.Point(373, 0);
			this.ColorBar.Name = "ColorBar";
			this.ColorBar.Size = new System.Drawing.Size(10, 120);
			this.ColorBar.TabIndex = 0;
			this.ColorBar.TabStop = false;
			// 
			// FormNotification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(383, 120);
			this.Controls.Add(this.ColorBar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Time);
			this.Controls.Add(this.TitlePicture);
			this.Controls.Add(this.CaptionLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormNotification";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Athan";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormNotification_Load);
			this.Click += new System.EventHandler(this.FormNotification_Clicked);
			((System.ComponentModel.ISupportInitialize)(this.TitlePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ColorBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox TitlePicture;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label CaptionLbl;
		public System.Windows.Forms.Label Time;
		public System.Windows.Forms.PictureBox ColorBar;
	}
}
