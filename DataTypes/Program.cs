#define DATA_TYPES
//#define CONSTANTS
//#define TYPE_CONVERSIONS
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
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвертка Boolean()");
			Console.WriteLine(bool.FalseString);//Неявно вызываются
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			bool rain = true;
			Console.WriteLine($"Дождь идет? - {rain}");
			Console.WriteLine(delimiter);

			/////////////////////////////////////////////////////////////////////////////////////////////
			Console.WriteLine
				(
$@"Тип данных char занимает {sizeof(char)} Байта памяти и принимает значения в диапазоне
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

			Console.WriteLine
				(
$@"short занимает {sizeof(short)} Байт памяти и принимает значения
в диапазоне от {short.MinValue} до {short.MaxValue}, класс обвертка {typeof(short)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"ushort занимает {sizeof(ushort)} Байт памяти и принимает значения
в диапазоне от {ushort.MinValue} до {ushort.MaxValue}, класс обвертка {typeof(ushort)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"int занимает {sizeof(int)} Байт памяти и принимает значения
в диапазоне от {int.MinValue} до {int.MaxValue}, класс обвертка {typeof(int)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"uint занимает {sizeof(uint)} Байт памяти и принимает значения
в диапазоне от {uint.MinValue} до {uint.MaxValue}, класс обвертка {typeof(uint)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"long занимает {sizeof(long)} Байт памяти и принимает значения
в диапазоне от {long.MinValue} до {long.MaxValue}, класс обвертка {typeof(long)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"ulong занимает {sizeof(ulong)} Байт памяти и принимает значения
в диапазоне от {ulong.MinValue} до {ulong.MaxValue}, класс обвертка {typeof(ulong)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"float занимает {sizeof(float)} Байта памяти и принимает значения
в диапазоне от {float.MinValue} до {float.MaxValue}, класс обвертка {typeof(float)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"double занимает {sizeof(double)} Байта памяти и принимает значения
в диапазоне от {double.MinValue} до {double.MaxValue}, класс обвертка {typeof(double)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine
				(
$@"decimal занимает {sizeof(decimal)} Байтов памяти и принимает значения
в диапазоне от {decimal.MinValue} до {decimal.MaxValue}, класс обвертка {typeof(decimal)}"
				);

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
