using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int maxSum = int.Parse(Console.ReadLine());
			int sum = 0;
			int combinations = 0;

			for (int row = N; row >= 1; row--)
			{
				for (int col = 1; col <= M; col++)
				{
					sum += 3 * (row * col);

					combinations++;
					if (sum >= maxSum)
					{
						Console.WriteLine("{0} combinations", combinations);
						Console.WriteLine("Sum: {0} >= {1}", sum, maxSum);
						return;
					}
				}
			}
			if (sum < maxSum)
			{
				Console.WriteLine("{0} combinations", combinations);
				Console.WriteLine("Sum: {0}", sum);
			}


		}
	}
}
