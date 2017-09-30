using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int magicNum = int.Parse(Console.ReadLine());
			int combinations = 0;
			int sum = 0;

			for (int row = n; row <= m; row++)
			{
				for (int col = n; col <= m; col++)
				{
					sum = row + col;
					if (sum == magicNum)
					{
						Console.WriteLine($"Number found! {col} + {row} = {sum}");
						return;
					}
					combinations++;
				}
			}
			Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
		}
	}
}
