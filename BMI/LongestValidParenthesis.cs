using System;
using System.Collections.Generic;

namespace BMI
{
	class LongestValidParenthesis
	{
		static void Main() {

			Console.WriteLine("Enter the Parenthesis Order : ");
			string input = Convert.ToString(Console.ReadLine());
			int max_length = 0;
			Stack<int> checkParanthesis = new Stack<int>();
			checkParanthesis.Push(-1);
			
			for (int i = 0; i < input.Length; i++)
			{
				char c = input[i];
				if (c=='(')
				{
					checkParanthesis.Push(i);
				}
				else
				{
					checkParanthesis.Pop();
					if(checkParanthesis.Count==0)
					{
						checkParanthesis.Push(i);
					}
					else
					{
						int current_length = i-checkParanthesis.Peek();
						max_length = Math.Max(max_length,current_length);
					}
				}
			}
			Console.WriteLine($"The Longest Valid Parenthesis is {max_length}");
		}
	}
}
