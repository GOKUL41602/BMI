using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
	class Polymorphism

	{
		void shape(String shape, double input1)
		{
			if (shape == "Circle")
			{
				double area = 3.12 * (input1 * input1);
				Console.WriteLine("The Area of Circle is "+area);
			}

			else if (shape == "Square")
			{
				double area = (input1 * input1);
				Console.WriteLine("The Area of Square is " + area);
			}
		}

		void shape(String shape, double input1,double input2)
		{
			if (shape == "Rectangle")
			{
				double area = input1 * input2;
				Console.WriteLine("The Area of Rectangle is " + area);
			}

			else if (shape == "Triangle")
			{
				double area = (input1 * input2)/2;
				Console.WriteLine("The Area of Triangle is " + area);
			}
		}
		static void Main(string[] args)
		{
			string shapeType;
			double input1, input2;
			Console.WriteLine("Enter Shape Type: ");
			shapeType = Convert.ToString(Console.ReadLine());
			Polymorphism poly = new Polymorphism();
			if (shapeType == "Circle" || shapeType == "Square")
			{
				input1 = Convert.ToDouble(Console.ReadLine());
				poly.shape(shapeType, input1);
			}
			else if(shapeType == "Triangle" || shapeType == "Rectangle")
			{
				input1 = Convert.ToDouble(Console.ReadLine());
				input2 = Convert.ToDouble(Console.ReadLine());
				poly.shape(shapeType, input1,input2);
			}
			
		}
	}
}

