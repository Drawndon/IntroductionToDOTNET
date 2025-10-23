using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{


			do
			{
				Console.Write("Введите арифметическое выражение ('q' to quit): ");
				string expression = Console.ReadLine();
				if (expression.Contains('q') || expression.Contains('Q')) { Console.WriteLine("Bye"); break; }
				expression = expression.Replace(',', '.');


				char[] delimiters = new char[] { '+', '-', '*', '/' };
				string[] numbers = expression.Split(delimiters);


				double a = Convert.ToDouble(numbers[0]);
				double b = Convert.ToDouble(numbers[1]);


				if (expression.Contains('+')) Console.WriteLine($"{a} + {b} = {a + b}");
				else if (expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
				else if (expression.Contains('*')) Console.WriteLine($"{a} * {b} = {a * b}");
				else if (expression.Contains('/'))
				{
					if (b == 0) Console.WriteLine("Try again. Division by zero is prohibited");
					else Console.WriteLine($"{a} / {b} = {a / b}");
				}
			} while (true);



		}
	}
}