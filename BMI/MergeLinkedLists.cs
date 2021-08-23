using System;
using System.Collections.Generic;

namespace BMI
{
	class MergeLinkedLists
	{
		static void Main() {

			LinkedList<int> ll1 = new LinkedList<int>();
			LinkedList<int> ll2 = new LinkedList<int>();
			List<int> resultantList = new List<int>();
			LinkedList<int> finalList = new LinkedList<int>();
			LinkedList<LinkedList<int>> ll3 = new LinkedList<LinkedList<int>>();

			ll1.AddLast(1);
			ll1.AddLast(2);
			ll1.AddLast(4);

			ll2.AddLast(1);
			ll2.AddLast(4);
			ll2.AddLast(5);

			ll3.AddLast(ll1);
			ll3.AddLast(ll2);

			LinkedList<LinkedList<int>>.Enumerator em = ll3.GetEnumerator();

			while(em.MoveNext())
			{
				LinkedList<int> listValue=em.Current;

				LinkedList<int>.Enumerator em1 = listValue.GetEnumerator();

				while(em1.MoveNext())
				{
					int value = em1.Current;
					resultantList.Add(value);
				}
			}
			resultantList.Sort();
			
			for(int i=0;i<resultantList.Count;i++)
			{
				finalList.AddLast(resultantList[i]);
			}

			foreach(int value in finalList)
			{
				Console.WriteLine(value);
			}
		}
	}
}
