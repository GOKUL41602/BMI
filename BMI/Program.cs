using System;

namespace BMI
{
	class Program
	{
		private static double height;
		private static double weight;
		private static double bmi;

		static void Main(string[] args)
		{
			Console.WriteLine("Enter Height in Meters:");
			height = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Enter Weight in KG:");
			weight = Convert.ToDouble(Console.ReadLine());

			bmi = weight / (height * height);
			
			Console.WriteLine($" Your bmi is {bmi}");

		}
	}
}
