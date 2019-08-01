using System;

namespace StringTocamelCase
{
    public class CamelCaseDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Camel Case = " + toCamel("34!@#  to k$@#64ill@#$ a )$#mOCKINg#$@Bird"));
        }
        public static string toCamel(string input)
        {
            input = input.ToLower();
            string answer = "";
            for (int i = 0; i < input.Length; i++)
            {
                char eval = input[i];
                while (eval == ' ' && i > 0)
                {
                    eval = input[++i];
                    while (!char.IsLetter(eval))
                    {
                        eval = input[++i];
                    }
                    eval = char.ToUpper(eval);
                }
                while (!Char.IsLetter(eval))
                {
                    eval = input[++i];
                }
                answer += eval;
            }
            return answer;
        }
    }
}
