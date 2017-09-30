using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink02
{
	class Program
	{
		static void Main(string[] args)
		{
			string profession = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());
			double totalPrice = 0;

			if (profession == "Athlete")
			{
				totalPrice = quantity * 0.70;
			}
			else if (profession == "Businessman" || profession == "Businesswoman")
			{
				totalPrice = quantity * 1.00;
			}
			else if (profession == "SoftUni Student")
			{
				totalPrice = quantity * 1.70;
			}
			else
			{
				totalPrice = quantity * 1.20;
			}

			Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");

		}
	}
}
