using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
	abstract class Average
	{
		public abstract void average();
	}
	class AbstractClass : Average
	{
		static int[] subjectMarks;
		int totalAverage = 0;
		static void Main(string[] args)
		{
			int total = 0;
			Console.WriteLine("Enter the Total no of Subjects : ");
			 total = Convert.ToInt32(Console.ReadLine());
			subjectMarks = new int[total];
			for (int i = 0; i < total; i++)
			{
				subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
			}
			AbstractClass subjectAverage = new AbstractClass();
			subjectAverage.average();
 		}
		public override void average()
		{
			int totalSubjects = subjectMarks.Length;
			int totalMarks = 0;
			for (int i=0;i<totalSubjects;i++)
			{
				totalMarks += subjectMarks[i];
			}
			totalAverage = totalMarks / totalSubjects;
			Console.WriteLine($"The Average for the given marks is {totalAverage}");
		}
	}
}
