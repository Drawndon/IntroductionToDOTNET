using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			Random rand = new Random();
			int x = rand.Next(Console.WindowWidth);
			int y = rand.Next(Console.WindowHeight);
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			ConsoleKey key;
			do
			{
				Console.Clear();
				Console.SetCursorPosition(x, y);
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				
				Console.WriteLine("@");
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W: y--; break;
					case ConsoleKey.DownArrow:
					case ConsoleKey.S: y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A: x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D: x++; break;
				}
				if (
					x == 0 || y == 0 ||
					x == Console.WindowWidth || y == Console.WindowHeight
					) Console.Beep();
				if (x == 0) x = 1;
				if (x == Console.WindowWidth) x = Console.WindowWidth - 1;
				if (y == 0) y = 1;
				if (y == Console.WindowHeight) y = Console.WindowHeight - 1;
			} while (key != ConsoleKey.Escape);
		}
	}
}