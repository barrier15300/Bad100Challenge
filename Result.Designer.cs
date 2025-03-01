namespace Bad100Challenge {
	partial class Result {
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
			dataGridView1 = new DataGridView();
			ExportButton = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.BackgroundColor = SystemColors.Control;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 41);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.ScrollBars = ScrollBars.Vertical;
			dataGridView1.Size = new Size(776, 397);
			dataGridView1.TabIndex = 0;
			// 
			// ExportButton
			// 
			ExportButton.Location = new Point(12, 12);
			ExportButton.Name = "ExportButton";
			ExportButton.Size = new Size(75, 23);
			ExportButton.TabIndex = 1;
			ExportButton.Text = "Export";
			ExportButton.UseVisualStyleBackColor = true;
			ExportButton.Click += ExportButton_Click;
			// 
			// Result
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ExportButton);
			Controls.Add(dataGridView1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "Result";
			Text = "Result";
			Activated += Result_Activated;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Button ExportButton;
	}
}