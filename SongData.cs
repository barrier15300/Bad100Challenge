using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bad100Challenge
{
	class GenreData {
		public void Parse(JsonNode? node) {
			if (node is null) { return; }

			ID = node["value"].GetValue<int>();
			Name = node["name"].GetValue<string>();
		}

		public int ID = 0;
		public string Name = "";

		public SongData[] songs = [];

		public override string ToString() {
			return Name;
		}
	}

	class DifficultyData {

		public DifficultyData() { }

		public void Parse(JsonNode? node) {
			if (node is null) { return; }

			ID = node["value"].GetValue<int>();
			Name = node["name"].GetValue<string>();
		}

		public int ID = 0;
		public string Name = "";

		public override string ToString() {
			return Name;
		}
	}

	class SongData {
		public SongData(GenreData parent) {
			this.Parent = parent;
		}

		public void Parse(JsonNode? node, DifficultyData[] datas) {
			if (node is null) { return; }

			Title = node["title"].GetValue<string>();
			Subtitle = node["subtitle"].GetValue<string>();
			Flags = int.Parse(node["flags"].GetValue<string>().Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);
			int bits = int.Parse(node["difficulty"].GetValue<string>().Replace("0x", ""), System.Globalization.NumberStyles.HexNumber);

			Difficulties = [.. datas.Select((data, i) => {
				int ret = (bits >> (4 * data.ID)) & 0xF;
				return ret;
			}).Where(l => l > 0)];

			SpecialCategory = [.. node["special_category"].AsArray().Select(n => n.GetValue<int>())];
		}

		public string Title = "";
		public string Subtitle = "";
		public int Flags = 0;
		public int[] Difficulties = [];

		public readonly GenreData Parent;

		// maybe use
		public int[] SpecialCategory = [];
	}

	class ChartData {
		
		public ChartData(SongData parent, DifficultyData difficulty) {
			m_Parent = parent;
			m_Difficulty = difficulty;
		}

		public int Level = 0;

		public string Title { get { return m_Parent.Title; } }
		public string Subtitle { get { return m_Parent.Subtitle; } }
		public string Genre { get { return m_Parent.Parent.Name; } }
		public string Difficulty { get { return m_Difficulty.Name; } }

		private readonly SongData m_Parent;
		private readonly DifficultyData m_Difficulty;
	}

	class MusicList {

		// node: raw data
		public void Parse(JsonNode? node) {
			if (node is null) { return; }

			if (node["difficulty_def"] is JsonNode difficulty_def) {
				DifficultyDatas = [.. difficulty_def.AsArray().Select(node => {
					var data = new DifficultyData();
					data.Parse(node);
					return data;
				})];
			}
			else {
				throw new Exception("difficulty_def not found.");
			}

			if (node["genre_def"] is JsonNode genre_def) {
				GenreDatas = [.. genre_def.AsArray().Select(node => {
					var data = new GenreData();
					data.Parse(node);
					return data;
				})];
			}
			else {
				throw new Exception("genre_def not found.");
			}

			if (node["music_pass"] is JsonNode music_pass) {
				foreach (var item in music_pass.AsArray()) {
					GenreData? data = Array.Find(GenreDatas, x => x.ID == item?["genre"]?.GetValue<int>());

					if (data is null) { continue; }

					if (item?["music_list"] is JsonNode list) {
						data.songs = [.. list.AsArray().Select(node => {
							var song = new SongData(data);
							song.Parse(node, DifficultyDatas);
							return song;
						})];
					}
				}
			}
			else {
				throw new Exception("music_pass not found.");
			}
		}

		public class Predicate {

			public Tuple<int, int> Levels = new(0, 0);

			public int[] Genre = [];

			public DifficultyData[] Difficulty = [];
		}

		public void Filter(Predicate predicate) {

			List<ChartData> ret = new();
			
			Array.ForEach(GenreDatas, genre => {
				if (!predicate.Genre.Any(x => x == genre.ID)) { return; }
				
				Array.ForEach(genre.songs, song => {
					for (int i = 0; i < song.Difficulties.Length; ++i) {
						DifficultyData? difficulty = Array.Find(predicate.Difficulty, x => x.ID == DifficultyDatas[i].ID);
						
						if (difficulty is null) { continue; }

						ChartData item = new(
							song,
							difficulty
							);
						item.Level = song.Difficulties[difficulty.ID - 1];

						if (!(item.Level >= predicate.Levels.Item1 && item.Level <= predicate.Levels.Item2)) { continue; }

						ret.Add(item);
					}
				});
			});

			ChartDatas = ret;
		}

		public Predicate DefaultPredicate {
			get {
				return new Predicate {
					Levels = new(1, 10),
					Genre = [.. GenreDatas.Select(x => x.ID)],
					Difficulty = [.. DifficultyDatas]
				};
			}
		}

		public DifficultyData[] DifficultyDatas = [];
		public GenreData[] GenreDatas = [];
		public List<ChartData> ChartDatas = new List<ChartData>();
	}
}
