//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。
//你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
//你可以按任意顺序返回答案。


//Example 1:

//Input: nums = [2, 7, 11, 15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Solution  //5/14/2023 7:55 AM 
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        int n = nums.Length;
//        int[] ind = new int[2] { 0,0 };

//        for (int i = 0; i <n; i++)
//        {
//            for (int j = i+1; j <n ; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    ind[0]=i; ind[1]=j;
//                    return ind;
//                }
//            }
//        }

//        return ind;
//    }
//}





//public class Solution  //5/14/2023 8:46 AM 
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        Dictionary<int,int> twoNums=new Dictionary<int,int>();
//        int numsLength=nums.Length;

//        for (int i = 0;i< numsLength; i++)
//        {
//            if (twoNums.ContainsKey(target-nums[i]))
//            {
//                return new int[] { twoNums[target-nums[i]], i};
//            }
//            else
//            {
//                twoNums[nums[i]] = i;
//            }
//        }    

//        return new int[] { 0, 0 }; 
//    }
//}
