//https://leetcode.cn/problems/remove-duplicates-from-sorted-array/
//5/21/2023 11:42 PM 

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _26______Remove_Duplicates_from_Sorted_Array
//    {
//    }
//}
//public class Solution   5/22/2023 12:20 AM 
//{
//    public int RemoveDuplicates(int[] nums)
//    {
//        if (nums == null) return 0;
//        int numsLen = nums.Length;
//        if (numsLen == 1) return 1;


//        int slowP = 1, fastP = 1;

//        for (; fastP < numsLen; fastP++)
//        {
//            if (nums[fastP - 1] != nums[fastP])
//            {
//                nums[slowP] = nums[fastP];
//                slowP++;
//            }
//            //fastPointer++;
//        }

//        return slowP;
//    }
//}



//public class Solution // 5/22/2023 1:16 AM 
//{
//    public int RemoveDuplicates(int[] nums)
//    {
//        //if(nums.Length <= 1) return nums.Length;
//        // int[] nums2 = nums.Distinct().ToArray();  // IEnumerable<int> nums2 = nums.Distinct();
//        var nums2 = nums.Distinct();
//        int n = 0;
//        foreach (var item in nums2)
//        {
//            nums[n++] = item;
//        }
//        //int mn = nums.Count();

//        return n;
//    }
//}
