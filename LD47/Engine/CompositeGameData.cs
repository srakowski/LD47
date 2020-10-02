using System.Collections;
using System.Collections.Generic;

namespace LD47.Engine
{
	class CompositeGameData<T> : IGameData<T>
	{
		private readonly IGameData<T>[] _data;

		public CompositeGameData(params IGameData<T>[] data)
		{
			_data = data;
		}

		public int Count
		{
			get
			{
				var count = 0;
				for (var i = 0; i < _data.Length; i++)
				{
					count += _data[i].Count;
				}
				return count;
			}
		}

		public T this[int idx]
		{
			get
			{
				CalculateIndex(idx, out var dataIdx, out var i);
				return _data[dataIdx][i];
			}
			set
			{
				CalculateIndex(idx, out var dataIdx, out var i);
				_data[dataIdx][i] = value;
			}
		}

		private void CalculateIndex(int idx, out int dataIdx, out int i)
		{
			dataIdx = 0;
			i = idx;
			for (; dataIdx < _data.Length && i >= _data[dataIdx].Count; dataIdx++)
			{
				i -= _data[dataIdx].Count;
			}
		}

		public void RemoveAt(int idx)
		{
			CalculateIndex(idx, out var dataIdx, out var i);
			_data[dataIdx].RemoveAt(i);
		}

		public IEnumerator<T> GetEnumerator() => new GameDataEnumerator<T>(this);

		IEnumerator IEnumerable.GetEnumerator() => new GameDataEnumerator<T>(this);
	}
}
