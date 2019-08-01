using System;

namespace AngleOfClock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static double angleDiff(double x, double y)
        {
            double angleX = 360 * (x / 12);
            double angleY = 360 * (y / 60);
            double degrees = Math.Abs(angleX - angleY);
            if (degrees == 360)
            {
                degrees = 0;
            }
            Console.WriteLine(degrees);
            return degrees;
        }
    }
}
