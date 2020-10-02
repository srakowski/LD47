using Microsoft.Xna.Framework;

namespace LD47.Entities
{
	static class Dummy
	{
		public struct Data
		{
			public Vector2 Position;
		}

		public static Sprite ToSprite(Dummy.Data) =>
			new Sprite(
				GameContent.Texture2Ds.dummy,
				entity.Position,
				Color.White
			);
	}
}
