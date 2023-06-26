using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    public class PatternProgram2
    {
        public static void PatternProgram2Method()
        {
            int size = 5; // Change this value to adjust the size of the square

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i == 1 || i == size || j == 1 || j == size)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
