//70. Climbing Stairs https://leetcode.cn/problems/climbing-stairs/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _70______Climbing_Stairs
//    {
//    }
//}

//public class Solution  //2023/05/27 14:31
//{
//    public int ClimbStairs(int n)
//    {


//        if (n == 1) { return 1; }
//        if (n == 2) { return 2; }
//        int[] arr = new int[n + 1];
//        arr[1] = 1;
//        arr[2] = 2;

//        for (int i = 3; i <= n; i++)
//        {
//            arr[i] = arr[i - 1] + arr[i - 2];

//        }

//        return arr[n];
//    }
//}
