namespace Day_4B_PracticeProblem
{
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
        }
    }
}