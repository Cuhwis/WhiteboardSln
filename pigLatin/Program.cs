using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PigLatin("you are juan of a kind");
        }
        public static void PigLatin(string input)
        {
            string[] arr = input.Split();
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            string conv = "";
            foreach (string item in arr)
            {
                if (vowels.Any(c => c.Equals(item[0])))
                {
                    conv += item;
                }
                if (!vowels.Any(c => c.Equals(item[0])))
                {
                    for (int i = 1; i < item.Length; i++)
                    {
                        conv += item[i];
                    }
                    conv += item[0];
                }
                conv += "ay ";
            }
            Console.WriteLine(conv);
        }
    }
}
