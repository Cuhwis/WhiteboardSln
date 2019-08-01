using System;
namespace DiffDate
{
    class Program
    {
        static void Main(string[] args)
        {
            julianDate(1, 9);
            
        }
        public static int julianDate (int m, int day)
        {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int julDate = day;
            for (int i = 0; i < m; i++)
            {
                julDate = julDate + months[i];
            }
            return julDate;
        }

    }
}
