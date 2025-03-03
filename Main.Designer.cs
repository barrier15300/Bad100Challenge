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
			BadCountInput = new NumericUpDown();
			BadCountlabel = new Label();
			UpdateTimelabel = new Label();
			UpdateTimeInput = new NumericUpDown();
			CalculateButton = new Button();
			CalculateBox = new GroupBox();
			SongIgnoreCountlabel = new Label();
			SongIgnoreCountInput = new NumericUpDown();
			ResetButton = new Button();
			SongListlabel = new Label();
			SongListInput = new TextBox();
			FixButton = new Button();
			SongCountlabel = new Label();
			SongCountDisplay = new TextBox();
			InitialCountlabel = new Label();
			InitialCountInput = new NumericUpDown();
			MarathonModeFlag = new CheckBox();
			ImportButton = new Button();
			LoadButton = new Button();
			GenreFilterFlags = new CheckedListBox();
			GenreFilterlabel = new Label();
			DifficultyFilterFlags = new CheckedListBox();
			DifficultyFilterlabel = new Label();
			MinDifficultytrackbar = new TrackBar();
			MaxDifficultytrackbar = new TrackBar();
			MinDifficultylabel = new Label();
			FixRequiredBox = new GroupBox();
			MaxDifficultyDisplay = new TextBox();
			MinDifficultyDisplay = new TextBox();
			MaxDifficultylabel = new Label();
			((System.ComponentModel.ISupportInitialize)BadCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)UpdateTimeInput).BeginInit();
			CalculateBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SongIgnoreCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)InitialCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)MinDifficultytrackbar).BeginInit();
			((System.ComponentModel.ISupportInitialize)MaxDifficultytrackbar).BeginInit();
			FixRequiredBox.SuspendLayout();
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
			// SongIgnoreCountlabel
			// 
			SongIgnoreCountlabel.AutoSize = true;
			SongIgnoreCountlabel.Location = new Point(353, 261);
			SongIgnoreCountlabel.Margin = new Padding(0);
			SongIgnoreCountlabel.Name = "SongIgnoreCountlabel";
			SongIgnoreCountlabel.Size = new Size(100, 15);
			SongIgnoreCountlabel.TabIndex = 17;
			SongIgnoreCountlabel.Text = "SongIgnoreCount";
			// 
			// SongIgnoreCountInput
			// 
			SongIgnoreCountInput.Location = new Point(353, 280);
			SongIgnoreCountInput.Margin = new Padding(5, 20, 5, 20);
			SongIgnoreCountInput.Maximum = new decimal(new int[] { 1600, 0, 0, 0 });
			SongIgnoreCountInput.Name = "SongIgnoreCountInput";
			SongIgnoreCountInput.Size = new Size(120, 23);
			SongIgnoreCountInput.TabIndex = 16;
			SongIgnoreCountInput.Tag = "";
			SongIgnoreCountInput.Value = new decimal(new int[] { 30, 0, 0, 0 });
			// 
			// ResetButton
			// 
			ResetButton.Location = new Point(353, 493);
			ResetButton.Margin = new Padding(5);
			ResetButton.Name = "ResetButton";
			ResetButton.Size = new Size(174, 45);
			ResetButton.TabIndex = 18;
			ResetButton.Text = "Reset";
			ResetButton.UseVisualStyleBackColor = true;
			ResetButton.Click += ResetButton_Click;
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
			// SongListInput
			// 
			SongListInput.AllowDrop = true;
			SongListInput.Location = new Point(6, 39);
			SongListInput.Name = "SongListInput";
			SongListInput.ScrollBars = ScrollBars.Both;
			SongListInput.Size = new Size(112, 23);
			SongListInput.TabIndex = 1;
			SongListInput.Text = "./music_list.json";
			SongListInput.WordWrap = false;
			SongListInput.DragDrop += SongListInput_DragDrop;
			SongListInput.DragEnter += SongListInput_DragEnter;
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
			// ImportButton
			// 
			ImportButton.Location = new Point(98, 13);
			ImportButton.Name = "ImportButton";
			ImportButton.Size = new Size(75, 23);
			ImportButton.TabIndex = 13;
			ImportButton.Text = "Import";
			ImportButton.UseVisualStyleBackColor = true;
			ImportButton.Click += ImportButton_Click;
			// 
			// LoadButton
			// 
			LoadButton.Location = new Point(124, 39);
			LoadButton.Name = "LoadButton";
			LoadButton.Size = new Size(49, 23);
			LoadButton.TabIndex = 14;
			LoadButton.Text = "Load";
			LoadButton.UseVisualStyleBackColor = true;
			LoadButton.Click += LoadButton_Click;
			// 
			// GenreFilterFlags
			// 
			GenreFilterFlags.CheckOnClick = true;
			GenreFilterFlags.FormattingEnabled = true;
			GenreFilterFlags.Location = new Point(6, 89);
			GenreFilterFlags.Name = "GenreFilterFlags";
			GenreFilterFlags.Size = new Size(148, 112);
			GenreFilterFlags.TabIndex = 15;
			GenreFilterFlags.SelectedIndexChanged += GenreFilterFlags_SelectedIndexChanged;
			// 
			// GenreFilterlabel
			// 
			GenreFilterlabel.AutoSize = true;
			GenreFilterlabel.Location = new Point(6, 71);
			GenreFilterlabel.Name = "GenreFilterlabel";
			GenreFilterlabel.Size = new Size(64, 15);
			GenreFilterlabel.TabIndex = 16;
			GenreFilterlabel.Text = "GenreFilter";
			// 
			// DifficultyFilterFlags
			// 
			DifficultyFilterFlags.CheckOnClick = true;
			DifficultyFilterFlags.FormattingEnabled = true;
			DifficultyFilterFlags.Location = new Point(179, 89);
			DifficultyFilterFlags.Name = "DifficultyFilterFlags";
			DifficultyFilterFlags.Size = new Size(148, 112);
			DifficultyFilterFlags.TabIndex = 17;
			DifficultyFilterFlags.SelectedIndexChanged += DifficultyFilterFlags_SelectedIndexChanged;
			// 
			// DifficultyFilterlabel
			// 
			DifficultyFilterlabel.AutoSize = true;
			DifficultyFilterlabel.Location = new Point(179, 71);
			DifficultyFilterlabel.Name = "DifficultyFilterlabel";
			DifficultyFilterlabel.Size = new Size(80, 15);
			DifficultyFilterlabel.TabIndex = 18;
			DifficultyFilterlabel.Text = "DifficultyFilter";
			// 
			// MinDifficultytrackbar
			// 
			MinDifficultytrackbar.Location = new Point(6, 332);
			MinDifficultytrackbar.Minimum = 1;
			MinDifficultytrackbar.Name = "MinDifficultytrackbar";
			MinDifficultytrackbar.Size = new Size(148, 45);
			MinDifficultytrackbar.TabIndex = 19;
			MinDifficultytrackbar.TickStyle = TickStyle.TopLeft;
			MinDifficultytrackbar.Value = 1;
			MinDifficultytrackbar.Scroll += MinDifficulty_Scroll;
			// 
			// MaxDifficultytrackbar
			// 
			MaxDifficultytrackbar.Location = new Point(6, 398);
			MaxDifficultytrackbar.Minimum = 1;
			MaxDifficultytrackbar.Name = "MaxDifficultytrackbar";
			MaxDifficultytrackbar.Size = new Size(148, 45);
			MaxDifficultytrackbar.TabIndex = 20;
			MaxDifficultytrackbar.TickStyle = TickStyle.TopLeft;
			MaxDifficultytrackbar.Value = 10;
			MaxDifficultytrackbar.Scroll += MaxDifficulty_Scroll;
			// 
			// MinDifficultylabel
			// 
			MinDifficultylabel.AutoSize = true;
			MinDifficultylabel.Location = new Point(6, 314);
			MinDifficultylabel.Name = "MinDifficultylabel";
			MinDifficultylabel.Size = new Size(75, 15);
			MinDifficultylabel.TabIndex = 21;
			MinDifficultylabel.Text = "MinDifficulty";
			// 
			// FixRequiredBox
			// 
			FixRequiredBox.Controls.Add(MaxDifficultyDisplay);
			FixRequiredBox.Controls.Add(MinDifficultyDisplay);
			FixRequiredBox.Controls.Add(MaxDifficultylabel);
			FixRequiredBox.Controls.Add(MinDifficultylabel);
			FixRequiredBox.Controls.Add(MaxDifficultytrackbar);
			FixRequiredBox.Controls.Add(MinDifficultytrackbar);
			FixRequiredBox.Controls.Add(DifficultyFilterlabel);
			FixRequiredBox.Controls.Add(DifficultyFilterFlags);
			FixRequiredBox.Controls.Add(GenreFilterlabel);
			FixRequiredBox.Controls.Add(GenreFilterFlags);
			FixRequiredBox.Controls.Add(LoadButton);
			FixRequiredBox.Controls.Add(ImportButton);
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
			// MaxDifficultyDisplay
			// 
			MaxDifficultyDisplay.Location = new Point(179, 398);
			MaxDifficultyDisplay.Name = "MaxDifficultyDisplay";
			MaxDifficultyDisplay.ReadOnly = true;
			MaxDifficultyDisplay.Size = new Size(148, 23);
			MaxDifficultyDisplay.TabIndex = 24;
			MaxDifficultyDisplay.Text = "10";
			// 
			// MinDifficultyDisplay
			// 
			MinDifficultyDisplay.Location = new Point(179, 332);
			MinDifficultyDisplay.Name = "MinDifficultyDisplay";
			MinDifficultyDisplay.ReadOnly = true;
			MinDifficultyDisplay.Size = new Size(148, 23);
			MinDifficultyDisplay.TabIndex = 23;
			MinDifficultyDisplay.Text = "1";
			// 
			// MaxDifficultylabel
			// 
			MaxDifficultylabel.AutoSize = true;
			MaxDifficultylabel.Location = new Point(6, 380);
			MaxDifficultylabel.Name = "MaxDifficultylabel";
			MaxDifficultylabel.Size = new Size(77, 15);
			MaxDifficultylabel.TabIndex = 22;
			MaxDifficultylabel.Text = "MaxDifficulty";
			// 
			// Main
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(537, 552);
			Controls.Add(ResetButton);
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
			Name = "Main";
			Text = "Main";
			((System.ComponentModel.ISupportInitialize)BadCountInput).EndInit();
			((System.ComponentModel.ISupportInitialize)UpdateTimeInput).EndInit();
			CalculateBox.ResumeLayout(false);
			CalculateBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)SongIgnoreCountInput).EndInit();
			((System.ComponentModel.ISupportInitialize)InitialCountInput).EndInit();
			((System.ComponentModel.ISupportInitialize)MinDifficultytrackbar).EndInit();
			((System.ComponentModel.ISupportInitialize)MaxDifficultytrackbar).EndInit();
			FixRequiredBox.ResumeLayout(false);
			FixRequiredBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button RollStartButton;
		private NumericUpDown BadCountInput;
		private Label BadCountlabel;
		private Label UpdateTimelabel;
		private NumericUpDown UpdateTimeInput;
		private Button CalculateButton;
		private GroupBox CalculateBox;
		private Label SongIgnoreCountlabel;
		private NumericUpDown SongIgnoreCountInput;
		private Button ResetButton;
		private Label SongListlabel;
		private TextBox SongListInput;
		private Button FixButton;
		private Label SongCountlabel;
		private TextBox SongCountDisplay;
		private Label InitialCountlabel;
		private NumericUpDown InitialCountInput;
		private CheckBox MarathonModeFlag;
		private Button ImportButton;
		private Button LoadButton;
		private CheckedListBox GenreFilterFlags;
		private Label GenreFilterlabel;
		private CheckedListBox DifficultyFilterFlags;
		private Label DifficultyFilterlabel;
		private TrackBar MinDifficultytrackbar;
		private TrackBar MaxDifficultytrackbar;
		private Label MinDifficultylabel;
		private GroupBox FixRequiredBox;
		private Label MaxDifficultylabel;
		private TextBox MaxDifficultyDisplay;
		private TextBox MinDifficultyDisplay;
	}
}
