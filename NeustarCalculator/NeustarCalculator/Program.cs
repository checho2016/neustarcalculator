using System;

namespace NeustarCalculator
{
	public class Calculator
	{
		public int Add(int a, int b) { return a + b; }
	}

	public class Logger
	{
		public void Log(string message) { Console.WriteLine(message); }
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please type the first number and press enter");
			var firstNumber = 0;
			var firstNumberString = GetFirstNumberString(args);
			if (!Int32.TryParse(firstNumberString, out firstNumber))
			{
				FailedParsedStringHandling();
				return;
			}
			Console.WriteLine("Please type the second number and press enter");
			var secondNumber = 0;
			var secondNumberString = GetSecondNumberString(args);
			if (!Int32.TryParse(secondNumberString, out secondNumber))
			{
				FailedParsedStringHandling();
				return;
			}

			var calculator = Calculate();
			var logger = LogResult();
			logger.Log("The result is " + calculator.Add(firstNumber, secondNumber).ToString());
		}

		public static Calculator Calculate()
        {
			return new Calculator();
		}

		public static Logger LogResult()
        {
			return new Logger();
        }

		private static void FailedParsedStringHandling()
        {
			Console.WriteLine("The number is invalid");
        }

		private static string GetFirstNumberString(string[] args)
        {
			if(args != null && args.Length > 0)
            {
				return args[0];
            }
			else
            {
				return Console.ReadLine();
            }
        }

		private static string GetSecondNumberString(string[] args)
		{
			if (args != null && args.Length > 1)
			{
				return args[1];
			}
			else
			{
				return Console.ReadLine();
			}
		}
	}
}
