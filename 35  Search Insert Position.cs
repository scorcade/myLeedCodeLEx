
//35.Search Insert Position  https://leetcode.cn/problems/search-insert-position/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _35______Search_Insert_Position
//    {
//    }
//}

// 5/23/2023 10:01 AM  2023/05/23 10:42
//public class Solution
//{
//    public int SearchInsert(int[] nums, int target)
//    {
//        int L = 0, R = nums.Length - 1;


//        while (L <= R)
//        {
//            int M = (R + L) / 2;
//            if (nums[M] == target) return M;
//            else if (nums[M] < target) L = M + 1;
//            else if (nums[M] > target) R = M - 1;
//        }
//        return L;
//    }
//}




//public class Solution  //  	2023/05/23 12:19
//{
//    public int SearchInsert(int[] nums, int target)
//    {
//        int index = Array.BinarySearch(nums, target);
//        int L = index;

//        if (index < 0) L = ~index;
//        return L;
//    }
//}
