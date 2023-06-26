using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    public class FindMaxMinfromArray
    {
        public static int FindMaximum(int[] arr)
        {
            int maximum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }
            return maximum;
        }

        public static int FindMinimum(int[] arr)
        {
            int minimum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }
            return minimum;
        }
    }
}
