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
                    if (String.IsNullOrEmpty(example))
                    {
                        Console.Clear();
                    }
                } while ( example.Equals(""));
                while (example.Contains("  ") || example.Contains(" ,") || example.Contains(",  "))
                {
                    example = example.Replace("  ", " ");
                    example = example.Replace(" ,", ", ");
                    example = example.Replace(",  ", ", ");
                }
                string[] list = new string[] { "A", "About", "After", "At", "By", "During", "For", "In", "On", "Over", "Till", "Upon", "Within" };
                example = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(example.ToLower());
                string[] words = example.Split(new char[] { ' ' });
                for (int i = 0; i < words.Length; i++)
                {
                    foreach (string toCheck in list)
                    {
                        if (words[i].Equals(toCheck))
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