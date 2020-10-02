using System.Collections;
using System.Collections.Generic;

namespace LD47.Engine
{
	class GameData<T> : IGameData<T>
	{
		private readonly T[] _buffer;

		public GameData(int capacity)
		{
			_buffer = new T[capacity];
			Count = 0;
		}

		public int Count { get; private set; }

		public T this[int idx]
		{
			get => _buffer[idx];
			set => _buffer[idx] = value;
		}

		public void Add(T item)
		{
			_buffer[Count] = item;
			Count++;
		}

		public void RemoveAt(int idx)
		{
			Count--;
			_buffer[idx] = _buffer[Count];
			_buffer[Count] = default(T);
		}

		public IEnumerator<T> GetEnumerator() => new GameDataEnumerator<T>(this);

		IEnumerator IEnumerable.GetEnumerator() => new GameDataEnumerator<T>(this);
	}
}
