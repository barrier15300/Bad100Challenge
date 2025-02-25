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
			FixInitialCountbutton = new Button();
			SongCountlabel = new Label();
			SongCountDisplay = new TextBox();
			UpdateTimelabel = new Label();
			UpdateTimeInput = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)BadCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)InitialCountInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)UpdateTimeInput).BeginInit();
			SuspendLayout();
			// 
			// RollStartButton
			// 
			RollStartButton.Location = new Point(187, 66);
			RollStartButton.Margin = new Padding(5);
			RollStartButton.Name = "RollStartButton";
			RollStartButton.Size = new Size(158, 45);
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
			SongListInput.Location = new Point(12, 27);
			SongListInput.Multiline = true;
			SongListInput.Name = "SongListInput";
			SongListInput.ScrollBars = ScrollBars.Both;
			SongListInput.Size = new Size(167, 354);
			SongListInput.TabIndex = 1;
			SongListInput.WordWrap = false;
			SongListInput.TextChanged += InputSongList;
			SongListInput.DragDrop += SongListInput_DragDrop;
			SongListInput.DragEnter += SongListInput_DragEnter;
			// 
			// SongListlabel
			// 
			SongListlabel.AutoSize = true;
			SongListlabel.Location = new Point(12, 9);
			SongListlabel.Name = "SongListlabel";
			SongListlabel.Size = new Size(52, 15);
			SongListlabel.TabIndex = 2;
			SongListlabel.Text = "SongList";
			// 
			// BadCountInput
			// 
			BadCountInput.Location = new Point(187, 28);
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
			BadCountlabel.Location = new Point(187, 9);
			BadCountlabel.Margin = new Padding(0);
			BadCountlabel.Name = "BadCountlabel";
			BadCountlabel.Size = new Size(59, 15);
			BadCountlabel.TabIndex = 4;
			BadCountlabel.Text = "BadCount";
			// 
			// InitialCountlabel
			// 
			InitialCountlabel.AutoSize = true;
			InitialCountlabel.Location = new Point(187, 117);
			InitialCountlabel.Name = "InitialCountlabel";
			InitialCountlabel.Size = new Size(68, 15);
			InitialCountlabel.TabIndex = 5;
			InitialCountlabel.Text = "InitialCount";
			// 
			// InitialCountInput
			// 
			InitialCountInput.Location = new Point(187, 136);
			InitialCountInput.Margin = new Padding(3, 20, 3, 20);
			InitialCountInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			InitialCountInput.Name = "InitialCountInput";
			InitialCountInput.Size = new Size(120, 23);
			InitialCountInput.TabIndex = 6;
			InitialCountInput.Tag = "";
			InitialCountInput.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// FixInitialCountbutton
			// 
			FixInitialCountbutton.Location = new Point(313, 136);
			FixInitialCountbutton.Name = "FixInitialCountbutton";
			FixInitialCountbutton.Size = new Size(32, 23);
			FixInitialCountbutton.TabIndex = 7;
			FixInitialCountbutton.Text = "Fix";
			FixInitialCountbutton.UseVisualStyleBackColor = true;
			FixInitialCountbutton.Click += InitialCountFixed;
			// 
			// SongCountlabel
			// 
			SongCountlabel.AutoSize = true;
			SongCountlabel.Location = new Point(12, 397);
			SongCountlabel.Name = "SongCountlabel";
			SongCountlabel.Size = new Size(66, 15);
			SongCountlabel.TabIndex = 8;
			SongCountlabel.Text = "SongCount";
			// 
			// SongCountDisplay
			// 
			SongCountDisplay.Location = new Point(12, 415);
			SongCountDisplay.Name = "SongCountDisplay";
			SongCountDisplay.ReadOnly = true;
			SongCountDisplay.Size = new Size(167, 23);
			SongCountDisplay.TabIndex = 9;
			// 
			// UpdateTimelabel
			// 
			UpdateTimelabel.AutoSize = true;
			UpdateTimelabel.Location = new Point(187, 180);
			UpdateTimelabel.Margin = new Padding(0);
			UpdateTimelabel.Name = "UpdateTimelabel";
			UpdateTimelabel.Size = new Size(70, 15);
			UpdateTimelabel.TabIndex = 11;
			UpdateTimelabel.Text = "UpdateTime";
			// 
			// UpdateTimeInput
			// 
			UpdateTimeInput.Increment = new decimal(new int[] { 10, 0, 0, 0 });
			UpdateTimeInput.Location = new Point(187, 199);
			UpdateTimeInput.Margin = new Padding(5, 20, 5, 20);
			UpdateTimeInput.Maximum = new decimal(new int[] { 1600, 0, 0, 0 });
			UpdateTimeInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			UpdateTimeInput.Name = "UpdateTimeInput";
			UpdateTimeInput.Size = new Size(120, 23);
			UpdateTimeInput.TabIndex = 10;
			UpdateTimeInput.Tag = "";
			UpdateTimeInput.Value = new decimal(new int[] { 50, 0, 0, 0 });
			// 
			// Main
			// 
			AutoScaleMode = AutoScaleMode.None;
			ClientSize = new Size(352, 453);
			Controls.Add(UpdateTimelabel);
			Controls.Add(UpdateTimeInput);
			Controls.Add(SongCountDisplay);
			Controls.Add(SongCountlabel);
			Controls.Add(FixInitialCountbutton);
			Controls.Add(InitialCountInput);
			Controls.Add(InitialCountlabel);
			Controls.Add(BadCountlabel);
			Controls.Add(BadCountInput);
			Controls.Add(SongListlabel);
			Controls.Add(SongListInput);
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
		private Button FixInitialCountbutton;
		private Label SongCountlabel;
		private TextBox SongCountDisplay;
		private Label UpdateTimelabel;
		private NumericUpDown UpdateTimeInput;
	}
}
