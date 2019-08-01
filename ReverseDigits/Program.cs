using System;

namespace ReverseDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(reverseInstructor(-90856));
        }
        public static int reverseDigits(int a)
        {
            bool negative = (a < 0);
            int reversed = 0;
            a *= (negative) ? -1 : 1;
            while (a > 0)
            {
                int digit = a % 10;
                if(reversed > 0)
                {
                    reversed *= 10;
                }
                reversed += digit;
                a /= 10;
            }
            reversed *= (negative) ? -1 : 1;

            return reversed;
        }
        public static int reverseInstructor(int x)
        {
            bool isNeg = (x < 0);
            int sum = 0;
            x *= isNeg ? -1 : 1;
            while (x>0)
            {
                sum *= 10;
                int remainder = x % 10;
                sum += remainder;
                x /= 10;
            }
            sum *= isNeg ? -1 : 1;
            return sum;
        }
    }
}
