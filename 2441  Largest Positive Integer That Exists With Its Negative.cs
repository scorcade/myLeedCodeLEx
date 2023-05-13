// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Given an integer array nums that does not contain any zeros, find the largest positive integer k such that -k also exists in the array.

Return the positive integer k. If there is no such integer, return -1.

Input: nums = [-1, 2, -3, 3]
Output: 3
Explanation: 3 is the only valid k we can find in the array.*/


public class Solution
{
    public int FindMaxK(int[] nums)
    {
        int k = -1;
        foreach (int x in nums)
        {
            foreach (int y in nums)
            {
                if (-x == y) k = Math.Max(y, k);
            }
        }
        return k;
    }
}