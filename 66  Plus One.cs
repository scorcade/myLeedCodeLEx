//66. Plus One https://leetcode.cn/problems/plus-one/solution/  


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _66______Plus_One
//    {
//    }
//}


//public class Solution //5/24/2023 6:57 PM    2023/05/24 19:07

//{
//    public int[] PlusOne(int[] digits)
//    {
//        int L = digits.Length;

//        for (int i = L - 1; i >= 0; i--)
//        {
//            if (digits[i] != 9)
//            {
//                digits[i]++;

//                for (int j = i + 1; j < L; j++) { digits[j] = 0; }
//                return digits;
//            }

//        }

//        int[] newDigits = new int[L + 1];
//        newDigits[0] = 1;
//        return newDigits;
//    }
//}


//public class Solution // 2023/05/24 19:41
//{
//    public int[] PlusOne(int[] digits)
//    {
//        int index = Array.LastIndexOf(digits, digits.Reverse().FirstOrDefault(x => x != 9));
//        if (index < 0)
//        {
//            Array.Resize(ref digits, digits.Length + 1); digits = digits.Select(x => 0).ToArray();
//            digits[0] = 1;
//        }
//        else
//        {
//            digits[index]++;
//            for (int i = index + 1; i < digits.Length; i++) { digits[i] = 0; }
//        }
//        return digits;
//    }
//}
