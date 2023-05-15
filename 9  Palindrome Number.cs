//9.Palindrome Number
//Given an integer x, return true if x is a palindrome, and false otherwise.
//给你一个整数 x ，如果 x 是一个回文整数，返回 true ；否则，返回 false 。

//回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。

//例如，121 是回文，而 123 不是。


//Example 1:

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;

//public class Solution  //  5/15/2023 8:21 PM
//{
//    public bool IsPalindrome(int x)
//    {
//        if (x <0 || (x%10==0 && x!=0 )) return false;

//        int palindromicNumber = 0;
//        while (x > palindromicNumber)
//        {
//            palindromicNumber = x % 10 + palindromicNumber*10 ;
//            x /= 10;
//        }
//        return x == palindromicNumber || x == palindromicNumber / 10;
//    }

//}
