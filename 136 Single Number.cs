//public class Solution
//{
//    public int SingleNumber(int[] nums)
//    {
//        int n = 0;
//        foreach (int x in nums) n ^= x;
//        return n;
//    }
//}












//public static int SingleNumber(int[] nums)  //2023/05/29 16:45
//{
//       HashSet<int> result = new HashSet<int>();

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (!result.Add(nums[i])) { result.Remove(nums[i]); }
//    }
//    return result.First();

//}
