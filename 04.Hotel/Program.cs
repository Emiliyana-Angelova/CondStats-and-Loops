using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			double nightCount = double.Parse(Console.ReadLine());

			double studioPrice = 0;
			double doublePrice = 0;
			double suitePrice = 0;
			double discount = 0;
			double studioPriceAll = 0;
			double doublePriceAll = 0;
			double suitePriceAll = 0;

			if (month == "May" || month == "October")
			{
				studioPrice = 50;
				doublePrice = 65;
				suitePrice = 75;

				if (nightCount > 7)
				{
					discount = 0.05;

					if (month == "October")
					{
						studioPriceAll = (studioPrice * (nightCount - 1)) - discount * (studioPrice * (nightCount - 1));
					}

					else
					{
						studioPriceAll = (studioPrice * nightCount) - discount * (studioPrice * nightCount);
					}

					doublePriceAll = doublePrice * nightCount;
					suitePriceAll = suitePrice * nightCount;
				}

				else
				{
					studioPriceAll = studioPrice * nightCount;
					doublePriceAll = doublePrice * nightCount;
					suitePriceAll = suitePrice * nightCount;
				}

				Console.WriteLine($"Studio: {studioPriceAll:f2} lv.");
				Console.WriteLine($"Double: {doublePriceAll:f2} lv.");
				Console.WriteLine($"Suite: {suitePriceAll:f2} lv.");
			}

			else if (month == "June" || month == "September")
			{
				studioPrice = 60;
				doublePrice = 72;
				suitePrice = 82;

				if (nightCount > 14)
				{
					discount = 0.10;

					if (month == "September")
					{
						studioPriceAll = studioPrice * (nightCount - 1);
					}
					else
					{
						studioPriceAll = studioPrice * nightCount;
					}

					doublePriceAll = (doublePrice * nightCount) - discount * (doublePrice * nightCount);
					suitePriceAll = suitePrice * nightCount;
				}
				else
				{
					if (month == "September" && nightCount > 7)
					{
						studioPriceAll = studioPrice * (nightCount - 1);
					}
					else
					{
						studioPriceAll = studioPrice * nightCount;
					}

					doublePriceAll = doublePrice * nightCount;
					suitePriceAll = suitePrice * nightCount;
				}

				Console.WriteLine($"Studio: {studioPriceAll:f2} lv.");
				Console.WriteLine($"Double: {doublePriceAll:f2} lv.");
				Console.WriteLine($"Suite: {suitePriceAll:f2} lv.");
			}

			else if (month == "July" || month == "August" || month == "December")
			{
				studioPrice = 68;
				doublePrice = 77;
				suitePrice = 89;

				if (nightCount > 14)
				{
					discount = 0.15;
					suitePriceAll = (suitePrice * nightCount) - discount * (suitePrice * nightCount);
					studioPriceAll = studioPrice * nightCount;
					doublePriceAll = doublePrice * nightCount;
				}
				else
				{
					studioPriceAll = studioPrice * nightCount;
					doublePriceAll = doublePrice * nightCount;
					suitePriceAll = suitePrice * nightCount;
				}

				Console.WriteLine($"Studio: {studioPriceAll:f2} lv.");
				Console.WriteLine($"Double: {doublePriceAll:f2} lv.");
				Console.WriteLine($"Suite: {suitePriceAll:f2} lv.");
			}
		}
	}
}
