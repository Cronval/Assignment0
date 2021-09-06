using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (isLeapyear(Int32.Parse(input))){
                Console.WriteLine("yay");
            }
            else {
                Console.WriteLine("nay");
            }
        }

        public static bool isLeapyear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
