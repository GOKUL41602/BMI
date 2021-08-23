using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
	class OddNaturalNumbers
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the range of Odd Number to be calculated : ");
			int n = Convert.ToInt32(Console.ReadLine());
			int i = 0;
			int sum = 0;
			int no = 1;
			while (i < n)
			{
				sum = sum + no;
				no = no + 2;
				i++;
			}
			Console.WriteLine("The Total Sum is "+sum);
		}
	}
}

