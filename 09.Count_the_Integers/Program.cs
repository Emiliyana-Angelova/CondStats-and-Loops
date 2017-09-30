using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = 0;

			for (int i = 0; i < 100; i++)
			{
				try
				{
					int number = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{

					Console.WriteLine(input);
					return;
				}

				input++;
			}
		}
	}
}