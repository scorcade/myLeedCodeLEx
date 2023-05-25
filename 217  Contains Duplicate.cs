//217. Contains Duplicate  https://leetcode.cn/problems/contains-duplicate/  5/25/2023 11:33 AM 


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
{
    internal class _217_____Contains_Duplicate
    {
    }
}
*/

//using System.Collections;

//public class Solution// 2023/05/25 11:57
//{
//    public bool ContainsDuplicate(int[] nums)
//    {
//        HashSet<int> visited = new HashSet<int>();
//       int L = nums.Length;

//    for (int i = 0; i < L; i++)
//        {
//            if (visited.Contains(nums[i])) return true;
//            visited.Add(nums[i]);
//        }
//    return false;

//    }
//}

//public class Solution
//{
//    public bool ContainsDuplicate(int[] nums)
//    {
//        Dictionary<int, int> result = new Dictionary<int, int>();
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (result.ContainsKey(nums[i]))
//            {
//                return true;
//            }
//            result.Add(nums[i], i);
//        }
//        return false;
//    }
//}
