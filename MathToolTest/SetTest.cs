using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathTool.Collection;

namespace MathToolTest
{
	static class SetTest
	{
		public static void SubSetTest()
		{
			Set set = new Set();
			set.Elements.Add(1);
			set.Elements.Add(3);
			set.Elements.Add(5);
			set.Elements.Add(7);
			set.Elements.Add(9);

			var list = set.GetSubSet(3);
			foreach (var s in list)
			{
				Console.WriteLine(s);
			}
		}
	}
}
