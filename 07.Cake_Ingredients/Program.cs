using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int sum = 0;

			while (input != "Bake!") 
			{
				Console.WriteLine($"Adding ingredient {input}.");
				sum++;
				input = Console.ReadLine();

				if (input == "Bake!")
				{
					Console.WriteLine($"Preparing cake with {sum} ingredients.");
				}

			}
		}
	}
}
