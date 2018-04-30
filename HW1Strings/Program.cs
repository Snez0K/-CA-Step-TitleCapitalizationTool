using System;
using System.Globalization;

namespace TitleCapitalizationTool
{
    internal class Program
    {
        private static void Main()
        {
            do
            {
                string example;
                do
                {
                    Console.Write("Enter title to capitalize: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    example = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (string.IsNullOrEmpty(example))
                    {
                        Console.Clear();
                    }
                } while (example.Equals(""));
                do
                {
                    example = example.Replace("  ", " ");
                } while (example.Contains("  "));
                string[] filter = new string[] { " ", ",", "!", ".", ":", "?", "-" };
                string temper;
                for (int i = 0; i < filter.Length; i++)
                {
                    temper = $"{" "}{filter[i]}{" "}";
                    example = example.Replace(temper, $"{filter[i]}{" "}");
                    temper = $"{" "}{filter[i]}";
                    example = example.Replace(temper, $"{filter[i]}{" "}");
                }

                string[] list = new string[] { "A", "About", "After", "At", "An", "And", "But", "By", "During", "For", "In", "Nor", "Of", "On", "Or", "Out", "Over", "So", "The", "To", "Till", "Up", "Upon", "Yet", "Within" };
                example = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(example.ToLower());
                string[] words = example.Split(new char[] { ' ' });
                for (int i = 0; i < words.Length; i++)
                {
                    foreach (string toCheck in list)
                    {
                        if (words[i].Equals(toCheck) && i != 0 && i != words.Length - 1)
                        {
                            words[i] = words[i].ToLower();
                        }
                    }
                }
                example = string.Join(" ", words);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Capitalized title: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(example);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" ");
            } while (true);
        }
    }
}