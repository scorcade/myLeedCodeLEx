// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Given an integer array nums that does not contain any zeros, find the largest positive integer k such that -k also exists in the array.

Return the positive integer k. If there is no such integer, return -1.

Input: nums = [-1, 2, -3, 3]
Output: 3
Explanation: 3 is the only valid k we can find in the array.*/


//public class Solution  //	5/13/2023 2:54 PM 
//{
//    public int FindMaxK(int[] nums)
//    {
//        int k = -1;
//        foreach (int x in nums)
//        {
//            foreach (int y in nums)
//            {
//                if (-x == y) k = Math.Max(y, k);
//            }
//        }
//        return k;
//    }
//}


//public class Solution  //5/13/2023 4:38 PM 
//{
//    public int FindMaxK(int[] nums)
//    {
//        int k = -1;
//        ISet<int> set = new HashSet<int>();

//        foreach (int x in nums) { set.Add(x); }
//        foreach (int x in nums) { if (set.Contains(-x)) k = Math.Max(k, x); }

//        return k;
//    }
//}

