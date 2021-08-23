using System;
using System.Collections.Generic;
using System.Text;

namespace BMI
{
	class Message
	{
		public void message(string _emailId)
		{
			Console.WriteLine($"Email is sending...  to {_emailId}");
		}
	}

	 class Email : Message
	{
		static void Main(string[] args)
		{
			string emailId = Convert.ToString(Console.ReadLine());
			Message newEmail = new Message();
			newEmail.message(emailId);
		}
	}
}
