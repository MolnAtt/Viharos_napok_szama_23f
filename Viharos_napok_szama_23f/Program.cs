using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viharos_napok_szama_23f
{
	internal class Program
	{
		static int[] Beolvasas()
		{
			string elso_sor = Console.ReadLine(); // elso_sor = "10 3"
			string[] elso_sor_tombje = elso_sor.Split(' '); // elso_sor_tombje = ["10", "3"]
			int N = Convert.ToInt32(elso_sor_tombje[0]); // N = 10
			int K = int.Parse(elso_sor_tombje[1]); // K = 3, ez is ugyanúgy számmá alakít!

			int[] t = new int[N]; // t = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

			for (int i = 0; i < N; i++) // ez most 10-szer fog lefutni!
			{
				string sor = Console.ReadLine(); // sor = "105"
				t[i] = Convert.ToInt32(sor);
			}
			// mire a végére érünk: t = [50, 40, 0, 5, 0, 105, 70, 90, 100, 120]
			return t;
		}

		static int Feldolgozas(int[] t)
		{
			int result = 0;
			for (int i = 0; i < t.Length; i++)
			{
				if (100 < t[i])
				{
					result++;
				}
			}
			return result;
		}

		static string Stringbe<T>(T[] t, string separator = " ", string start = "[ ", string end = " ]")
		{
			if (t.Length == 0)
			{
				return start + end;
			}

			string result = start;
			for (int i = 0; i < t.Length - 1; i++)
			{
				result += $"{t[i]}" + separator;
			}
			result += t[t.Length - 1];
			return result + end;
			// default: "[ 0 10 0 0 0 ]";
		}

		static void Main(string[] args)
		{
			int[] t = Beolvasas();

            // Console.WriteLine(Stringbe(t));

            int eredmeny = Feldolgozas(t);
            Console.WriteLine(eredmeny);
        }
	}
}
