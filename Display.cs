using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bad100Challenge
{
	public partial class Display : Form {
		public Display() {
			InitializeComponent();
		}

		public EventHandler BadCountLessZero;

		Result result = new();

		int BadCount = 0;
		int ClearCount = 0;
		int FullComboCount = 0;
		string LeftText = "left";
		string ClearText = "CL";
		string FullComboText = "FC";

		public void Init(int initialcount) {
			BadCount = initialcount;
			SetTitle("");
			SetValue(BadCount, 0, 0);
		}

		public void Calculate(int badcount) {
			BadCount -= badcount;

			if (badcount == 0) {
				++FullComboCount;
			}

			if (BadCount <= 0) {
				BadCountLessZero?.Invoke(this, EventArgs.Empty);
				SetValue(BadCount, ClearCount, FullComboCount);
				this.Activate();
				result.Show();
				result.FormClosed += (sender, e) => { this.Close(); };
				result.Activate();
			}
			else {
				++ClearCount;
				SetValue(BadCount, ClearCount, FullComboCount);
			}
		}


		void SetValue(int left, int cl, int fc) {

			result.AddResult(SongTitlelabel.Text, left, fc);

			BadCountlabel.Text = left.ToString() + " " + LeftText;
			ClearCountlabel.Text = cl.ToString() + " " + ClearText;
			FullComboCountlabel.Text = fc.ToString() + " " + FullComboText;

		}

		public void SetTitle(string title) {
			SongTitlelabel.Text = title;
		}

		private void Display_VisibleChanged(object sender, EventArgs e) {
			if (!this.Visible) {
				result.Hide();
			}
		}
	}
}
