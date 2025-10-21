//#define DATA_TYPES
//#define CONSTANTS
#define TYPE_CONVERSIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimiter = "\n---------------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертак Boolean()");
			Console.WriteLine(bool.FalseString);//Неявно вызываются
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			bool rain = true;
			Console.WriteLine($"Дождь идет? - {rain}");
			Console.WriteLine(delimiter);

			/////////////////////////////////////////////////////////////////////////////////////////////
			Console.WriteLine
				(
$@"Тип данных char занимает {sizeof(char)} Байтов памяти и принимает значения в диапазоне
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс обвертка - {typeof(char)}"
				);
			//@"RAW-строка" игнорируются спецсимволы (escape -последовательности)
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
@"RAW-строка - игнорирует все специальные символы и Esc-последовательности \t\n,
т.е воспринимается как есть 'as-is'"
				);

			Console.WriteLine(delimiter);

			/////////////////////////////////////////////////////////////////////////////////////////////
			Console.WriteLine
				(
$@"byte занимает {sizeof(byte)} Байт памяти и принимает значения
в диапазоне от {byte.MinValue} до {byte.MaxValue}, класс обвертка {typeof(byte)}"
				);


			Console.WriteLine(delimiter);
			/////////////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine
				(
$@"sbyte занимает {sizeof(sbyte)} Байт памяти и принимает значения
в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue}, класс обвертка {typeof(sbyte)}"
				);

			Console.WriteLine(delimiter);

			Console.WriteLine($"float занимает {sizeof(float)} Байта памяти");

			Console.WriteLine(delimiter);

			Console.WriteLine($@"decimal занимает {sizeof(decimal)} Байтов памяти");

			decimal a = 1;
			a /= 3;
			Console.WriteLine(a);
			a *= 3;
			Console.WriteLine(a); //decimal не будет округлять до 1, а double округлит до 1
			Console.WriteLine(delimiter);
			/////////////////////////////////////////////////////////////////////////////////////////////

#endif
#if CONSTANTS
			Console.WriteLine("Hello".GetType());
			//Console.WriteLine(typeof(/*"Hello"*/)); typeof принимает типы
			Console.WriteLine(5.0.GetType());
#endif
#if TYPE_CONVERSIONS
			int n = 5;
			while (n-- > 0)
			{ Console.WriteLine(n); }
			Console.WriteLine(delimiter);
			//ushort b = (ushort)-2;
			//ConsoleWriteLine(b);
			double c = 2.2;
			short b = (short)c;
			Console.WriteLine(b);
			bool rain = Convert.ToBoolean("True");
			Console.WriteLine(rain);
			rain = bool.Parse("FaLsE");
			Console.WriteLine(rain);

#endif


		}
	}
}
