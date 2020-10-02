using System;
using System.Collections.Generic;

namespace LD47.Engine
{
	interface IGameData<T> : IEnumerable<T>
	{
		int Count { get; }
		T this[int idx] { get; set; }
		void RemoveAt(int idx);
	}

	static class GameData
	{
		public static IGameData<V> View<T, V>(this IGameData<T> self, Func<T, V> map) =>
			new GameDataView<T, V>(self, map);

		public static IGameData<V> View<T, V>(this IGameData<T> self, Func<T, V> map, Func<V, T, T> reverseMap) =>
			new GameDataView<T, V>(self, map, reverseMap);
	}
}
