using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    //Write a program in C# Sharp to print all unique elements in an array.
    public class CountUniqueEleFromArray
    {
        public static bool IsUnique(int[] arr, int num)
        {
            int count = 0;
            foreach (var element in arr)
            {
                if (element == num)
                {
                    count++;
                    if (count > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
