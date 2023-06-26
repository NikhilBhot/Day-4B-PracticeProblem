using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_PracticeProblem
{
    /*
    Write a program to print below pattern.
                            ********
                            *******
                            ******
                            *****
                            ****
                            ***
                            **
                            *

    */
    public class PatternProgram1
    {
        public static void PatternMethod()
        {
            int rows = 8;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
