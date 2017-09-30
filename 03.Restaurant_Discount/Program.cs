using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
	class Program
	{
		static void Main(string[] args)
		{
			double groupSize = double.Parse(Console.ReadLine());
			string package = Console.ReadLine();

			double hallPrice = 0;
			string hallType = null;
			double packagePrice = 0;
			double discount = 0;
			double totalPrice = 0;
			double pricePerPerson = 0;


			if (groupSize <= 50)
			{
				hallPrice = 2500;
				hallType = "Small Hall";

				if (package == "Normal")
				{
					packagePrice = 500;
					discount = 0.05;
				}

				else if (package == "Gold")
				{
					packagePrice = 750;
					discount = 0.10;
				}

				else if (package == "Platinum")
				{
					packagePrice = 1000;
					discount = 0.15;
				}

				totalPrice = (hallPrice + packagePrice) - (discount * (packagePrice + hallPrice));
				pricePerPerson = totalPrice / groupSize;
				Console.WriteLine($"We can offer you the {hallType}");
				Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
			}

			else if (groupSize > 50 && groupSize <= 100)
			{
				hallPrice = 5000;
				hallType = "Terrace";

				if (package == "Normal")
				{
					packagePrice = 500;
					discount = 0.05;
				}

				else if (package == "Gold")
				{
					packagePrice = 750;
					discount = 0.10;
				}

				else if (package == "Platinum")
				{
					packagePrice = 1000;
					discount = 0.15;
				}

				totalPrice = (hallPrice + packagePrice) - (discount * (packagePrice + hallPrice));
				pricePerPerson = totalPrice / groupSize;
				Console.WriteLine($"We can offer you the {hallType}");
				Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
			}

			else if (groupSize > 100 && groupSize <= 120)
			{
				hallPrice = 7500;
				hallType = "Great Hall";

				if (package == "Normal")
				{
					packagePrice = 500;
					discount = 0.05;
				}

				else if (package == "Gold")
				{
					packagePrice = 750;
					discount = 0.10;
				}

				else if (package == "Platinum")
				{
					packagePrice = 1000;
					discount = 0.15;
				}

				totalPrice = (hallPrice + packagePrice) - (discount * (packagePrice + hallPrice));
				pricePerPerson = totalPrice / groupSize;
				Console.WriteLine($"We can offer you the {hallType}");
				Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
			}

			else if (groupSize > 120)
			{
				Console.WriteLine("We do not have an appropriate hall.");
			}

		}
	}
}
