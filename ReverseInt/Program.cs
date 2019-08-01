using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            reverseInt(2, 4);
        }
        public static void reverseInt(int a, int b)
        {
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine($"{ a},{ b}");
        }
    }
}
