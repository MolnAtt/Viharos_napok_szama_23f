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

		// Új feladat: Mekkora volt az átlagsebesség?
		// Új részfeladat: Mekkora a tömb tagjainak az összege?

		static int Osszeg(int[] t)
		{
			int result = 0;
			for (int i = 0; i < t.Length; i++)
			{
				result += t[i];
			}
			return result;
		}

		static double Atlag(int[] t)
		{
			double result = (double)Osszeg(t) / t.Length;
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

			// int eredmeny = Feldolgozas(t);
			double eredmeny = Atlag(t);
			Console.WriteLine(eredmeny);
        }
	}
}

/*

10 3
0
5
0
5
0
5
111
111
111
111 
 

*/

/*

100 3
77
94
169
106
39
131
157
32
151
24
152
179
20
158
93
30
21
171
66
77
9
126
143
85
55
182
149
171
15
1
88
7
80
185
136
186
3
83
93
62
143
2
193
102
111
74
58
94
33
113
127
108
105
59
75
134
125
21
192
126
122
137
15
20
55
172
77
90
48
29
95
22
102
192
137
131
21
89
67
25
182
180
86
78
30
116
78
149
151
83
72
6
181
122
69
54
164
145
167
121

*/