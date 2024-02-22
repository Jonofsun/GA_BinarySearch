using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BinarySearch
{
    internal static class BinarySearch
    {

        // Iterative binary search function
        public static int IterativeBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                if (array[mid] == target)
                    return mid;

                // If target greater, ignore left half
                if (array[mid] < target)
                    left = mid + 1;
                // If target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // If we reach here, then the element was not present
            return -1;
        }

        // Recursive binary search function
        public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if target is present at mid
                if (array[mid] == target)
                    return mid;

                // If target is smaller than mid, search left half
                if (array[mid] > target)
                    return RecursiveBinarySearch(array, target, left, mid - 1);

                // If target is greater than mid, search right half
                return RecursiveBinarySearch(array, target, mid + 1, right);
            }

            // If we reach here, then the element was not present
            return -1;
        }

    } // BinarySearch

} // namespace
