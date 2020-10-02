using LD47.Engine;
using LD47.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LD47.Systems
{
	struct Sprite
	{
		public int TextureId;
		public Vector2 Position;
		public Color Color;
		public float Rotation;
		public float Scale;
		public SpriteEffects SpriteEffects;
		public float LayerDepth;

		public Sprite(
			int textureId,
			Vector2 position,
			Color color,
			float rotation = 0f,
			float scale =  1f,
			SpriteEffects spriteEffects = SpriteEffects.None,
			float layerDepth = 0f)
		{
			TextureId = textureId;
			Position = position;
			Color = color;
			Rotation = rotation;
			Scale = scale;
			SpriteEffects = spriteEffects;
			LayerDepth = layerDepth;
		}
	}

	class Rendering : DrawableGameComponent
	{
		private SpriteBatch _sb;
		private IGameData<Sprite> _sprites;
		private Texture2D[] _textures;

		public Rendering(TbdGame game) : base(game)
		{
			game.Components.Add(this);
			_sprites = new CompositeGameData<Sprite>(
				game.State.Dummies.View(Dummy.ToSprite)
			);
		}

		public override void Initialize()
		{
			base.Initialize();
			_sb = new SpriteBatch(Game.GraphicsDevice);
		}

		protected override void LoadContent()
		{
			_textures = GameContent.Texture2Ds.Load(Game.Content);
		}

		public override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			_sb.Begin();

			foreach (var s in _sprites)
			{
				var texture = _textures[s.TextureId];

				_sb.Draw(
					texture,
					s.Position,
					null,
					s.Color,
					s.Rotation,
					Vector2.Zero,
					s.Scale,
					s.SpriteEffects,
					s.LayerDepth
					);
			}

			_sb.End();
		}
	}
}
