using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Bad100Challenge {
	static class JsonUtility {
		static public bool TryGetValue<T>(this JsonNode? node, out T value) {
			value = default;
			if (node is null) { return false; }
			if (node.GetValue<T>() is T n) {
				value = n;
			}
			return value is not null;
		}

		static public bool TryGetValue<T>(this JsonNode? node, IEnumerable<T> array) {
			array = default;
			if (node is null) { return false; }
			if (node.AsArray() is JsonArray arr) {
				array = arr.Select(x => x.GetValue<T>()).ToArray();
			}
			return array is not null;
		}
	}

	static class ParseUtility {
		static public bool Try<T>(string s, NumberStyles styles, IFormatProvider? provider, out T value) where T : INumber<T> {
			value = T.Zero;
			value = T.Parse(s, styles, provider);
			return value is not null;
		}
		static public bool Try<T>(string s, NumberStyles styles, out T value) where T : INumber<T>
			=> Try(s, styles, null, out value);
		static public bool Try<T>(string s, out T value) where T : INumber<T>
			=> Try(s, NumberStyles.None, null, out value);


		
	}


	class GenreData {
		public bool Parse(JsonNode? node) {
			if (node is null) { return false; }

			if (!node["value"].TryGetValue(out ID)) { return false; }
			if (!node["name"].TryGetValue(out Name)) { return false; }

			return true;
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

		public bool Parse(JsonNode? node) {
			if (node is null) { return false; }

			if (!node["value"].TryGetValue(out ID)) { return false; }
			if (!node["name"].TryGetValue(out Name)) { return false; }

			return true;
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

		public bool Parse(JsonNode? node, DifficultyData[] datas) {
			if (node is null) { return false; }

			if (!node["title"].TryGetValue(out Title)) { return false; }
			if (!node["subtitle"].TryGetValue(out Subtitle)) { return false; }
			if (!node["flags"].TryGetValue(out string hexflags)) { return false; }
			if (!node["difficulty"].TryGetValue(out string hexdifficulty)) { return false; }

			if (!ParseUtility.Try(hexflags.Replace("0x", ""), NumberStyles.HexNumber, out Flags)) { return false; }
			if (!ParseUtility.Try(hexdifficulty.Replace("0x", ""), NumberStyles.HexNumber, out int bits)) { return false; }

			Difficulties = [.. datas.Select((data, i) => {
				int ret = (bits >> (4 * data.ID)) & 0xF;
				return ret;
			}).Where(l => l > 0)];

			if (!node["special_category"].TryGetValue(SpecialCategory)) { return false; }

			return true;
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

			List<string> errors = new();
			var AddError = new Action<JsonNode?>((JsonNode? node) => {
				errors.Add(
					(node is null ? "null" : node.ToJsonString()) + "\n"
					);
			});

			if (node["difficulty_def"] is not JsonNode difficulty_def) { throw new Exception("difficulty_def not found."); }

			foreach (var elem in difficulty_def.AsArray()) {
				var data = new DifficultyData();
				if (!data.Parse(elem)) {
					AddError(elem);
					continue;
				}
				DifficultyDatas = [.. DifficultyDatas, data];
			}

			

			if (node["genre_def"] is not JsonNode genre_def) { throw new Exception("genre_def not found."); }

			foreach (var elem in genre_def.AsArray()) {
				var data = new GenreData();
				if (!data.Parse(elem)) {
					AddError(elem);
					continue;
				}
				GenreDatas = [.. GenreDatas, data];
			}

			JsonNode?[] musics = [node["music_pass"] , node["pre_installed_list"]];

			Array.ForEach(musics, music => {
				if (music is not JsonNode music_list) { AddError(music); return; }
				
				foreach (var item in music_list.AsArray()) {
					if (item is null) { AddError(item); continue; }

					if (Array.Find(GenreDatas, x => item["genre"].TryGetValue(out int id) && x.ID == id) is not GenreData data) { AddError(item); continue; }

					if (item["music_list"] is not JsonNode list) { continue; }

					foreach (var elem in list.AsArray()) {
						var song = new SongData(data);
						if (!song.Parse(elem, DifficultyDatas)) {
							AddError(elem);
							continue;
						}
						data.songs = [.. data.songs, song];
					}
				}
			});

			if (errors.Count != 0) {
				MessageBox.Show(
						string.Concat(errors)
					);
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
