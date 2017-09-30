using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputOne = int.Parse(Console.ReadLine());
			int inputTwo = int.Parse(Console.ReadLine());

			if (inputOne < inputTwo)
			{
				for (int i = inputOne; i <= inputTwo; i++)
				{
					Console.WriteLine(i);
				}
			}
			else
			{
				for (int i = inputTwo; i <= inputOne; i++)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
