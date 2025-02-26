namespace Bad100Challenge
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			RollStartButton = new Button();
			SongListInput = new TextBox();
			SongListlabel = new Label();
			BadCountInput = new NumericUpDown();
			BadCountlabel = new Label();
			InitialCountlabel = new Label();
			InitialCountInput = new NumericUpDown();
			FixButton = new Button();
			SongCountlabel = new Label();
			SongCountDisplay = new TextBox();
			UpdateTimelabel = new Label();
			UpdateTimeInput = new NumericUpDown();
			MarathonModeFlag = new CheckBox();
			FixRequiredBox = new GroupBox();
			CalculateButton = new Button();
			CalculateBox = new GroupBox();
			SongIgnoreCountlabel = new Label();
			SongIgnoreCountInput = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)BadCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)InitialCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)UpdateTimeInput).BeginInit();
			FixRequiredBox.SuspendLayout();
			CalculateBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SongIgnoreCountInput).BeginInit();
			SuspendLayout();
			// 
			// RollStartButton
			// 
			RollStartButton.Location = new Point(353, 147);
			RollStartButton.Margin = new Padding(5);
			RollStartButton.Name = "RollStartButton";
			RollStartButton.Size = new Size(174, 45);
			RollStartButton.TabIndex = 0;
			RollStartButton.Text = "Roll Start";
			RollStartButton.UseVisualStyleBackColor = true;
			RollStartButton.Click += RollStartButton_Click;
			RollStartButton.MouseEnter += FocusInRollStartButton;
			RollStartButton.MouseLeave += FocusOutRollStartButton;
			// 
			// SongListInput
			// 
			SongListInput.AllowDrop = true;
			SongListInput.Location = new Point(6, 39);
			SongListInput.Multiline = true;
			SongListInput.Name = "SongListInput";
			SongListInput.ScrollBars = ScrollBars.Both;
			SongListInput.Size = new Size(167, 439);
			SongListInput.TabIndex = 1;
			SongListInput.WordWrap = false;
			SongListInput.TextChanged += InputSongList;
			SongListInput.DragDrop += SongListInput_DragDrop;
			SongListInput.DragEnter += SongListInput_DragEnter;
			// 
			// SongListlabel
			// 
			SongListlabel.AutoSize = true;
			SongListlabel.Location = new Point(6, 21);
			SongListlabel.Name = "SongListlabel";
			SongListlabel.Size = new Size(52, 15);
			SongListlabel.TabIndex = 2;
			SongListlabel.Text = "SongList";
			// 
			// BadCountInput
			// 
			BadCountInput.Location = new Point(8, 39);
			BadCountInput.Margin = new Padding(5, 20, 5, 10);
			BadCountInput.Maximum = new decimal(new int[] { 32768, 0, 0, 0 });
			BadCountInput.Name = "BadCountInput";
			BadCountInput.Size = new Size(120, 23);
			BadCountInput.TabIndex = 3;
			BadCountInput.Tag = "";
			// 
			// BadCountlabel
			// 
			BadCountlabel.AutoSize = true;
			BadCountlabel.Location = new Point(8, 20);
			BadCountlabel.Margin = new Padding(0);
			BadCountlabel.Name = "BadCountlabel";
			BadCountlabel.Size = new Size(59, 15);
			BadCountlabel.TabIndex = 4;
			BadCountlabel.Text = "BadCount";
			// 
			// InitialCountlabel
			// 
			InitialCountlabel.AutoSize = true;
			InitialCountlabel.Location = new Point(179, 20);
			InitialCountlabel.Name = "InitialCountlabel";
			InitialCountlabel.Size = new Size(68, 15);
			InitialCountlabel.TabIndex = 5;
			InitialCountlabel.Text = "InitialCount";
			// 
			// InitialCountInput
			// 
			InitialCountInput.Location = new Point(179, 39);
			InitialCountInput.Margin = new Padding(3, 20, 3, 20);
			InitialCountInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			InitialCountInput.Name = "InitialCountInput";
			InitialCountInput.Size = new Size(120, 23);
			InitialCountInput.TabIndex = 6;
			InitialCountInput.Tag = "";
			InitialCountInput.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// FixButton
			// 
			FixButton.Enabled = false;
			FixButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
			FixButton.Location = new Point(179, 474);
			FixButton.Name = "FixButton";
			FixButton.Size = new Size(148, 48);
			FixButton.TabIndex = 7;
			FixButton.Text = "Fix";
			FixButton.UseVisualStyleBackColor = true;
			FixButton.Click += FixButtonEnter;
			// 
			// SongCountlabel
			// 
			SongCountlabel.AutoSize = true;
			SongCountlabel.Location = new Point(6, 481);
			SongCountlabel.Name = "SongCountlabel";
			SongCountlabel.Size = new Size(66, 15);
			SongCountlabel.TabIndex = 8;
			SongCountlabel.Text = "SongCount";
			// 
			// SongCountDisplay
			// 
			SongCountDisplay.Location = new Point(6, 499);
			SongCountDisplay.Name = "SongCountDisplay";
			SongCountDisplay.ReadOnly = true;
			SongCountDisplay.Size = new Size(167, 23);
			SongCountDisplay.TabIndex = 9;
			// 
			// UpdateTimelabel
			// 
			UpdateTimelabel.AutoSize = true;
			UpdateTimelabel.Location = new Point(353, 198);
			UpdateTimelabel.Margin = new Padding(0);
			UpdateTimelabel.Name = "UpdateTimelabel";
			UpdateTimelabel.Size = new Size(70, 15);
			UpdateTimelabel.TabIndex = 11;
			UpdateTimelabel.Text = "UpdateTime";
			// 
			// UpdateTimeInput
			// 
			UpdateTimeInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			UpdateTimeInput.Location = new Point(353, 217);
			UpdateTimeInput.Margin = new Padding(5, 20, 5, 20);
			UpdateTimeInput.Maximum = new decimal(new int[] { 1600, 0, 0, 0 });
			UpdateTimeInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			UpdateTimeInput.Name = "UpdateTimeInput";
			UpdateTimeInput.Size = new Size(120, 23);
			UpdateTimeInput.TabIndex = 10;
			UpdateTimeInput.Tag = "";
			UpdateTimeInput.Value = new decimal(new int[] { 50, 0, 0, 0 });
			// 
			// MarathonModeFlag
			// 
			MarathonModeFlag.AutoSize = true;
			MarathonModeFlag.Location = new Point(179, 449);
			MarathonModeFlag.Name = "MarathonModeFlag";
			MarathonModeFlag.Size = new Size(112, 19);
			MarathonModeFlag.TabIndex = 12;
			MarathonModeFlag.Text = "Marathon Mode";
			MarathonModeFlag.UseVisualStyleBackColor = true;
			MarathonModeFlag.CheckedChanged += MarathonModeFlag_CheckedChanged;
			// 
			// FixRequiredBox
			// 
			FixRequiredBox.Controls.Add(MarathonModeFlag);
			FixRequiredBox.Controls.Add(InitialCountInput);
			FixRequiredBox.Controls.Add(InitialCountlabel);
			FixRequiredBox.Controls.Add(SongCountDisplay);
			FixRequiredBox.Controls.Add(SongCountlabel);
			FixRequiredBox.Controls.Add(FixButton);
			FixRequiredBox.Controls.Add(SongListInput);
			FixRequiredBox.Controls.Add(SongListlabel);
			FixRequiredBox.Location = new Point(12, 12);
			FixRequiredBox.Name = "FixRequiredBox";
			FixRequiredBox.Size = new Size(333, 528);
			FixRequiredBox.TabIndex = 13;
			FixRequiredBox.TabStop = false;
			FixRequiredBox.Text = "FixReqired";
			// 
			// CalculateButton
			// 
			CalculateButton.Location = new Point(8, 74);
			CalculateButton.Margin = new Padding(5);
			CalculateButton.Name = "CalculateButton";
			CalculateButton.Size = new Size(158, 45);
			CalculateButton.TabIndex = 14;
			CalculateButton.Text = "Calculate";
			CalculateButton.UseVisualStyleBackColor = true;
			CalculateButton.Click += CalculateButton_Click;
			// 
			// CalculateBox
			// 
			CalculateBox.Controls.Add(CalculateButton);
			CalculateBox.Controls.Add(BadCountInput);
			CalculateBox.Controls.Add(BadCountlabel);
			CalculateBox.Enabled = false;
			CalculateBox.Location = new Point(353, 12);
			CalculateBox.Name = "CalculateBox";
			CalculateBox.Size = new Size(174, 127);
			CalculateBox.TabIndex = 15;
			CalculateBox.TabStop = false;
			CalculateBox.Text = "CalculateBox";
			// 
			// IgnoreCountlabel
			// 
			SongIgnoreCountlabel.AutoSize = true;
			SongIgnoreCountlabel.Location = new Point(353, 261);
			SongIgnoreCountlabel.Margin = new Padding(0);
			SongIgnoreCountlabel.Name = "IgnoreCountlabel";
			SongIgnoreCountlabel.Size = new Size(73, 15);
			SongIgnoreCountlabel.TabIndex = 17;
			SongIgnoreCountlabel.Text = "IgnoreCount";
			// 
			// IgnoreCountInput
			// 
			SongIgnoreCountInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			SongIgnoreCountInput.Location = new Point(353, 280);
			SongIgnoreCountInput.Margin = new Padding(5, 20, 5, 20);
			SongIgnoreCountInput.Maximum = new decimal(new int[] { 1600, 0, 0, 0 });
			SongIgnoreCountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			SongIgnoreCountInput.Name = "IgnoreCountInput";
			SongIgnoreCountInput.Size = new Size(120, 23);
			SongIgnoreCountInput.TabIndex = 16;
			SongIgnoreCountInput.Tag = "";
			SongIgnoreCountInput.Value = new decimal(new int[] { 30, 0, 0, 0 });
			// 
			// Main
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(537, 552);
			Controls.Add(SongIgnoreCountlabel);
			Controls.Add(SongIgnoreCountInput);
			Controls.Add(CalculateBox);
			Controls.Add(FixRequiredBox);
			Controls.Add(UpdateTimelabel);
			Controls.Add(UpdateTimeInput);
			Controls.Add(RollStartButton);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Main";
			Text = "Main";
			((System.ComponentModel.ISupportInitialize)BadCountInput).EndInit();
			((System.ComponentModel.ISupportInitialize)InitialCountInput).EndInit();
			((System.ComponentModel.ISupportInitialize)UpdateTimeInput).EndInit();
			FixRequiredBox.ResumeLayout(false);
			FixRequiredBox.PerformLayout();
			CalculateBox.ResumeLayout(false);
			CalculateBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)SongIgnoreCountInput).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button RollStartButton;
		private TextBox SongListInput;
		private Label SongListlabel;
		private NumericUpDown BadCountInput;
		private Label BadCountlabel;
		private Label InitialCountlabel;
		private NumericUpDown InitialCountInput;
		private Button FixButton;
		private Label SongCountlabel;
		private TextBox SongCountDisplay;
		private Label UpdateTimelabel;
		private NumericUpDown UpdateTimeInput;
		private CheckBox MarathonModeFlag;
		private GroupBox FixRequiredBox;
		private Button CalculateButton;
		private GroupBox CalculateBox;
		private Label SongIgnoreCountlabel;
		private NumericUpDown SongIgnoreCountInput;
	}
}
