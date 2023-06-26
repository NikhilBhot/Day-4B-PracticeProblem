using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    //C# program to find sum of all digits of a given number.
    public class SumOfDigits
    {
        public static int SumOfDigitsMethod(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}
