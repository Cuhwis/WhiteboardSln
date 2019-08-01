using System;

namespace OddTest
{
    class Program
    {
        static bool oddTest(int Number)
        {
            return Number % 2 == 1;
        }
        static void testOddTest()
        {
            Console.WriteLine($"\t5: isOdd? {oddTest(5)}");
            Console.WriteLine($"\t8: isOdd? {oddTest(8)}");
            Console.WriteLine($"\t0: isOdd? {oddTest(0)}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tOddTest.Main()");
            testOddTest();
        }
    }
}
