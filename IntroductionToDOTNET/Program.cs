//IntroductionToDOTNET
#define CONSOLE
//#define CLASS_WORK
//#define SQUARE
//#define TRIANGLE_1
//#define TRIANGLE_2
//#define TRIANGLE_3
//#define TRIANGLE_4
//#define RHOMBUS
//#define CHESS
//#define HARD_CHESS
using System; //#include
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Hello .NET\t");
            Console.WriteLine();
            Console.Title = "Introduction to .NET"; //Заголовок консоли, у меня не работает
            Console.Beep(37, 2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetConsoleCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another position");
            Console.ResetColor(); 
#endif
#if CLASS_WORK
			Console.Write("Введите Ваше имя: ");
			string firstName = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine(lastName + " " + firstName + " " + age); //Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age)); //Форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}"); //Интерполяция строк  
#endif


			Console.Write("Введите число: "); int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
#if SQUARE
			Console.WriteLine("1) SQUARE");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write((j == n - 1 ? "*" : "* "));
				Console.WriteLine();
			}
			Console.WriteLine();
#endif

#if TRIANGLE_1
			Console.WriteLine("2) TRIANGLE_1");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++)
				{

					Console.Write((j == i ? "*" : "* "));
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif // TRIANGLE_1

#if TRIANGLE_2
		Console.WriteLine("3) TRIANGLE_2");
		for (int i = n; i > 0; i--)
		{
			for (int j = i; j > 0; j--)
				Console.Write((j == 1 ? "*" : "* "));
			Console.WriteLine();
		}
		Console.WriteLine();
#endif // TRIANGLE_2

#if TRIANGLE_3
		Console.WriteLine("4) TRIANGLE_3");
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < i; j++) Console.Write("  ");
			for (int j = i; j < n; j++) Console.Write("* ");
			Console.WriteLine();
		}
		Console.WriteLine();
#endif // TRIANGLE_3

#if TRIANGLE_4
		Console.WriteLine("5) TRIANGLE_4");
		for (int i = 0; i < n; i++)
		{
			for (int j = i; j < n - 1; j++) Console.Write("  ");
			for (int j = 0; j <= i; j++) Console.Write("* ");
			Console.WriteLine();
		}
		Console.WriteLine();
#endif // TRIANGLE_4

#if RHOMBUS
		Console.WriteLine("6) RHOMBUS");
			for (int i = 0; i < n * 2; i++)
			{
				for (int j = 0; j < n * 2; j++)
				{
					if (i + n == j || j + n == i) Console.Write("\\");
					else if (i == n - 1 - j || j - n == 2 * n - 1 - i) Console.Write("/");
					else Console.Write(" ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif // RHOMBUS

#if CHESS

			Console.WriteLine("CHESS");
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				//if ((i + j) % 2 == 0) Console.Write << "+ "; else Console.Write << "- ";
				if (i % 2 == j % 2) Console.Write("+ "); else Console.Write("- ");
			}
			Console.WriteLine();
		}
			Console.WriteLine();
#endif // CHESS

#if HARD_CHESS
Console.WriteLine("7) HARDCHESS");
	Console.Write("┌");
	for (int i = 1; i < (2 * n * n - n + 1); i++)
	{
		Console.Write("-");
	}
	Console.Write("┐");
	Console.WriteLine();
	int counter = 0;
	for (int i = 0; i < n; i++)
	{
		if (i % 2 == 0)
		{
			for (int m = 0; m < n; m++)
			{
				Console.Write("|");
				for (int j = 0; j < n; j++)
				{
					if (j % 2 == 0)
					{
						for (int k = 0; k < n; k++)
						{
							Console.Write((k == n - 1 ? "*" : "* "));
							counter++;
						}
					}
					else
					{
						for (int l = 0; l < n; l++)
						{
							Console.Write((l == n - 1 ? " " : "  "));
							counter++;
						}
					}
				}
			if (counter == n * n) Console.Write("|");
			Console.WriteLine();
			counter = 0;
			}
		}
		else
		{
			for (int m = 0; m < n; m++)
			{
				Console.Write("|");
				for (int j = 0; j < n; j++)
				{
					if (j % 2 == 0)
					{
						for (int k = 0; k < n; k++)
						{
							Console.Write((k == n - 1 ? " " : "  "));
							counter++;
						}
					}
					else
					{
						for (int k = 0; k < n; k++)
						{
							Console.Write((k == n - 1 ? "*" : "* "));
							counter++;
						}
					}
				}
			if (counter == n * n) Console.Write("|");
			Console.WriteLine();
			counter = 0;
			}
		}
	}
	Console.Write("└");
	for (int i = 1; i < (2 * n * n - n + 1); i++)
	{
		Console.Write("-");
	}
	Console.Write("┘");
	Console.WriteLine();
#endif


		}
	}
}
