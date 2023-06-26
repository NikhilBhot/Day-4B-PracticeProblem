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
        }
    }
}