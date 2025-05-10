using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bad100Challenge
{
	public partial class Result : Form {

		class ResultItemBase {
			public int index { get; set; } = 0;
			public string tilte { get; set; } = "";
			public string difficulty { get; set; } = "";
			public int left { get; set; } = 0;
			public int left_diff { get; set; } = 0;

			public int fc { get; set; } = 0;
			public int fc_diff { get; set; } = 0;
		}

		public Result() {
			InitializeComponent();
		}

		List<ResultItemBase> _results = new();

		public void InitResult() {
			_results.Clear();
		}

		public void AddResult(string title, string difficulty, int left, int fc) {

			ResultItemBase item = new() {
				index = _results.Count,
				tilte = title,
				difficulty = difficulty,
				left = left,
				fc = fc,
			};


			if (_results.Count - 1 >= 0) {
				var last = _results[^1];

				item.left_diff = left - last.left;
				item.fc_diff = fc - last.fc;
			}

			_results.Add(item);

		}

		private void Result_Activated(object sender, EventArgs e) {
			dataGridView1.DataSource = new DataGridView();
			dataGridView1.DataSource = _results;
		}

		private void ExportButton_Click(object sender, EventArgs e) {

			Directory.CreateDirectory(Environment.CurrentDirectory + "\\Export");

			SaveFileDialog dialog = new() {
				Filter = "csv file(*.csv)|*.csv|All file(*.*)|*.*",
				Title = "保存先のファイルを選択してください",
				FileName = Environment.CurrentDirectory + "\\Export\\result.csv",
			};
			DialogResult result = dialog.ShowDialog();

			if (result != DialogResult.OK) { return; }

			using (StreamWriter sw = new(dialog.FileName, false, Encoding.UTF8)) {

				_results.ForEach(item => sw.WriteLine($"{item.index},{item.tilte}, {item.left}, {item.left_diff}, {item.fc}, {item.fc_diff}"));
			}

		}
	}
}
