using System;
using System.Collections.Generic;
using System.Globalization;

namespace HW1Strings
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter title to capitalize: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string example = Console.ReadLine();
            while (example.Contains("  "))
            {
                example = example.Replace("  "," ");
            }
            string[] list = new string[] { "A", "At", "About", "After", "By", "During", "In", "For", "On", "Over", "Till", "Upon", "Within" }; 
            example = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(example.ToLower());
            string[] words = example.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                foreach (string toCheck in list)
                {
                    if (words[i].Equals(toCheck))
                        words[i] = words[i].ToLower();
                }
            }
            example = string.Join(" ", words);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Capitalized title: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(example);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}