using System;

namespace binary_search
{
    class Program
    {
    public static object BinarySearchIterative(int[] inputArray, int key)  
    { 
      int min = 0;
      int max = inputArray.Length - 1; 
        while (min <=max)  
        {  
           int mid = (min + max) / 2;  
           if (key == inputArray[mid])  
           {  
                return ++mid;  
           }  
           else if (key < inputArray[mid])  
           {  
               max = mid - 1;  
           }  
           else  
           {  
                min = mid + 1;  
           }  
       }  
       return "Not found";  
    }  
    //And here is the recursive one. Please note that in recursive, 
            //you need to pass min as 0 and max as inputArray.Length - 1
    public static object BinarySearchRecursive(int [] inputArray, int key, int min, int max)  
{  
      if (min > max)  
      {  
          return "Not found";  
      }  
      else  
      {  
          int mid = (min+max)/2;  
          if (key == inputArray [mid])  
          {  
             return ++mid;  
           }  
           else if (key < inputArray [mid])  
           {  
               return BinarySearchRecursive(inputArray, key, min, mid - 1);  
           }  
           else  
           {  
              return BinarySearchRecursive(inputArray, key, mid + 1, max);  
           }  
      }  
 }          //Works only for sorted arrays
        static void Main(string[] args)
        {
            int [] test = new int[]{1,2,3,4,5,6,456,468,98,9,654,64,894,3,464,65,6,4521,
            31,646,4,6,6,546,54,231,34,964,64,964,213,25,5,6,484,13,16,};
            int key = 4521;
            Array.Sort(test);
            System.Console.WriteLine(BinarySearchIterative(test,key));
            System.Console.WriteLine(BinarySearchRecursive(test,key,0,test.Length));
            
        }
    }
}
