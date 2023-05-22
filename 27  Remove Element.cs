//27.Remove Element https://leetcode.cn/problems/remove-element/

//public class Solution //  5/22/2023 7:22 PM
//{
////   public int RemoveElement(int[] nums, int val)
////   {
////      if (nums.Length <= 1)
////        {
////            if (nums.Length == 0) return 0;
////            if (nums.Length == 1 && nums[0] == val) return 0;
////           else return 1;
////      }
//        int n = 0;
//        int i = 0;
//        int c = nums.Length;

//        while (i < nums.Length - 1)
//        {
//            if (nums[i] == val)
//            {
//                //i++;
//                c--;
//                //nums[n] = nums[i];
//            }
//            else
//            {
//                nums[n] = nums[i];
//                n++;
//                // i++;
//            }
//            i++;
//        }

//        if (nums[i] == val)
//        {
//            c--;
//            if (c <= 0)
//                return 0;
//            else return n;
//        }
//        else { nums[n] = nums[i]; return c; }

//    }
//}















//int RemoveElement(int[] nums, int val)
//{
//    if (nums.Length <= 1)
//    {
//        if (nums.Length == 0) return 0;
//        if (nums.Length == 1 && nums[0] == val) return 0;
//        else return 1;
//    }
//    int n = 0;
//    int i = 0;
//    int c = nums.Length;

//    while (i < nums.Length )
//    {
//        if (nums[i] == val)
//        {
//            // i++;
//            c--;
//            //nums[n] = nums[i];
//        }
//        else
//        {
//            nums[n] = nums[i];
//            n++;
//            //i++;
//        }
//        i++;

//    }

//    return c;
