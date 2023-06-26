namespace Day_4B_PracticeProblem
{
    //Write a program in C# Sharp to count the frequency of each element of an
    //array.
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Find duplicate Elements from Array ");
            int[] arr = { 1, 2, 3, 4, 5, 2, 4, 6, 7, 3, 8, 4, 9, 1 };
            int duplicateCount = CountDulpicateEleFromArray.CountDuplicateElements(arr);
            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Find Unique Element From Array");
            int[] arr1 = { 1, 2, 3, 4, 5, 2, 4, 6, 7, 3, 8, 4, 9, 1 };

            Console.WriteLine("Unique elements in the array:");
            foreach (var element in arr1)
            {
                if (CountUniqueEleFromArray.IsUnique(arr1, element))
                {
                    Console.WriteLine(element);

                }
            }


            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Find Frequency Of Elements From Array");
            int[] arr3 = { 1, 2, 3, 4, 5, 2, 4, 6, 7, 3, 8, 4, 9, 1 };

            Dictionary<int, int> frequencyMap = CountElementFrequency.CountElementFrequencyMethod(arr3);

            Console.WriteLine("Frequency of each unique element in the array:");
            foreach (var pair in frequencyMap)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Find Maximum and Minimum Elemets From Array");
            int[] arr4 = { 5, 2, 9, 1, 7, 4, 6, 3, 8 };

            int maximum = FindMaxMinfromArray.FindMaximum(arr4);
            int minimum = FindMaxMinfromArray.FindMinimum(arr4);

            Console.WriteLine("Maximum element: " + maximum);
            Console.WriteLine("Minimum element: " + minimum);

            Console.WriteLine("_______________________________");
            Console.WriteLine("Pattern Example");
            PatternProgram1.PatternMethod();
            
            
            Console.WriteLine("_______________________________");
            Console.WriteLine("Pattern Example");
            PatternProgram2.PatternProgram2Method();

        }
    }
}