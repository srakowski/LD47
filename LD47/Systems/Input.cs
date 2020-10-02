using LD47.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using GP = Microsoft.Xna.Framework.Input.GamePad;
using KB = Microsoft.Xna.Framework.Input.Keyboard;
using MS = Microsoft.Xna.Framework.Input.Mouse;

namespace LD47.Systems
{
	class Input : GameComponent
	{
		private InputStates<KeyboardState> _keyboard;
		private InputStates<MouseState> _mouse;
		private InputStates<GamePadState>[] _gamePads;

		public Input(TbdGame game) : base(game)
		{
			game.Components.Add(this);
			_gamePads = new InputStates<GamePadState>[4];
		}

		public override void Update(GameTime gameTime)
		{
			RefreshInputState();

			if (_keyboard.Current.IsKeyDown(Keys.Escape))
				Game.Exit();
		}

		private void RefreshInputState()
		{
			_keyboard = _keyboard.Next(KB.GetState());
			_mouse = _mouse.Next(MS.GetState());
			UpdateGamePadState(PlayerIndex.One);
			UpdateGamePadState(PlayerIndex.Two);
			UpdateGamePadState(PlayerIndex.Three);
			UpdateGamePadState(PlayerIndex.Four);
		}

		private void UpdateGamePadState(PlayerIndex playerIndex)
		{
			_gamePads[(int)playerIndex] = _gamePads[(int)playerIndex].Next(GP.GetState(playerIndex));
		}
	}
}
