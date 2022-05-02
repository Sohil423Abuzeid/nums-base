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
		static string inba(string num , int bas)
		{
			int asd = int.Parse(num); 
			string sum = "";
			int baqy = 0 ;
			string baqy2 = "";
			for (  ; asd > 0 ; )
			{
				baqy = asd % bas;
				if (baqy == 0 || baqy == 1 || baqy == 2 || baqy == 3 || baqy == 4 || baqy == 5 || baqy == 6 || baqy == 7 || baqy == 8 || baqy == 9)
					baqy2 = Convert.ToString(baqy);
				else if (baqy == 10) baqy2 = "A";
				else if (baqy == 11) baqy2 = "B";
				else if (baqy == 12) baqy2 = "C";
				else if (baqy == 13) baqy2 = "D";
				else if (baqy == 14) baqy2 = "E";
				else if (baqy == 15) baqy2 = "F";

				asd /= bas;
				sum = baqy2 + sum;
			}
			return sum;
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
			Console.WriteLine("imprtant **********************\n 1- intger numbers omly \n 2- postive \n 3- convert only use + and the thecond number 00000\nHello sir enter number");

			for (int i = 5; i > 0; i++)
			{


				string num = Console.ReadLine();
				Console.WriteLine("enter base");
				int bas = int.Parse(Console.ReadLine());
				Console.WriteLine("enter thecond number");
				string num2 = Console.ReadLine();
				Console.WriteLine("enter thecond base");
				int bas2 = int.Parse(Console.ReadLine());
				Console.WriteLine("enter target base");
				int bas3 = int.Parse(Console.ReadLine());
				Console.WriteLine("-   or    +     or   *   or      /");
				char a = char.Parse(Console.ReadLine());
				switch (a)
				{
					case '+': Console.WriteLine(inba((Convert.ToString((dec(num, bas) + dec(num2, bas2)))), bas3)); break;
					case '-': Console.WriteLine(inba((Convert.ToString((dec(num, bas) - dec(num2, bas2)))), bas3)); break;
					case '*': Console.WriteLine(inba((Convert.ToString((dec(num, bas) * dec(num2, bas2)))), bas3)); break;
					case '/': Console.WriteLine(inba((Convert.ToString((dec(num, bas) / dec(num2, bas2)))), bas3)); break;

				}
				Console.WriteLine("again ? y / n");
				char asdf = char.Parse(Console.ReadLine());
				if (asdf == 'y' || asdf == 'Y')
					Console.WriteLine("entre first number");
				else if (asdf == 'N' || asdf == 'n')
					break;
			}
			
			Console.WriteLine("by : Smile Man ^_^\n team : Red Planet");
Console.ReadKey();
		}
	}
}

