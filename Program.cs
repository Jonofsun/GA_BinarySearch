namespace GA_BinarySearch_JonathanReed
{
    using System;
    using System.Diagnostics;
    internal class Program
    {
        /*
         Joanthan Reed
         2/27/2024

        Questions:
    What is binary search and how does it work?
        -Binary search is an efficient algorithm for finding a target value within a sorted array. 
        It works by repeatedly dividing the search interval in half. 
        If the value of the target is less than the value in the middle of the interval, the algorithm narrows the interval to the lower half. 
        Otherwise, it narrows it to the upper half. This process continues until the target value is found or the interval is empty.
    What is the time complexity of binary search?
        -The time complexity of binary search is O(log n), where n is the number of elements in the array. 
        This is because the algorithm divides the search space in half with each iteration.
    When is binary search preferred over linear search?
        -Binary search is preferred over linear search when the array is sorted and the size of the array is large. 
        It is much more efficient than linear search (which has a time complexity of O(n)) for large datasets.
    What are the key requirements for binary search to work correctly?
    -The array must be sorted.
    -The elements in the array must be accessible in constant time, typically requiring the array to be stored in contiguous memory (e.g., an array or an array-like data structure).
    Can binary search be applied to unsorted arrays? Why or why not?
        -Binary search cannot be directly applied to unsorted arrays because the algorithm relies on the array being sorted to make decisions about which half of the array to search next. 
        If the array is unsorted, binary search may overlook the target value, leading to incorrect results.

         */

        static void Main(string[] args)
        {
            TestIterativeBinarySearch();
            TestRecursiveBinarySearch();
        }
        public static void TestIterativeBinarySearch()
        {
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int target = 11;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = BinarySearch.IterativeBinarySearch(array, target);
            stopwatch.Stop();

            if (result != -1)
                Console.WriteLine($"Iterative Binary Search: Element {target} found at index {result} in {stopwatch.ElapsedMilliseconds} ms");
            else
                Console.WriteLine($"Iterative Binary Search: Element {target} not found");
        }

        public static void TestRecursiveBinarySearch()
        {
            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 14;

            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = BinarySearch.RecursiveBinarySearch(array, target, 0, array.Length - 1);
            stopwatch.Stop();

            if (result != -1)
                Console.WriteLine($"Recursive Binary Search: Element {target} found at index {result} in {stopwatch.ElapsedMilliseconds} ms");
            else
                Console.WriteLine($"Recursive Binary Search: Element {target} not found");
        }
    }
}
