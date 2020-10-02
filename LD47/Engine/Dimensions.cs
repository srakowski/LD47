using Microsoft.Xna.Framework;

namespace LD47.Engine
{
	struct Dimensions
	{
		public int Width;
		public int Height;

		public Dimensions(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public Dimensions(Point point)
			: this(point.X, point.Y)
		{
		}

		public Dimensions(Vector2 vector)
			: this(vector.ToPoint())
		{
		}

		public Point ToPoint() => new Point(Width, Height);

		public Vector2 ToVector2() => new Vector2(Width, Height);

		public Rectangle ToRectangle() => ToRectangle(0, 0);

		public Rectangle ToRectangle(Point point) => ToRectangle(point.X, point.Y);

		public Rectangle ToRectangle(int x, int y) => new Rectangle(x, y, Width, Height);

		public static Dimensions operator -(Dimensions d1, Dimensions d2)
		{
			return new Dimensions(d1.Width - d2.Width, d1.Height - d2.Height);
		}

		public static Dimensions operator +(Dimensions d1, Dimensions d2)
		{
			return new Dimensions(d1.Width + d2.Width, d1.Height + d2.Height);
		}

		public static Dimensions operator *(Dimensions d, int scale)
		{
			return new Dimensions(d.Width * scale, d.Height * scale);
		}

		public static bool operator ==(Dimensions a, Dimensions b) => a.Equals(b);

		public static bool operator !=(Dimensions a, Dimensions b) => !a.Equals(b);

		public override bool Equals(object obj) => (obj is Dimensions dimensions) && Equals(dimensions);

		public bool Equals(Dimensions other) => ((Width == other.Width) && (Height == other.Height));

		public override int GetHashCode()
		{
			unchecked
			{
				return (17 * 23 + Width.GetHashCode()) * 23 + Height.GetHashCode();
			}
		}
	}
}
