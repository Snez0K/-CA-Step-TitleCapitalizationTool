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
                Console.Write("Enter title to capitalize: ");
                Console.ForegroundColor = ConsoleColor.Red;
                do
                {
                    example = Console.ReadLine();
                } while (string.IsNullOrEmpty(example));
                Console.ForegroundColor = ConsoleColor.Gray;
                
                string[] filter = new string[] { " ", ",", "!", ".", ":", "?", "-" };
                string changed;
                for (int i = 0; i < filter.Length; i++)
                {
                    if (filter[i] != "-")
                    {
                        changed = $"{" "}{filter[i]}{" "}";
                        example = example.Replace(changed, $"{filter[i]}{" "}");

                        changed = $"{" "}{filter[i]}";
                        example = example.Replace(changed, $"{filter[i]}{" "}");
                    }
                    else
                    {
                        changed = $"{" "}{filter[i]}{" "}";
                        example = example.Replace($"{filter[i]}", changed);
                    }
                }
                do
                {
                    example = example.Replace("  ", " ");
                } while (example.Contains("  "));
                string[] lowercaseWords = new string[] { "A", "At", "An", "And", "But", "By", "For", "In", "Nor", "Of", "On", "Or", "Out", "So", "The", "To", "Up", "Yet" };
                example = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(example.ToLower());
                string[] words = example.Split(new char[] { ' ' });
                for (int i = 0; i < words.Length; i++)
                {
                    foreach (string toCheck in lowercaseWords)
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