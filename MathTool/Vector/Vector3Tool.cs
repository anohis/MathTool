namespace MathTool.Vector
{
	public static class Vector3Tool
	{
		public static Vector3 Add(this Vector3 a, Vector3 b)
		{
			a.X += b.X;
			a.Y += b.Y;
			a.Z += b.Z;
			return a;
		}
		public static Vector3 Add(this Vector3 a, double b)
		{
			a.X += b;
			a.Y += b;
			a.Z += b;
			return a;
		}
		public static Vector3 Sub(this Vector3 a, Vector3 b)
		{
			a.X -= b.X;
			a.Y -= b.Y;
			a.Z -= b.Z;
			return a;
		}
		public static Vector3 Sub(this Vector3 a, double b)
		{
			a.X -= b;
			a.Y -= b;
			a.Z -= b;
			return a;
		}
		public static Vector3 Mul(this Vector3 a, double b)
		{
			a.X *= b;
			a.Y *= b;
			a.Z *= b;
			return a;
		}
		public static Vector3 Div(this Vector3 a, double b)
		{
			a.X /= b;
			a.Y /= b;
			a.Z /= b;
			return a;
		}
		public static double Dot(this Vector3 a, Vector3 b)
		{
			double sum = 0;
			sum += a.X * b.X;
			sum += a.Y * b.Y;
			sum += a.Z * b.Z;
			return sum;
		}
		public static double Sin(this Vector3 a, Vector3 b)
		{
			return (a.X * b.Y - b.X * a.Y) / (a.Len() * b.Len());
		}
		public static double Len(this Vector3 a)
		{
			double sum = a.X * a.X + a.Y * a.Y + a.Z * a.Z;
			return System.Math.Pow(sum, 0.5f);
		}
	}
}
