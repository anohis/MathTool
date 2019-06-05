using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool.Collection
{
	public sealed class Set
	{
		public HashSet<int> Elements = new HashSet<int>();

		public override string ToString()
		{
			string str = "{";
			foreach (var e in Elements)
			{
				str += string.Format("{0},", e);
			}
			str += "}";
			return str;
		}
	}
}
