using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstLetter = char.Parse(Console.ReadLine());
			char lastLetter = char.Parse(Console.ReadLine());
			char skipLetter = char.Parse(Console.ReadLine());		

			for (char f = firstLetter; f <= lastLetter; f++)
			{
				for (char l = firstLetter; l <= lastLetter; l++)
				{
					for (char t = firstLetter; t <= lastLetter; t++)
					{
						if (f != skipLetter && l != skipLetter && t != skipLetter)
						{
							
							string result = string.Format("{0}{1}{2}", f, l, t);

							Console.Write(result + " ");
						}
					}
				}
			}
			Console.WriteLine();

		}
	}
}
