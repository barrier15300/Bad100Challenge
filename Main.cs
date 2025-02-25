using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Bad100Challenge
{
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}

		bool initialCountFixed = false;
		bool ChallengeCompleted = false;
		string RollStartButtonText = "Roll Start";

		Display display = new();

		int GetRandomNum(int max) {
			int complexcount = 1;
			byte[] bytes = RandomNumberGenerator.GetBytes(complexcount * 4);
			int ret = 0;
			for (int i = 0; i < complexcount; i += 4) {
				ret ^= bytes[i + 0] << 0;
				ret ^= bytes[i + 1] << 0;
				ret ^= bytes[i + 2] << 0;
				ret ^= bytes[i + 3] << 0;
			}
			return (ret % max);
		}

		bool ConditionCheck() {
			if (!initialCountFixed) {
				RollStartButton.Text = RollStartButtonText + "\nplease click \"Fix Button\"";
				return false;
			}

			if (SongListInput.Lines.Length == 0) {
				RollStartButton.Text = RollStartButtonText + "\nplease write \"SongList\"";
				return false;
			}

			if (ChallengeCompleted) {
				RollStartButton.Text = "challenge completed\nnice try!";
				return false;
			}

			return true;
		}

		private void InitialCountFixed(object sender, EventArgs e) {
			InitialCountInput.Enabled = false;
			FixInitialCountbutton.Enabled = false;
			initialCountFixed = true;

			display.Show();
			display.BadCountLessZero = (sender, e) => { ChallengeCompleted = true; };
			display.FormClosed += (sender, e) => { Close(); };
			display.Init((int)InitialCountInput.Value);
		}

		private void FocusInRollStartButton(object sender, EventArgs e) {
			ConditionCheck();
		}

		private void FocusOutRollStartButton(object sender, EventArgs e) {
			RollStartButton.Text = RollStartButtonText;
		}

		private void InputSongList(object sender, EventArgs e) {
			SongCountDisplay.Text = SongListInput.Lines.Length.ToString();
		}

		private void RollStartButton_Click(object sender, EventArgs e) {
			if (!ConditionCheck()) {
				return;
			}

			if (display.GetTitleLength() != 0) {
				display.Calculate((int)BadCountInput.Value);
				BadCountInput.Value = 0;
			}

			if (!ConditionCheck()) {
				return;
			}

			RollStartButton.Text = "Rolling...";
			RollStartButton.Enabled = false;
			BadCountInput.Enabled = false;
			SongListInput.ReadOnly = true;

			this.Update();

			int idx = GetRandomNum(SongListInput.Lines.Length);

			Stopwatch timer = new();
			timer.Start();

			int[] countupdate = new int[2];
			int updatecount = (int)(1600 / UpdateTimeInput.Value);

			display.Focus();

			while (countupdate[0] < updatecount) {
				int rn = GetRandomNum(SongListInput.Lines.Length);
				display.SetTitle(SongListInput.Lines[rn]);
				display.Update();
				this.Update();
				while (countupdate[0] == countupdate[1]) { countupdate[0] = (int)(timer.Elapsed.TotalMilliseconds / (double)UpdateTimeInput.Value); }
				countupdate[1] = countupdate[0];
			}

			RollStartButton.Text = RollStartButtonText;
			RollStartButton.Enabled = true;
			BadCountInput.Enabled = true;
			SongListInput.ReadOnly = false;

			display.SetTitle(SongListInput.Lines[idx]);
			display.Update();
		}

		private void SongListInput_DragDrop(object sender, DragEventArgs e) {

			if (e.Data is null) { return; }

			string[]? path = (string[]?)e.Data.GetData(DataFormats.FileDrop, false);

			if (path is null) { return; }

			List<string> ret = new();

			foreach (var p in path) {
				List<string> temp = new();
				using (StreamReader sr = new(p, Encoding.UTF8)) {
					while (!sr.EndOfStream) {
						string line = sr.ReadLine();
						if (line == string.Empty) {
							continue;
						}
						temp.Add(line);
					}
				}
				ret.AddRange(temp);
			}

			SongListInput.Lines = ret.ToArray();
			SongListInput.Focus();
		}

		private void SongListInput_DragEnter(object sender, DragEventArgs e) {

			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Copy;
			}
			else {
				e.Effect = DragDropEffects.None;
			}

		}
	}
}
