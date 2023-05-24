//58. Length of Last Word https://leetcode.cn/problems/length-of-last-word/solution/


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _58______Length_of_Last_Word
//    {
//    }
//}


//public class Solution   //	2023/05/24 18:33
//{
//    public int LengthOfLastWord(string s)
//    {
//        int L = 0;
//        int index = s.Length - 1;

//        for (; index >= 0; index--)
//        {
//            if (s[index] == ' ')  //char.IsWhiteSpace(s[index])
//            {
//                if (L > 0) { return L; }
//                continue;
//            }
//            L++;
//        }

//        return L;
//    }
//}


//public class Solution //	2023/05/24 18:41
//{
//    public int LengthOfLastWord(string s)
//    {
//        s = s.TrimEnd();
//        string[] strings = s.Split(' ');
//        return strings[strings.Length-1].Length;
//    }
//}

