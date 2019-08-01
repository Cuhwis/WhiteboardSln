using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         int answer = 0;
            try
            {
                answer = int.Parse("17");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine($"Converted: {answer}");
                Console.WriteLine("Done!");
            }


        }
    }
}
