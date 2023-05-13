
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
