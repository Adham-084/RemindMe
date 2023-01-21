namespace RemindMe
{
	partial class FrmMonth
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.ColDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColFajer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColRise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColNoon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColAser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColSet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColEsha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TitleBar = new System.Windows.Forms.Panel();
			this.CloseBtn = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ColDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.CausesValidation = false;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColDate,
            this.ColDay,
            this.ColFajer,
            this.ColRise,
            this.ColNoon,
            this.ColAser,
            this.ColSet,
            this.ColEsha});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 94);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.RightToLeftLayout = true;
			this.listView1.Scrollable = false;
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(472, 552);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
			// 
			// ColDay
			// 
			this.ColDay.Text = "اليوم";
			this.ColDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColDay.Width = 65;
			// 
			// ColFajer
			// 
			this.ColFajer.Text = "الفجر";
			this.ColFajer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ColRise
			// 
			this.ColRise.Text = "الشروق";
			this.ColRise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ColNoon
			// 
			this.ColNoon.Text = "الظهر";
			this.ColNoon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ColAser
			// 
			this.ColAser.Text = "العصر";
			this.ColAser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ColSet
			// 
			this.ColSet.Text = "المغرب";
			this.ColSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ColEsha
			// 
			this.ColEsha.Text = "العشاء";
			this.ColEsha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TitleBar
			// 
			this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
			this.TitleBar.Controls.Add(this.CloseBtn);
			this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBar.Location = new System.Drawing.Point(0, 0);
			this.TitleBar.Name = "TitleBar";
			this.TitleBar.Size = new System.Drawing.Size(498, 30);
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
			this.CloseBtn.TabIndex = 0;
			this.CloseBtn.TabStop = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 58);
			this.label1.TabIndex = 15;
			this.label1.Text = "مواقيت الصلاة عن شهر 0 لعام 0000";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ColDate
			// 
			this.ColDate.Text = "التاريخ";
			this.ColDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColDate.Width = 47;
			// 
			// FrmMonth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 658);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TitleBar);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmMonth";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ColumnHeader ColDay;
		private System.Windows.Forms.ColumnHeader ColFajer;
		private System.Windows.Forms.ColumnHeader ColRise;
		private System.Windows.Forms.ColumnHeader ColNoon;
		private System.Windows.Forms.ColumnHeader ColAser;
		private System.Windows.Forms.ColumnHeader ColSet;
		private System.Windows.Forms.ColumnHeader ColEsha;
		public System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Panel TitleBar;
		private System.Windows.Forms.PictureBox CloseBtn;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader ColDate;
	}
}