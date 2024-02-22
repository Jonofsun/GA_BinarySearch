# Guided Assignment - Binary Search
---

## Introduction

Binary search is a searching algorithm used to find the position of a target value within a sorted array or list. It works by repeatedly dividing the search interval in half until the target value is found or the search interval becomes empty. 

The algorithm compares the target value with the middle element of the array. If the target value matches the middle element, its position is returned. If the target value is less than the middle element, the search continues on the lower half of the array. If the target value is greater than the middle element, the search continues on the upper half of the array. This process repeats until the target value is found or the search interval is empty.

Binary search is a very efficient algorithm with a time complexity of O(log n), where n is the number of elements in the array. It is significantly faster than linear search algorithms, especially for large datasets, because it eliminates half of the remaining elements in each iteration. However, it requires the array to be sorted beforehand, which can be a limitation in some cases.

---

## Requirements

1. **Project Name:** `GA_BinarySearch_YourName`

2. **Thorough Code Comments:**
   - Ensure all methods and significant code blocks are adequately commented to explain their purpose and functionality.

3. **Static Binary Search Class:**
   - Implement both iterative and recursive binary search algorithms within a static class named `BinarySearch`.

4. **Test Code:**
   - Write test code to verify the functionality of both binary search algorithms.
   - Use Stopwatch to measure the time taken for each search operation.
   - Display the search results and elapsed time for each algorithm.

5. **Five Questions Related to Binary Search:**
   - Include five questions related to binary search algorithm, such as:
     - What is binary search and how does it work?
     - What is the time complexity of binary search?
     - When is binary search preferred over linear search?
     - What are the key requirements for binary search to work correctly?
     - Can binary search be applied to unsorted arrays? Why or why not?



---
## Binary Search - Iterative

Iterative binary search is a searching algorithm used to find the position of a target value within a sorted array or list. It works by repeatedly dividing the search interval in half until the target value is found or the search interval becomes empty. Here's a breakdown of how it works:

1. **Initialize Pointers**: Begin with two pointers, `left` and `right`, representing the beginning and end of the array respectively.

2. **Iterative Process**: Use a while loop to continue the search as long as the `left` pointer is less than or equal to the `right` pointer.

3. **Calculate Midpoint**: Compute the midpoint of the current range by averaging the `left` and `right` pointers.

4. **Check Midpoint**: Compare the element at the midpoint with the target value:
   - If they are equal, return the index of the midpoint.
   - If the element at the midpoint is less than the target, update the `left` pointer to search the right half of the array.
   - If the element at the midpoint is greater than the target, update the `right` pointer to search the left half of the array.

5. **Repeat**: Continue this process until the target value is found or the search interval is empty.

6. **Return Result**: If the target value is found, return its index; otherwise, return -1 to indicate that the element was not found in the array.

Iterative binary search is efficient with a time complexity of O(log n) because it eliminates half of the remaining elements in each iteration, making it significantly faster than linear search algorithms for large datasets.

Psuedo Code

```
function IterativeBinarySearch(array, target):
    left = 0
    right = length(array) - 1
    
    while left <= right:
        mid = left + (right - left) / 2
        
        if array[mid] == target:
            return mid
        else if array[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    
    return -1

```

1. **Define Method Signature:**
   ```csharp
   public static int IterativeBinarySearch(int[] array, int target)
   ```
   This method takes an array of integers `array` and the target integer `target` as parameters. It returns an integer representing the index of the target element in the array, or -1 if the target element is not found.

2. **Initialize Left and Right Pointers:**
   ```csharp
   int left = 0;
   int right = array.Length - 1;
   ```
   Set the left pointer `left` to the beginning of the array (index 0) and the right pointer `right` to the end of the array (index `array.Length - 1`).

3. **Iterative Binary Search Algorithm:**
   ```csharp
   while (left <= right)
   ```
   Continue the search until the left pointer is less than or equal to the right pointer.

