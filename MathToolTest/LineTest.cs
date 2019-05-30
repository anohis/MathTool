using System;
using MathTool.Line;
using MathTool.Vector;

namespace MathToolTest
{
	static class LineTest
	{
		public static void LineIsCrossTest()
		{
			Line line1 = new Line()
			{
				PointA = new Vector3(0, 0, 0),
				PointB = new Vector3(1, 1, 0)
			};

			Line line2 = new Line()
			{
				PointA = new Vector3(1, 0, 0),
				PointB = new Vector3(0, 1, 0)
			};

			Console.WriteLine("LineIsCrossTest : {0}", line1.IsCross(line2));
		}
	}
}
