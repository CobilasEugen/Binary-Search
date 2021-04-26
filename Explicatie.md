# Binary-Search
Binary Search Algorithm. It is one of the Divide and conquer algorithms types, where in each step, it halves the number of elements it has to search, making the average time complexity to O (log n). It works on a sorted array. Given below are the steps/procedures of the Binary Search algorithm.

   1. In each step, it compares the search key with the value of the middle element of the array.

   2. The keys matching in step 1 means, a matching element has been found and its index (or position) is returned. Else step 3 or 4.

   3. If the search key is less than the middle element, then the algorithm repeats its action on the sub-array to the left of the middle element or,

   4. If the search key is greater than the middle element, then the algorithm repeats its action on the sub-array to the right of the middle element.

   5. If the search key is not matching any of the subsequent left or right array, then it means that the key is not present in the array and a special "Not found" indication can be returned.
