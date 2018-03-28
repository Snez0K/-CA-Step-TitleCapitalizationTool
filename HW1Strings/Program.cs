using System;
using System.Collections.Generic;
using System.Globalization;

namespace HW1Strings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Print some letters:");
            string example = Console.ReadLine();
            while (example.Contains("  "))
            {
                example = example.Replace("  "," ");
            }

            List<string> list = new List<string>(new string[] {
            "A", "For", "Upon", "After",
            "Over", "About", "At", "During", "Over",
            "In", "On", "Till", "Within", "At", "By"});

            example = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(example.ToLower());
            string[] words = example.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                foreach (string ToCheck in list)
                {
                    if (words[i].Equals(ToCheck))
                        words[i] = words[i].ToLower();
                }
            }
            example = (string.Join(" ", words));
            Console.WriteLine(example);
        }
    }
}