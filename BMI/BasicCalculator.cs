using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace BMI
{
	interface Calculator { 
		public void add();
		public void sub();
		public void multiply();
		public void divide();
	}
	class Functions : Calculator

	{
		double number1, number2;

		public Functions()
		{
		}

		public Functions(double number1,double number2)
		{
			this.number1 = number1;
			this.number2 = number2;
			
		}

		public void add()
		{
			Console.WriteLine($"The Addition of two numbers is : {number1 +number2}");
		}

		public void divide()
		{
			if (number1 < number2)
			{
				Console.WriteLine($"The Division of two numbers is : 0");
			}
			else
			{
				Console.WriteLine($"The Division of two numbers is : {number1 / number2}");
			}
		}

		public void multiply()
		{
			Console.WriteLine($"The Multiplication of two numbers is : {number1 * number2}");
		}

		public void sub()
		{
			Console.WriteLine($"The Substraction of two numbers is : {number1 - number2}");
		}
		private void demo()
		{

		}
	}
	class BasicCalculator
	{

		static double number1, number2;

		static void Main() {

			List<string> phrases = new List<string>() { "an apple a day", "the quick brown fox" };

			var query = from word in phrases select word;

			foreach (string s in query)
				Console.WriteLine(s);
			Console.ReadLine();

		}
	}
}
