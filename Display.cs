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
using static System.Runtime.InteropServices.JavaScript.JSType;

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

		Task timeUpdateThread;
		bool stopThreadFlag = false;

		public void Init(int initialcount) {
			BadCount = initialcount;
			SetDisplay("", "", "", "", 0);
			SetValue(BadCount, 0, 0);
			timeUpdateThread = Task.Factory.StartNew(() => {
				stopThreadFlag = false;
				Stopwatch sw = new();
				sw.Start();
				int[] updatecounter = new int[2];
				while (true) {
					if (this.IsDisposed || stopThreadFlag) {
						break;
					}
					this.Invoke(() => {
						TimeSpan span = sw.Elapsed;
						TimeDisplay.Text = span.ToString(@"hh\:mm\:ss\.ff");
					});
					Thread.Sleep(50);
				}
			});
		}

		public void Calculate(int badcount) {
			BadCount -= badcount;

			if (badcount == 0) {
				++FullComboCount;
			}

			if (BadCount > 0) {
				++ClearCount;
			}
			SetValue(BadCount, ClearCount, FullComboCount);

			if (BadCount <= 0) {
				BadCountLessZero?.Invoke(this, EventArgs.Empty);
				stopThreadFlag = true;
				timeUpdateThread.Wait();
			}
		}

		public void ResultDisplay() {
			this.Activate();
			result.Show();
			result.FormClosed += (sender, e) => { this.Close(); };
			result.Activate();
		}

		void SetValue(int left, int cl, int fc) {

			result.AddResult(SongTitle.Text, SongDifficulty.Text, left, fc);

			BadCountlabel.Text = left.ToString() + " " + LeftText;
			ClearCountlabel.Text = cl.ToString() + " " + ClearText;
			FullComboCountlabel.Text = fc.ToString() + " " + FullComboText;
		}

		public void SetDisplay(string title, string subtitle, string genre, string difficulty, int level) {
			SongTitle.Text = title;
			SongSubTitle.Text = subtitle;
			SongDifficulty.Text = $"{genre} / {difficulty} / {level} star";
		}

		private void Display_VisibleChanged(object sender, EventArgs e) {
			if (!Visible) {
				stopThreadFlag = true;
				timeUpdateThread.Wait();
				result.Hide();
				result.InitResult();
			}
		}

		private void TimeDisplay_Resize(object sender, EventArgs e) {
			TimeDisplay.Location = new Point(this.Width - TimeDisplay.Width - 20, TimeDisplay.Location.Y);
		}
	}
}
