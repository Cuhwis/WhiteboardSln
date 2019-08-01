using System;

namespace isPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "rats live on no evil star";
            Console.WriteLine(isPalindrome(noWhiteSpacesMethod(test)));
        }
        public static bool isPalindrome(string input)
        {
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length-i-1])
                {
                    return false;
                }
            }
            return true;

        }
        public static string noWhiteSpacesMethod(string input)
        {
            string noWhiteSpaces = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsWhiteSpace(input[i]))
                {
                    continue;
                }
                noWhiteSpaces += c;
            }
            return noWhiteSpaces;
        }
    }
}
