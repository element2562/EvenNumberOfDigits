using System;

namespace EvenNumberOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] { 1, 23, 43, 5353, 55, 123, 20 };
            int NumberOfEvenDigits = FindNumbers(Numbers);
            Console.WriteLine(NumberOfEvenDigits);
        }

        static int FindNumbers(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
