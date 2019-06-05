using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool.Collection
{
	public static class SetTool
	{
		public static Set ToSet(this IEnumerable<int> list)
		{
			var set = new Set();

			foreach (var e in list)
			{
				set.Elements.Add(e);
			}

			return set;
		}

		public static IEnumerable<Set> GetSubSet(this Set set, int elementCount)
		{
			var list = new List<Set>();

			if(elementCount >0 && elementCount <= set.Elements.Count)
			{
				int[] indexList = new int[elementCount];
				for (int i = 0; i < elementCount; i++)
				{
					indexList[i] = i;
				}

				GetSubSet(set.Elements, list, indexList);
			}

			return list;
		}

		private static void GetSubSet(IEnumerable<int> elementList, List<Set> result, int[] indexList)
		{
			Set set = new Set();

			for (int i = 0; i < indexList.Length; i++)
			{
				var index = indexList[i];
				set.Elements.Add(elementList.ElementAt(index));
			}

			result.Add(set);

			var hasNext = false;
			var maxIndex = elementList.Count() - 1;
			var lastIndexIndex = indexList.Length - 1;

			for (int i = lastIndexIndex; i >= 0; i--)
			{
				var index = indexList[i];
				if (index < (maxIndex - (lastIndexIndex - i)))
				{
					indexList[i]++;
					for (int j = i + 1; j < indexList.Length; j++)
					{
						indexList[j] = indexList[i] + (j - i);
					}
					hasNext = true;
					break;
				}
			}

			if (hasNext)
			{
				GetSubSet(elementList, result, indexList);
			}
		}
	}
}
