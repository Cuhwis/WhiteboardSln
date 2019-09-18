using System;

namespace subStringMatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(findSubString("catinthehat", "hat"));
        }
        public static int findSubString(string input, string subString)
        {
            int index = -1;
            bool match = true;
            //Looping thru input
            for (int i = 0; i < input.Length; i++)
            {
                //finds first character that matches the [0] of subString
                if (subString[0] == input[i])
                {
                    index = i;
                    //found a match? Set index to the value of i
                    //Check if all characters after index match subString
                    for (
                        
                        int j = 1; j < subString.Length; j++)
                    {
                        //Everything match? index is right
                        if (subString[j] == input[i++])
                        {
                            match = true;
                        }
                        //No match? index = -1
                        if (subString[j] != input[i++])
                        {
                            match = false;
                        }
                    }
                    if (match == true)
                    {
                        break;
                    }
                }
            }
            return index;
        }
    }
}
