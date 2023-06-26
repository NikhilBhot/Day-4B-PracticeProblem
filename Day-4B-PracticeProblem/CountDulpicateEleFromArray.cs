using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    public class CountDulpicateEleFromArray
    {
        public static int CountDuplicateElements(int[] arr)
        {
            int duplicateCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicateCount++;
                        break;
                    }
                }
            }
            return duplicateCount;
        }
    }
}
