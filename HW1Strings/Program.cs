using System;
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
                example = example.Replace("  ", " ");
            }

            example = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(example.ToLower());
            string[] words = example.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("A") || words[i].Equals("For") || words[i].Equals("Upon") ||
                    words[i].Equals("After") || words[i].Equals("Over") || words[i].Equals("About") ||
                    words[i].Equals("At") || words[i].Equals("During") || words[i].Equals("Over") ||
                    words[i].Equals("In") || words[i].Equals("On") || words[i].Equals("Till") ||
                    words[i].Equals("Within") || words[i].Equals("At") || words[i].Equals("By"))
                {
                    words[i] = words[i].ToLower();
                }
            }
            example = (string.Join(" ", words));
            Console.WriteLine(example);
        }
    }
}