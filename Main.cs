using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Bad100Challenge
{
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}

		bool isFixed = false;
		bool ChallengeCompleted = false;
		string RollStartButtonText = "Roll Start";
		List<string> Songs = new();
		Queue<int> DuplicateIndexQueue = new();

		Display display = new();

		static int GetRandomNum(int max) {
			int ret = 0;
			int shift = (int)Math.Log2(max) + 1;
			do {
				byte[] bytes = RandomNumberGenerator.GetBytes(4);
				ret = BitConverter.ToInt32(bytes) & ((1 << shift) - 1);
			} while (ret >= max);
			return ret;
		}

		bool ConditionCheck() {
			if (!isFixed) {
				RollStartButton.Text = RollStartButtonText + "\nplease click \"Fix Button\"";
				return false;
			}

			if (ChallengeCompleted) {
				RollStartButton.Text = "challenge completed\nnice try!";
				return false;
			}

			return true;
		}

		private void FixButtonEnter(object sender, EventArgs e) {
			FixRequiredBox.Enabled = false;

			isFixed = true;

			if (SongIgnoreCountInput.Value >= Songs.Count) {
				SongIgnoreCountInput.Value = (int)(Songs.Count * 0.8);
			}

			display.Show();
			display.BadCountLessZero = (sender, e) => { ChallengeCompleted = true; };
			display.FormClosed += (sender, e) => { Close(); };
			display.Init((int)InitialCountInput.Value);

			this.Activate();
		}

		private void FocusInRollStartButton(object sender, EventArgs e) {
			ConditionCheck();
		}

		private void FocusOutRollStartButton(object sender, EventArgs e) {
			RollStartButton.Text = RollStartButtonText;
		}

		private void InputSongList(object sender, EventArgs e) {
			Songs = SongListInput.Lines.ToList();
			SongCountDisplay.Text = Songs.Count.ToString();
			if (Songs.Count > 0) {
				FixButton.Enabled = true;
			}
			else {
				FixButton.Enabled = false;
			}
		}

		private void CalculateButton_Click(object sender, EventArgs e) {
			display.Calculate((int)BadCountInput.Value);
			BadCountInput.Value = 0;
			if (Songs.Count == 1) {
				ChallengeCompleted = true;
			}
			CalculateBox.Enabled = false;
			RollStartButton.Enabled = true;
		}

		private void MarathonModeFlag_CheckedChanged(object sender, EventArgs e) {
			SongIgnoreCountInput.Enabled = !MarathonModeFlag.Checked;
		}

		private void RollStartButton_Click(object sender, EventArgs e) {
			if (!ConditionCheck()) {
				return;
			}

			RollStartButton.Text = "Rolling...";
			RollStartButton.Enabled = false;
			BadCountInput.Enabled = false;
			SongListInput.ReadOnly = true;

			this.Update();

			int idx = 0;

			do {
				idx = GetRandomNum(Songs.Count);
			} while (DuplicateIndexQueue.Any((i) => { return idx == i; }));
			
			if (DuplicateIndexQueue.Count >= SongIgnoreCountInput.Value) {
				DuplicateIndexQueue.Dequeue();
			}
			DuplicateIndexQueue.Enqueue(idx);
			
			Stopwatch timer = new();
			timer.Start();

			int[] countupdate = new int[2];
			int updatecount = (int)(1600 / UpdateTimeInput.Value);

			display.Focus();

			while (countupdate[0] < updatecount) {
				int rn = GetRandomNum(Songs.Count);
				display.SetTitle(Songs[rn]);
				display.Update();
				this.Update();
				while (countupdate[0] == countupdate[1]) { countupdate[0] = (int)(timer.Elapsed.TotalMilliseconds / (double)UpdateTimeInput.Value); }
				countupdate[1] = countupdate[0];
			}

			RollStartButton.Text = RollStartButtonText;
			RollStartButton.Enabled = true;
			BadCountInput.Enabled = true;
			SongListInput.ReadOnly = false;

			display.SetTitle(Songs[idx]);
			if (MarathonModeFlag.Checked) {
				Songs.RemoveAt(idx);
			}
			display.Update();

			RollStartButton.Enabled = false;
			CalculateBox.Enabled = true;
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