4. **Calculate Midpoint:**
   ```csharp
   int mid = left + (right - left) / 2;
   ```
   Calculate the midpoint `mid` of the current range by averaging the left and right pointers. This helps to determine which half of the array to search next.

5. **Check if Target Found at Midpoint:**
   ```csharp
   if (array[mid] == target)
       return mid;
   ```
   If the element at the midpoint `mid` is equal to the target element, return the index of the midpoint `mid`.

6. **Adjust Pointers Based on Target Comparison:**
   ```csharp
   if (array[mid] < target)
       left = mid + 1;
   else
       right = mid - 1;
   ```
   If the element at the midpoint `mid` is less than the target element, adjust the left pointer `left` to `mid + 1` to search the right half of the array. Otherwise, adjust the right pointer `right` to `mid - 1` to search the left half of the array.

7. **Element Not Found:**
   ```csharp
   return -1;
   ```
   If the loop completes without finding the target element, return -1 to indicate that the element was not found in the array.

This algorithm efficiently searches for a target element in a sorted array by repeatedly dividing the search interval in half. It's important to note that the array must be sorted for binary search to work correctly.



---

## Binary Search - Recursive

Recursive binary search is another approach to finding a target value within a sorted array or list. Here's a breakdown of how it works:

1. **Define Base Case**: The function starts by checking if the `left` pointer is less than or equal to the `right` pointer. This serves as the base case for the recursion. If the base case is met, it means that the search interval is empty, and the function returns -1 to indicate that the target element was not found.

2. **Calculate Midpoint**: If the base case is not met, the function calculates the midpoint of the current range by averaging the `left` and `right` pointers.

3. **Check Midpoint**: The function then compares the element at the midpoint with the target value:
   - If they are equal, the function returns the index of the midpoint, indicating that the target element was found.
   - If the element at the midpoint is greater than the target, the function recursively calls itself on the left half of the array, updating the `right` pointer to `mid - 1`.
   - If the element at the midpoint is less than the target, the function recursively calls itself on the right half of the array, updating the `left` pointer to `mid + 1`.

4. **Repeat**: This process continues recursively until the base case is met or the target value is found.

5. **Return Result**: If the target value is found during the recursive calls, the function returns its index; otherwise, it returns -1.

Recursive binary search also has a time complexity of O(log n) because it effectively divides the search space in half with each recursive call, making it efficient for searching large datasets. However, it may consume more stack space due to recursive function calls compared to the iterative approach.

```console
function RecursiveBinarySearch(array, target, left, right):
    if left > right:
        return -1
    
    mid = left + (right - left) / 2
    
    if array[mid] == target:
        return mid
    else if array[mid] < target:
        return RecursiveBinarySearch(array, target, mid + 1, right)
    else:
        return RecursiveBinarySearch(array, target, left, mid - 1)
```



```csharp
// Recursive binary search function
public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
{
    // Step 1: Base case - check if left pointer is less than or equal to right pointer
    if (left <= right)
    {
        // Step 2: Calculate midpoint
        int mid = left + (right - left) / 2;

        // Step 3: Check if target is present at midpoint
        if (array[mid] == target)
            return mid;

        // Step 4: If target is smaller than element at midpoint, search left half recursively
        if (array[mid] > target)
            return RecursiveBinarySearch(array, target, left, mid - 1);

        // Step 5: If target is greater than element at midpoint, search right half recursively
        return RecursiveBinarySearch(array, target, mid + 1, right);
    }

    // Step 6: Base case - If left pointer exceeds right pointer, element was not found
    return -1;
}
```

1. **Base Case Check:**
   ```csharp
   if (left <= right)
   ```
   This is the base case check for the recursive function. It ensures that the recursion continues as long as the left pointer is less than or equal to the right pointer.

2. **Calculate Midpoint:**
   ```csharp
   int mid = left + (right - left) / 2;
   ```
   Calculate the midpoint `mid` of the current range by averaging the left and right pointers. This helps to determine which half of the array to search next.

