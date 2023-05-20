//20.Valid Parentheses
//    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Every close bracket has a corresponding open bracket of the same type.
// 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

//有效字符串需满足：

//左括号必须用相同类型的右括号闭合。
//左括号必须以正确的顺序闭合。
//每个右括号都有一个对应的相同类型的左括号。


//Example 1:

//Input: s = "()"
//Output: true
//Example 2:

//Input: s = "()[]{}"
//Output: true
//Example 3:

//Input: s = "(]"
//Output: false




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//5/19/2023 10:54 PM


//public class Solution  //  5/21/2023 1:35 AM
//{
//    public bool IsValid(string s)
//    {
//        var len = s.Length;
//        if (len %2== 1) return false;
//        if (s[0] == '}' || s[0] == ']' || s[0] == ')'  ) return false;
//        var stack=new Stack<char>();

//        //stack.Push(s[0]);
//        for (int i = 0; i < len; i++)
//        {

//            if (s[i] == '{' || s[i] == '[' || s[i] == '(')
//            {
//                stack.Push(s[i]);
//            }
//            else
//            {
//                if (stack.Count == 0) return false;
//                else
//                {
//                    int v = s[i] - stack.Peek();
//                    if (stack.Count != 0 && (v == 1 || v == 2)) { stack.Pop(); }
//                    else { return false; }

//                }
//            }
//        }
//        return stack.Count == 0;
//    }
//}





//public class Solution   ///5/21/2023 2:12 AM  

//{
//    public bool IsValid(string s)
//    {
//        Stack<char> stack = new Stack<char>();
//         Hashtable ht = new Hashtable() { { ')','('}, {']','[' }, { '}', '{' } };

//        int sLen = s.Length;    
//        for (int i = 0; i < sLen; i++)
//        {
//            if (ht.ContainsValue(s[i]))
//            {
//                stack.Push(s[i]);
//            }
//            else if (stack.Count==0 || stack.Pop() != (char)ht[s[i]]) 
//            {
//                return false;
//            }
//        }
//        return stack.Count == 0;

//    }
//}





















