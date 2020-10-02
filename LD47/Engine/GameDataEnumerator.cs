using System.Collections;
using System.Collections.Generic;

namespace LD47.Engine
{
	struct GameDataEnumerator<T> : IEnumerator<T>
	{
		private IGameData<T> _gameData;
		private int _index;

		public GameDataEnumerator(IGameData<T> gameData)
		{
			_gameData = gameData;
			_index = -1;
		}

		public T Current => _gameData[_index];

		object IEnumerator.Current => _gameData[_index];

		public void Dispose() { }

		public bool MoveNext()
		{
			_index++;
			return _index < _gameData.Count;
		}

		public void Reset()
		{
			_index = -1;
		}
	}
}
