using System;

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "Testing my reverse.";
            Console.WriteLine(reverseStringTres(str));
        }
        public static string reverseStringUno(string inputString)
        {
            string reversed = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                reversed = inputString[i] + reversed;
            }
            return reversed;
        }
        public static string reverseStringDos(string inputString)
        {
            string reversed = "";
            for (int i = inputString.Length-1; i >= 0; i--) //i = inputstring.Length-1 due to out of bounds index
            {
                reversed += inputString[i];
            }
            return reversed;
        }
        public static string reverseStringTres(string inputstring)
        {
            string reversed = "";
            int count = inputstring.Length-1;
            while (count >= 0)
            {
                reversed += inputstring[count];
                count--;
            }
            return reversed;
        }
        public static string reverseString2(string inputString)
        {
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            return new string (arr);
        }
    }
}
