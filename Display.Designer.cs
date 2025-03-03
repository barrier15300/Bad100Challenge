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
			SongTitle = new Label();
			BadCountlabel = new Label();
			ClearCountlabel = new Label();
			FullComboCountlabel = new Label();
			TimeDisplay = new Label();
			SongSubTitle = new Label();
			SongDifficulty = new Label();
			SuspendLayout();
			// 
			// SongTitle
			// 
			SongTitle.AutoSize = true;
			SongTitle.Font = new Font("UD デジタル 教科書体 N", 30F, FontStyle.Bold, GraphicsUnit.Pixel);
			SongTitle.Location = new Point(13, 9);
			SongTitle.Margin = new Padding(4, 0, 4, 0);
			SongTitle.Name = "SongTitle";
			SongTitle.Size = new Size(90, 34);
			SongTitle.TabIndex = 0;
			SongTitle.Text = "*none";
			SongTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BadCountlabel
			// 
			BadCountlabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			BadCountlabel.AutoSize = true;
			BadCountlabel.Font = new Font("M PLUS 1p", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			BadCountlabel.Location = new Point(13, 88);
			BadCountlabel.Name = "BadCountlabel";
			BadCountlabel.Size = new Size(114, 28);
			BadCountlabel.TabIndex = 1;
			BadCountlabel.Text = "(null) left";
			// 
			// ClearCountlabel
			// 
			ClearCountlabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			ClearCountlabel.AutoSize = true;
			ClearCountlabel.Font = new Font("M PLUS 1p", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			ClearCountlabel.Location = new Point(146, 88);
			ClearCountlabel.Margin = new Padding(10, 0, 10, 0);
			ClearCountlabel.Name = "ClearCountlabel";
			ClearCountlabel.Size = new Size(100, 28);
			ClearCountlabel.TabIndex = 2;
			ClearCountlabel.Text = "(null) CL";
			// 
			// FullComboCountlabel
			// 
			FullComboCountlabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			FullComboCountlabel.AutoSize = true;
			FullComboCountlabel.Font = new Font("M PLUS 1p", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			FullComboCountlabel.Location = new Point(266, 88);
			FullComboCountlabel.Margin = new Padding(10, 0, 10, 0);
			FullComboCountlabel.Name = "FullComboCountlabel";
			FullComboCountlabel.Size = new Size(100, 28);
			FullComboCountlabel.TabIndex = 3;
			FullComboCountlabel.Text = "(null) FC";
			// 
			// TimeDisplay
			// 
			TimeDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			TimeDisplay.AutoSize = true;
			TimeDisplay.Font = new Font("Courier New", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
			TimeDisplay.Location = new Point(1194, 94);
			TimeDisplay.Name = "TimeDisplay";
			TimeDisplay.Size = new Size(58, 18);
			TimeDisplay.TabIndex = 4;
			TimeDisplay.Text = "*none";
			TimeDisplay.TextAlign = ContentAlignment.MiddleRight;
			TimeDisplay.Resize += TimeDisplay_Resize;
			// 
			// SongSubTitle
			// 
			SongSubTitle.AutoSize = true;
			SongSubTitle.Font = new Font("UD デジタル 教科書体 N", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			SongSubTitle.Location = new Point(13, 43);
			SongSubTitle.Margin = new Padding(4, 0, 4, 0);
			SongSubTitle.Name = "SongSubTitle";
			SongSubTitle.Size = new Size(60, 24);
			SongSubTitle.TabIndex = 5;
			SongSubTitle.Text = "*none";
			SongSubTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// SongDifficulty
			// 
			SongDifficulty.AutoSize = true;
			SongDifficulty.Font = new Font("UD デジタル 教科書体 N", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			SongDifficulty.Location = new Point(13, 64);
			SongDifficulty.Margin = new Padding(4, 0, 4, 0);
			SongDifficulty.Name = "SongDifficulty";
			SongDifficulty.Size = new Size(60, 24);
			SongDifficulty.TabIndex = 6;
			SongDifficulty.Text = "*none";
			SongDifficulty.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Display
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1264, 121);
			Controls.Add(SongDifficulty);
			Controls.Add(SongSubTitle);
			Controls.Add(TimeDisplay);
			Controls.Add(FullComboCountlabel);
			Controls.Add(ClearCountlabel);
			Controls.Add(BadCountlabel);
			Controls.Add(SongTitle);
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

		private Label SongTitle;
		private Label BadCountlabel;
		private Label ClearCountlabel;
		private Label FullComboCountlabel;
		private Label TimeDisplay;
		private Label SongSubTitle;
		private Label SongDifficulty;
	}
}