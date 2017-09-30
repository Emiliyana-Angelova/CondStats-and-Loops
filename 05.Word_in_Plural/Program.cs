using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
	class Program
	{
		static void Main(string[] args)
		{
			string wordSingle = Console.ReadLine();

			if (wordSingle.EndsWith("y") == true)
			{
				Console.WriteLine((wordSingle.Remove(wordSingle.Length - 1) + "ies"));
			}

			else if (wordSingle.EndsWith("o") == true)
			{
				Console.WriteLine(wordSingle + "es");
			}

			else if (wordSingle.EndsWith("s") == true)
			{
				Console.WriteLine(wordSingle + "es");
			}

			else if (wordSingle.EndsWith("ch") == true)
			{
				Console.WriteLine(wordSingle + "es");
			}

			else if (wordSingle.EndsWith("sh") == true)
			{
				Console.WriteLine(wordSingle + "es");
			}

			else if (wordSingle.EndsWith("x") == true)
			{
				Console.WriteLine(wordSingle + "es");
			}

			else if (wordSingle.EndsWith("z") == true)
			{
				Console.WriteLine(wordSingle + "es");
			}

			else
			{
				Console.WriteLine(wordSingle + "s");
			}

		}
	}
}
