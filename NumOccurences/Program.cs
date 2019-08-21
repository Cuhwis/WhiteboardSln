using System;

namespace NumOccurences
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(NumOccur("Oorah Marine Corps", 'o'));
        }
        public static int NumOccur(string input, char c)
        {
            int count = 0;
            char.ToLower(c); //needed if input is mixed cases ex: "SDcwewWDFDGwgeW"
            string lowerInput = input.ToLower(); //needed if input is mixed cases ex: "SDcwewWDFDGwgeW"
            Char[] line = lowerInput.ToCharArray();
            foreach (var item in line)
            {
                if (item == c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
