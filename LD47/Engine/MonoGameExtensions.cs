using Microsoft.Xna.Framework;
using System;

namespace LD47.Engine
{
	static class MonoGameExtensions
	{
		public static Vector2 FromAngle(float radians) => new Vector2((float)Math.Cos(radians), (float)Math.Sin(radians));

		public static float ToAngle(this Vector2 vector) => (float)Math.Atan2(vector.X, -vector.Y);

		public static void Deconstruct(this Vector2 vector, out float x, out float y)
		{
			x = vector.X;
			y = vector.Y;
		}

		public static Dimensions ToDimensions(this Vector2 vector2) => new Dimensions((int)vector2.X, (int)vector2.Y);

		public static void Deconstruct(this Rectangle rectangle, out int x, out int y, out int width, out int height)
		{
			x = rectangle.X;
			y = rectangle.Y;
			width = rectangle.Width;
			height = rectangle.Height;
		}

		public static void Deconstruct(this Rectangle rectangle, out Point point, out Dimensions dimensions)
		{
			point = rectangle.Location;
			dimensions = rectangle.GetDimensions();
		}

		public static Dimensions GetDimensions(this Rectangle rectangle) => new Dimensions(rectangle.Width, rectangle.Height);

		public static void Deconstruct(this Point point, out int x, out int y)
		{
			x = point.X;
			y = point.Y;
		}

		public static Dimensions ToDimensions(this Point point) => new Dimensions(point.X, point.Y);
	}
}
