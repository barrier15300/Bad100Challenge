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

		int BadCount = 0;
		int ClearCount = 0;
		int FullComboCount = 0;
		string LeftText = "left";
		string ClearText = "CL";
		string FullComboText = "FC";
		string AllPerfectText = "AP";

		public void Init(int initialcount) {
			BadCount = initialcount;
			SetValue(BadCount, 0, 0);
			SetTitle("");
		}

		public void Calculate(int badcount) {
			BadCount -= badcount;

			if (badcount == 0) {
				++FullComboCount;
			}

			if (BadCount <= 0) {
				BadCountLessZero(this, new());
			}
			else {
				++ClearCount;
			}

			SetValue(BadCount, ClearCount, FullComboCount);
		}

		void SetValue(int left, int cl, int fc) {

			BadCountlabel.Text = left.ToString() + " " + LeftText;
			ClearCountlabel.Text = cl.ToString() + " " + ClearText;
			FullComboCountlabel.Text = fc.ToString() + " " + FullComboText;

		}

		public void SetTitle(string title) {
			SongTitlelabel.Text = title;
		}

		public int GetTitleLength() {
			return SongTitlelabel.Text.Length;
		}

		
	}
}
