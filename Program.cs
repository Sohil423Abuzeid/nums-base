using System;

namespace nums_bases
{
	class Program
	{
		static int intpow(int bas, int pow)
		{
			int ans = 1;
			for (int i = 0; i < pow; i++)
				ans *= bas;
			return ans;
		}
		static int dec(string num, int bas)
		{
			int i = 0;
			int sum = 0;
			for (int o = num.Length - 1; o >= 0; o--)
			{

				switch (num[o])
				{
					case '0': break;
					case '1': sum += (1 * (intpow(bas, i))); break;
					case '2': sum += (2 * (intpow(bas, i))); break;
					case '3': sum += (3 * (intpow(bas, i))); break;
					case '4': sum += (4 * (intpow(bas, i))); break;
					case '5': sum += (5 * (intpow(bas, i))); break;
					case '6': sum += (6 * (intpow(bas, i))); break;
					case '7': sum += (7 * (intpow(bas, i))); break;
					case '8': sum += (8 * (intpow(bas, i))); break;
					case '9': sum += (9 * (intpow(bas, i))); break;
					case 'A': case 'a': sum += (10 * (intpow(bas, i))); break;
					case 'B': case 'b': sum += (11 * (intpow(bas, i))); break;
					case 'C': case 'c': sum += (12 * (intpow(bas, i))); break;
					case 'D': case 'd': sum += (13 * (intpow(bas, i))); break;
					case 'E': case 'e': sum += (14 * (intpow(bas, i))); break;
					case 'F': case 'f': sum += (15 * (intpow(bas, i))); break;
				}
				i++;
			}
			return sum;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello sir enter number");
			string num = Console.ReadLine();
			Console.WriteLine("enter base");
			int bas = int.Parse(Console.ReadLine());
			Console.WriteLine(dec(num, bas));
			Console.ReadKey();
			Console.WriteLine("by : Smile Man ^_^\n team : Red Planet");
		}
	}
}
