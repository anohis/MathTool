using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathTool.Vector;

namespace MathTool.Line
{
	public static class LineTool
	{
		public static Vector3 GetVector(this Line l)
		{
			return l.PointA.Sub(l.PointB);
		}
		public static double Len(this Line l)
		{
			return l.GetVector().Len();
		}
		public static bool IsCross(this Line l1,Line l2)
		{
			var vA1A2 = l2.PointA.Sub(l1.PointA);
			var vA1B2 = l2.PointB.Sub(l1.PointA);
			var vB1A2 = l2.PointA.Sub(l1.PointB);
			var vB1B2 = l2.PointB.Sub(l1.PointB);

			var sin1 = vA1A2.Sin(vA1B2);
			var sin2 = vB1A2.Sin(vB1B2);
			if (sin1 * sin2 > 0)
			{
				return false;
			}

			var vA2A1 = vA1A2.Mul(-1);
			var vA2B1 = vB1A2.Mul(-1);
			var vB2A1 = vA1B2.Mul(-1);
			var vB2B1 = vB1B2.Mul(-1);

			var sin3 = vA2A1.Sin(vA2B1);
			var sin4 = vB2A1.Sin(vB2B1);
			if (sin3 * sin4 > 0)
			{
				return false;
			}

			return true;
		}
	}
}
