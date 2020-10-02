using LD47.Systems;
using Microsoft.Xna.Framework;

namespace LD47
{
	class TbdGame : Game
	{
		private readonly GraphicsDeviceManager _graphics;

		public TbdGame()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
			
			State = new GameState();

			State.Dummies.Add(new Entities.Dummy.Data
			{
				Position = new Vector2(10, 10)
			});

			new Input(this);
			new Rendering(this);
		}

		public GameState State { get; }
	}
}
