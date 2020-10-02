using System;
using System.Collections;
using System.Collections.Generic;

namespace LD47.Engine
{
	class GameDataView<T, V> : IGameData<V>
	{
		private readonly IGameData<T> _data;
		private readonly Func<T, V> _map;
		private readonly Func<V, T, T> _reverseMap;

		public GameDataView(
			IGameData<T> data,
			Func<T, V> map,
			Func<V, T, T> reverseMap = null)
		{
			_data = data;
			_map = map;
			_reverseMap =
				reverseMap ??
				new Func<V, T, T>((_, __) =>
					throw new NotImplementedException("no reverse map provided")
				);
		}

		public int Count => _data.Count;

		public V this[int idx]
		{
			get => _map(_data[idx]);
			set => _data[idx] = _reverseMap(value, _data[idx]);
		}

		public void RemoveAt(int idx) => _data.RemoveAt(idx);

		public IEnumerator<V> GetEnumerator() => new GameDataEnumerator<V>(this);

		IEnumerator IEnumerable.GetEnumerator() => new GameDataEnumerator<V>(this);
	}
}
