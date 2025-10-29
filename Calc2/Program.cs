//#define CALC_IF
//#define CALC_SWITCH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string expression = "22+33-44/2+8*3";
			//string expression = Console.ReadLine();
			expression = expression.Replace(".", ","); //Региональные настройки меняем точку на запятую
			expression = expression.Replace(" ", ""); //Удаляем лишние пробелы (меняем пробел на пустую строку)
			Console.WriteLine(expression);

			char[] operators = new char[] { '+', '-', '*', '/' }; //Это разделители
			string[] operands = expression.Split(operators); //Получаем строковое представление чисел
			double[] values = new double[operands.Length]; //Создаем массив для хранения чисел

			for (int i = 0; i < operands.Length; i++)
			{
				values[i] = Convert.ToDouble(operands[i]);
				Console.Write($"{values[i]}\t");
			}
			Console.WriteLine();

			char[] digits = "01234567890.".ToCharArray();
			/*for (int i = 0; i < digits.Length; i++)
			{
				Console.Write($"{digits[i]}\t");
			}
			//Console.WriteLine();*/

			string[] operations = expression.Split(digits);
			operations = operations.Where(operation => operation != "").ToArray(); //LINQ o => o != "" - это лямбда выражение. Удаляем пустые значения из operations
			for (int i = 0; i < operations.Length; i++)
			{
				Console.Write($"{operations[i]}\t");
			}
			Console.WriteLine();


				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == null) break;
					else if (operations[i] == "*")
					{
						values[i] *= values[i + 1];
						for (int j = i + 1; j < values.Length - 1; j++) values[j] = values[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
					else if (operations[i] == "/")
					{
						values[i] /= values[i + 1];
						for (int j = i + 1; j < values.Length - 1; j++) values[j] = values[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
					operations[operations.Length - 1] = null;
				}

				for (int i = 0; i < operations.Length; i++)
				{
					if (operations[i] == null) break;
					else if (operations[i] == "+")
					{
						values[i] += values[i + 1];
						for (int j = i + 1; j < values.Length - 1; j++) values[j] = values[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
					else if (operations[i] == "-")
					{
						values[i] -= values[i + 1];
						for (int j = i + 1; j < values.Length - 1; j++) values[j] = values[j + 1];
						for (int j = i; j < operations.Length - 1; j++) operations[j] = operations[j + 1];
					}
				}
			Console.WriteLine(values[0]);

#if CALC_IF
			if (expression.Contains("+"))
			{
				Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}");
			}
			else if (expression.Contains("-"))
			{
				Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}");
			}
			else if (expression.Contains("*"))
			{
				Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}");
			}
			else if (expression.Contains("/"))
			{
				Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}");
			}
			else Console.WriteLine("Error: No operation"); 
#endif

#if CALC_SWITCH
			switch (expression[expression.IndexOfAny(operators)])
			{
				case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}"); break;
				case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
				case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
				case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break;
			} 
#endif


		}
	}
}
