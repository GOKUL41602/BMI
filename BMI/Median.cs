using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
	class Median
	{

		static void Main()
		{

			int[] num1 = {1,2,3};
			int[] num2 = {4,5,6};
			int[] total;

			double median;

			int n = num1.Length + num2.Length;
			total = new int[n];

			for (int i = 0; i < num1.Length; i++)
			{
				total[i] = num1[i];
			}
			int j = num1.Length;
			int h = 0;
			while (h < num2.Length)
			{

				total[j] = num2[h];
				h++;
				j++;
			}
			Array.Sort(total);

			if (n % 2 == 0)
				median = (total[(n - 1) / 2] + total[n / 2]) / 2.0;
			
			else
				median = total[n / 2];
			Console.WriteLine($"The Median is {median}");


		}
	}
}
