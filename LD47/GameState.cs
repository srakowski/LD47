using LD47.Engine;
using LD47.Entities;

namespace LD47
{
	class GameState
	{
		public GameState()
		{
			Dummies = new GameData<Dummy.Data>(100);
		}

		public GameData<Dummy.Data> Dummies { get; }
	}
}
