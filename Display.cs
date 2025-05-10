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
			ClearCount = 0;
			FullComboCount = 0;
			result.InitResult();
			SetDisplay("", "", "", "", 0);
			SetValue(BadCount, 0, 0);

			timeUpdateThread = Task.Factory.StartNew(() => {
				stopThreadFlag = false;
				Stopwatch sw = new();
				sw.Start();
				while (!(this.IsDisposed || stopThreadFlag)) {
					this.Invoke(() => {
						TimeSpan span = sw.Elapsed;
						TimeDisplay.Text = span.ToString(@"hh\:mm\:ss\.ff");
					});
					Thread.Sleep(50);
				}
				return;
			});
		}

		async Task StopTimeThread() {
			stopThreadFlag = true;
			var token = new CancellationToken(true);
			await timeUpdateThread.WaitAsync(token);
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
				StopTimeThread();
			}
		}

		public void ResultDisplay() {
			this.Activate();
			result.Show();
			result.Activate();
		}

		void SetValue(int left, int cl, int fc) {

			result.AddResult(SongTitle.Text, SongDifficulty.Text, left, fc);

			BadCountlabel.Text = left.ToString() + " " + LeftText;
			ClearCountlabel.Text = cl.ToString() + " " + ClearText;
			FullComboCountlabel.Text = fc.ToString() + " " + FullComboText;
		}

		public void SetDisplay(string title, string subtitle, string genre, string difficulty, int level) {
			static int GetSimpleDisplayWidth(char c) {
			// ASCII
				if (c <= 0x007F)
					return 1;

				// 半角カナ
				if (c >= 0xFF61 && c <= 0xFF9F)
					return 1;

				// 全角記号・カナ・漢字（だいたいの範囲）
				if ((c >= 0x1100 && c <= 0x11FF) ||  // Hangul Jamo
					(c >= 0x2E80 && c <= 0xA4CF) ||  // CJK radicals, Hanzi, Kana
					(c >= 0xAC00 && c <= 0xD7AF) ||  // Hangul Syllables
					(c >= 0xF900 && c <= 0xFAFF) ||  // CJK Compatibility Ideographs
					(c >= 0xFE10 && c <= 0xFE6F) ||  // Vertical forms, etc.
					(c >= 0xFF01 && c <= 0xFF60) ||  // Fullwidth ASCII variants
					(c >= 0xFFE0 && c <= 0xFFE6))    // Fullwidth symbols
				{
					return 2;
				}

				return 1;
			}
			static int GetMultiLength(string s) {
				int ret = 0;
				foreach (char c in s) {
					ret += GetSimpleDisplayWidth(c);
				}
				return ret;
			}

			SongTitle.Text = title;
			SongSubTitle.Text = subtitle;

			var diff_len = GetMultiLength(difficulty) - difficulty.Length;

			string format = string.Format("{{0,2}}★ / {{1,-{0}}} / {{2}}", 10 - diff_len);
			SongDifficulty.Text = string.Format(format, level, difficulty, genre);
		}

		private void Display_VisibleChanged(object sender, EventArgs e) {
			if (!Visible) {
				StopTimeThread();
				result.Hide();
			}
		}

		private void TimeDisplay_Resize(object sender, EventArgs e) {
			TimeDisplay.Location = new Point(this.Width - TimeDisplay.Width - 20, TimeDisplay.Location.Y);
		}
	}
}
