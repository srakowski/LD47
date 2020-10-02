using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace LD47
{
	public static class GameContent
	{
		public static class Effects
		{
			public static Effect[] Load(ContentManager content)
			{
				return new Effect[]
				{
				};
			}
		}
		public static class Songs
		{
			public static Song[] Load(ContentManager content)
			{
				return new Song[]
				{
				};
			}
		}
		public static class SoundEffects
		{
			public const int dummy = 0; // "SoundEffect/dummy"
			public static SoundEffect[] Load(ContentManager content)
			{
				return new SoundEffect[]
				{
					content.Load<SoundEffect>("SoundEffect/dummy"),
				};
			}
		}
		public static class SpriteFonts
		{
			public static SpriteFont[] Load(ContentManager content)
			{
				return new SpriteFont[]
				{
				};
			}
		}
		public static class Texture2Ds
		{
			public const int dummy = 0; // "Texture2D/dummy"
			public const int dummy2 = 1; // "Texture2D/dummy2"
			public static Texture2D[] Load(ContentManager content)
			{
				return new Texture2D[]
				{
					content.Load<Texture2D>("Texture2D/dummy"),
					content.Load<Texture2D>("Texture2D/dummy2"),
				};
			}
		}
	}
}
