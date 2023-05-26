//704. Binary Search  https://leetcode.cn/problems/binary-search/
//public class Solution //2023/05/26 12:49
//{
//    public int Search(int[] nums, int target)
//    {
//        int indexSrat = 0;
//        int indexEnd = nums.Length - 1;


//        while (indexSrat <= indexEnd)
//        {
//            int indexMin = (indexEnd + indexSrat) / 2;

//            if (nums[indexMin] == target) { return indexMin; }
//            if (nums[indexMin] < target) { indexSrat = indexMin + 1; }
//            else { indexEnd = indexMin - 1; }

//        }
//        return -1;
//    }
//}