3. **Check if Target Found at Midpoint:**
   ```csharp
   if (array[mid] == target)
       return mid;
   ```
   If the element at the midpoint `mid` is equal to the target element, return the index of the midpoint `mid`.

4. **Search Left Half Recursively:**
   ```csharp
   if (array[mid] > target)
       return RecursiveBinarySearch(array, target, left, mid - 1);
   ```
   If the element at the midpoint `mid` is greater than the target element, recursively call the function on the left half of the array (from `left` to `mid - 1`).

5. **Search Right Half Recursively:**
   ```csharp
   return RecursiveBinarySearch(array, target, mid + 1, right);
   ```
   If the element at the midpoint `mid` is less than the target element, recursively call the function on the right half of the array (from `mid + 1` to `right`).

6. **Base Case - Element Not Found:**
   ```csharp
   return -1;
   ```
   If the left pointer exceeds the right pointer, it means that the element was not found in the array. Return -1 to indicate this.

   ---

   ### Test your code

   Certainly! Below is the code to test the binary search examples using Stopwatch:

```csharp
using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        // Test iterative binary search
        TestIterativeBinarySearch();

        // Test recursive binary search
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
```

In this code:

- We have a `Main` method where we call two test methods: `TestIterativeBinarySearch` and `TestRecursiveBinarySearch`.
- `TestIterativeBinarySearch` tests the iterative binary search example by searching for the target value 11 in the array { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }.
- `TestRecursiveBinarySearch` tests the recursive binary search example by searching for the target value 14 in the array { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }.
- We use `Stopwatch` to measure the time taken for each search operation.

   ---

   ## Time and Space Compexity

   Sure, let's add segments about the time and space complexity for both the iterative and recursive binary search algorithms:

### Iterative Binary Search:

**Time Complexity:**  
The time complexity of the iterative binary search algorithm is O(log n), where n is the number of elements in the sorted array. This is because the search space is halved in each iteration.

**Space Complexity:**  
The space complexity of the iterative binary search algorithm is O(1), as it uses only a constant amount of extra space for variables like left, right, and mid. It does not require any additional data structures that grow with the input size.

### Recursive Binary Search:

**Time Complexity:**  
The time complexity of the recursive binary search algorithm is also O(log n), where n is the number of elements in the sorted array. Similar to the iterative approach, the search space is halved in each recursive call.

**Space Complexity:**  
The space complexity of the recursive binary search algorithm is O(log n) in the average and best case scenarios. This is because the function calls are placed on the call stack, which grows logarithmically with the input size. However, in the worst case scenario where the recursion goes deeply (e.g., if the target element is not found), the space complexity can be O(n), as each function call consumes memory on the call stack until the base case is reached.

---

## Questions Related to Binary Search

1. **What is binary search and how does it work?**

2. **What is the time complexity of binary search?**

3. **When is binary search preferred over linear search?**

4. **What are the key requirements for binary search to work correctly?**

5. **Can binary search be applied to unsorted arrays? Why or why not?**

---

## Rubric

| Name               | Description                                                                                   | Points |
|--------------------|-----------------------------------------------------------------------------------------------|--------|
| Project Name       | The project is named `GA_BinarySearch_YourName` where `YourName` is replaced with the student's name.                            | 5      |
| Code Comments      | Thorough comments are provided throughout the code, explaining the purpose and functionality of methods and significant code blocks. | 25     |
| Static Class       | Implement both iterative and recursive binary search algorithms within a static class named `BinarySearch`.                                | 20     |
| Test Code          | Write test code to verify the functionality of both binary search algorithms. Use Stopwatch to measure the time taken for each search operation. Display the search results and elapsed time for each algorithm. | 20     |
| Questions          | Include five questions related to binary search algorithm with clear and concise explanations. | 20     |
| Project Submission | The completed project is submitted via GitHub.                                            | 10     |
| **Total**          |                                                                                               | **100**   |