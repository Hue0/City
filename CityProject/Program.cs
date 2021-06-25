using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CityProject
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileCity = @"/Users/Tomek/Desktop/countries_and_capitals.txt";

			List<string> lines = File.ReadAllLines(fileCity).ToList();

			List<string> newlines = new List<string>();

			foreach (string line in lines)
			{
				if (line.Contains("EU")) //Adding in txt file, mark EU to filter cities.
					newlines.Add(line);


			}

			Console.WriteLine("\n");

			var random = new Random();
			int index = random.Next(newlines.Count);
			string cit = newlines[index];
			int one = cit.IndexOf("|") + "|".Length;
			int second = cit.LastIndexOf(",");
			string newcity = cit.Substring(one, second - one);
			

			string secretCap = newcity.Trim(' ');
			

			Console.Write("SecretCity = " + secretCap);
			Console.Write("\n");

			string ReplaceAll(string input, char target)
			{
				StringBuilder sb = new StringBuilder(input.Length);
				for (int i = 0; i < input.Length; i++)
				{
					sb.Append(target);
				}

				return sb.ToString();
			}
			string newCap = ReplaceAll(secretCap, '-');

			Console.Write("SecretCity = " + newCap);

			string choose = "_";

			var guessed = new List<char>();
			string guess = "_";

			while (choose != "*") {
				Console.WriteLine("\n" + "1 = letter or 2 = whole word ");
				Console.WriteLine("\n" + "Enter number 1 or 2: ");
				choose = Console.ReadLine();
				if (choose == "1") {
					string c;
					Console.Write("Podaj literę: ");
                    c = Console.ReadLine();
					char c1 = c[0];
					Console.WriteLine(secretCap);
					List<char> xxx = new List<char>();
					foreach (var letter in secretCap)
					{

						if (letter == c1)
						
							Console.Write(c1);
							//xxx.Add(letter);
						


                        else
							Console.Write("_");
							
					}
					Console.WriteLine("\nEnter a letter!");

				}

				if (choose == "2") {

					Console.Write("Podaj słowo: ");
					guess = Console.ReadLine();
					if (guess == secretCap) {
						Console.Write("You Win!");
						break;

					}

					
					
				}
			}



		}


	}
	





}
