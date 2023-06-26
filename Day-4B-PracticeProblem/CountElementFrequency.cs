using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    public class CountElementFrequency
    {
       public static Dictionary<int, int> CountElementFrequencyMethod(int[] arr)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (var element in arr)
            {
                if (frequencyMap.ContainsKey(element))
                {
                    frequencyMap[element]++;
                }
                else
                {
                    frequencyMap[element] = 1;
                }
            }

            return frequencyMap;
        }
    }
}
