using LD47.Systems;
using Microsoft.Xna.Framework;

namespace LD47.Entities
{
	static class Dummy
	{
		public struct Data
		{
			public Vector2 Position;
		}

		public static Sprite ToSprite(Data d) =>
			new Sprite(
				GameContent.Texture2Ds.dummy,
				d.Position,
				Color.White
			);
	}
}
