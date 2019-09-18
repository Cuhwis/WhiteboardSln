using System;

namespace feetAndInches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            feetAndInches(256);
        }
        static void feetAndInches(int cent)
        {
            double inches = cent / 2.54;
            int feet = (int)inches / 12;
            inches = (int)inches - (feet * 12);

            Console.WriteLine($"{feet}ft {inches}in");

        }
    }
}
