namespace Bad100Challenge {
	partial class Display {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			SongTitlelabel = new Label();
			BadCountlabel = new Label();
			ClearCountlabel = new Label();
			FullComboCountlabel = new Label();
			SuspendLayout();
			// 
			// SongTitlelabel
			// 
			SongTitlelabel.AutoSize = true;
			SongTitlelabel.Font = new Font("UD デジタル 教科書体 N", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
			SongTitlelabel.Location = new Point(13, 9);
			SongTitlelabel.Margin = new Padding(4, 0, 4, 0);
			SongTitlelabel.Name = "SongTitlelabel";
			SongTitlelabel.Size = new Size(90, 34);
			SongTitlelabel.TabIndex = 0;
			SongTitlelabel.Text = "*none";
			SongTitlelabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BadCountlabel
			// 
			BadCountlabel.AutoSize = true;
			BadCountlabel.Font = new Font("M PLUS 1p", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			BadCountlabel.Location = new Point(13, 48);
			BadCountlabel.Name = "BadCountlabel";
			BadCountlabel.Size = new Size(114, 28);
			BadCountlabel.TabIndex = 1;
			BadCountlabel.Text = "(null) left";
			// 
			// ClearCountlabel
			// 
			ClearCountlabel.AutoSize = true;
			ClearCountlabel.Font = new Font("M PLUS 1p", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			ClearCountlabel.Location = new Point(146, 48);
			ClearCountlabel.Margin = new Padding(10, 0, 10, 0);
			ClearCountlabel.Name = "ClearCountlabel";
			ClearCountlabel.Size = new Size(100, 28);
			ClearCountlabel.TabIndex = 2;
			ClearCountlabel.Text = "(null) CL";
			// 
			// FullComboCountlabel
			// 
			FullComboCountlabel.AutoSize = true;
			FullComboCountlabel.Font = new Font("M PLUS 1p", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			FullComboCountlabel.Location = new Point(266, 48);
			FullComboCountlabel.Margin = new Padding(10, 0, 10, 0);
			FullComboCountlabel.Name = "FullComboCountlabel";
			FullComboCountlabel.Size = new Size(100, 28);
			FullComboCountlabel.TabIndex = 3;
			FullComboCountlabel.Text = "(null) FC";
			// 
			// Display
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1264, 81);
			Controls.Add(FullComboCountlabel);
			Controls.Add(ClearCountlabel);
			Controls.Add(BadCountlabel);
			Controls.Add(SongTitlelabel);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "Display";
			Text = "Display";
			VisibleChanged += Display_VisibleChanged;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label SongTitlelabel;
		private Label BadCountlabel;
		private Label ClearCountlabel;
		private Label FullComboCountlabel;
	}
}