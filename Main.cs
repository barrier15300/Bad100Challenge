using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Bad100Challenge
{
	public partial class Main : Form {
#if RELEASE
		public Main() {
			InitializeComponent();
		}
#elif DEBUG

		public Main() {
			InitializeComponent();

		}
#endif

		bool isFixed = false;
		bool ChallengeCompleted = false;
		string RollStartButtonText = "Roll Start";
		MusicList MusicList = new();
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

		private void ResetButton_Click(object sender, EventArgs e) {
			display.Hide();
			isFixed = false;
			FixRequiredBox.Enabled = true;
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
		private void MinDifficulty_Scroll(object sender, EventArgs e) {
			if (MinDifficultytrackbar.Value > MaxDifficultytrackbar.Value) {
				MaxDifficultytrackbar.Value = MinDifficultytrackbar.Value;
			}

			MinDifficultyDisplay.Text = MinDifficultytrackbar.Value.ToString();
			MaxDifficultyDisplay.Text = MaxDifficultytrackbar.Value.ToString();

			FilterUpdate();
		}

		private void MaxDifficulty_Scroll(object sender, EventArgs e) {
			if (MaxDifficultytrackbar.Value < MinDifficultytrackbar.Value) {
				MinDifficultytrackbar.Value = MaxDifficultytrackbar.Value;
			}

			MinDifficultyDisplay.Text = MinDifficultytrackbar.Value.ToString();
			MaxDifficultyDisplay.Text = MaxDifficultytrackbar.Value.ToString();

			FilterUpdate();
		}

		private void GenreFilterFlags_SelectedIndexChanged(object sender, EventArgs e) {
			FilterUpdate();
		}

		private void DifficultyFilterFlags_SelectedIndexChanged(object sender, EventArgs e) {
			FilterUpdate();
		}

		private void FixButtonEnter(object sender, EventArgs e) {
			FixRequiredBox.Enabled = false;

			isFixed = true;

			SongIgnoreCountInput.Maximum = (int)(MusicList.ChartDatas.Count * 0.9);
			if (SongIgnoreCountInput.Value >= MusicList.ChartDatas.Count) {
				SongIgnoreCountInput.Value = (int)(MusicList.ChartDatas.Count * 0.3);
			}

			CalculateBox.Enabled = false;
			RollStartButton.Enabled = true;

			display.Show();
			display.BadCountLessZero = (sender, e) => { ChallengeCompleted = true; display.ResultDisplay(); };
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

		private void CalculateButton_Click(object sender, EventArgs e) {
			display.Calculate((int)BadCountInput.Value);
			BadCountInput.Value = 0;
			if (MusicList.ChartDatas.Count == 0) {
				display.BadCountLessZero?.Invoke(this, EventArgs.Empty);
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
				idx = GetRandomNum(MusicList.ChartDatas.Count);
			} while (DuplicateIndexQueue.Any((i) => { return idx == i; }));

			if (DuplicateIndexQueue.Count >= SongIgnoreCountInput.Value) {
				DuplicateIndexQueue.Dequeue();
			}
			
			Stopwatch timer = new();
			timer.Start();

			int[] countupdate = new int[2];
			int updatecount = (int)(1600 / UpdateTimeInput.Value);

			display.Focus();

			while (countupdate[0] < updatecount) {
				var rs = MusicList.ChartDatas[GetRandomNum(MusicList.ChartDatas.Count)];
				display.SetDisplay(
					rs.Title,
					rs.Subtitle,
					rs.Genre,
					rs.Difficulty,
					rs.Level
					);
				display.Update();
				this.Update();
				while (countupdate[0] == countupdate[1]) { countupdate[0] = (int)(timer.Elapsed.TotalMilliseconds / (double)UpdateTimeInput.Value); }
				countupdate[1] = countupdate[0];
			}

			RollStartButton.Text = RollStartButtonText;
			RollStartButton.Enabled = true;
			BadCountInput.Enabled = true;
			SongListInput.ReadOnly = false;

			var song = MusicList.ChartDatas[idx];
			display.SetDisplay(
					song.Title,
					song.Subtitle,
					song.Genre,
					song.Difficulty,
					song.Level
					);
			if (MarathonModeFlag.Checked) {
				MusicList.ChartDatas.RemoveAt(idx);
			}
			else {
				DuplicateIndexQueue.Enqueue(idx);
			}
			display.Update();

			RollStartButton.Enabled = false;
			CalculateBox.Enabled = true;
		}

		void FilterUpdate() {
			MusicList.Filter(
				new MusicList.Predicate {
					Levels = new(MinDifficultytrackbar.Value, MaxDifficultytrackbar.Value),
					Genre = [.. GenreFilterFlags.CheckedItems.Cast<GenreData>().Select(x => x.ID)],
					Difficulty = [.. DifficultyFilterFlags.CheckedItems.Cast<DifficultyData>()]
				}
				);
			SongCountDisplay.Text = MusicList.ChartDatas.Count.ToString();
		}

		private void LoadButton_Click(object sender, EventArgs e) {
			SongListInput_Update(SongListInput.Text);

			SongCountDisplay.Text = MusicList.ChartDatas.Count.ToString();

			GenreFilterFlags.Items.Clear();
			GenreFilterFlags.Items.AddRange(MusicList.GenreDatas);
			for (int i = 0; i < GenreFilterFlags.Items.Count; i++) {
				GenreFilterFlags.SetItemChecked(i, true);
			}

			DifficultyFilterFlags.Items.Clear();
			DifficultyFilterFlags.Items.AddRange(MusicList.DifficultyDatas);
			for (int i = 0; i < DifficultyFilterFlags.Items.Count; i++) {
				DifficultyFilterFlags.SetItemChecked(i, true);
			}

			if (MusicList.ChartDatas.Count > 0) {
				FixButton.Enabled = true;
			}
			else {
				FixButton.Enabled = false;
			}
		}

		void SongListInput_Update(string path) {
			if (!File.Exists(path)) { return; }
			
			try {
				using (StreamReader sr = new(path, Encoding.UTF8)) {
					MusicList.Parse(JsonSerializer.Deserialize<JsonNode>(sr.ReadToEnd()));
				}
			}
			catch (Exception e) {
				MessageBox.Show("invalid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			MusicList.Filter(MusicList.DefaultPredicate);
		}

		private void SongListInput_DragDrop(object sender, DragEventArgs e) {

			if (e.Data is null) { return; }

			string[]? path = (string[]?)e.Data.GetData(DataFormats.FileDrop, false);

			if (path is null) { return; }

			SongListInput_Update(path[0]);
		}

		private void SongListInput_DragEnter(object sender, DragEventArgs e) {

			if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
				e.Effect = DragDropEffects.Copy;
			}
			else {
				e.Effect = DragDropEffects.None;
			}
		}

		private void ImportButton_Click(object sender, EventArgs e) {

			OpenFileDialog dialog = new() {
				Filter = "json files (*.json)|*.json|All files (*.*)|*.*",
				FilterIndex = 1,
				RestoreDirectory = true,
				CheckFileExists = true,
				CheckPathExists = true,
				FileName = Environment.CurrentDirectory,
			};
			DialogResult result = dialog.ShowDialog();

			if (result == DialogResult.OK) {
				SongListInput_Update(dialog.FileName);
			}
		}

	}
}
