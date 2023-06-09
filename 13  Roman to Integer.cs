/*
13.Roman to Integer  罗马数字转整数
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X(10) to make 4 and 9. 
X can be placed before L (50) and C(100) to make 40 and 90. 
C can be placed before D (500) and M(1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

例如， 罗马数字 2 写做 II ，即为两个并列的 1 。12 写做 XII ，即为 X + II 。 27 写做  XXVII, 即为 XX + V + II 。

通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：

I 可以放在 V (5) 和 X(10) 的左边，来表示 4 和 9。
X 可以放在 L (50) 和 C(100) 的左边，来表示 40 和 90。 
C 可以放在 D (500) 和 M(1000) 的左边，来表示 400 和 900。
给定一个罗马数字，将其转换成整数。



Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V = 5, III = 3.*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//public class Solution  // 5/16/2023 8:17 PM 
//{
//    Dictionary<char, int> romaValues = new Dictionary<char, int>()
//        {
//            {'I', 1 },
//            {'V', 5 },
//            {'X', 10 },
//            {'L', 50 },
//            {'C', 100 },
//            {'D', 500 },
//            {'M', 1000 },
//        };

//    public int RomanToInt(string s)
//    {
//        int romaInt = 0;
//        int len=s.Length;

//        for (int i = 0; i < len; i++)
//        {
//            int value= romaValues[s[i]];

//            if (n<len-1 && value < romaValues[s[i+1]])
//            {
//                romaInt -=(int)value;
//            }
//            else
//            {
//                romaInt += (int)value;
//            }
//        }

//        return romaInt;       
//    }
//}






//public class Solution  //5/16/2023 8:52 PM 
//{
//    public int RomanToInt(string s)
//    {
//        // 罗马数字字符和对应的整数值的映射
//        var romanValues = new Dictionary<char, int>()
//        {
//            {'I', 1},
//            {'V', 5},
//            {'X', 10},
//            {'L', 50},
//            {'C', 100},
//            {'D', 500},
//            {'M', 1000}
//        };

//        int result = 0;
//        int prevValue = 0;

//        // 从右往左遍历罗马数字字符串
//        for (int i = s.Length - 1; i >= 0; i--)
//        {
//            int currValue = romanValues[s[i]];

//            // 如果当前字符代表的值小于上一个字符代表的值，则需要减去当前值
//            if (currValue < prevValue)
//            {
//                result -= currValue;
//            }
//            // 否则，将当前值加到结果中
//            else
//            {
//                result += currValue;
//                prevValue = currValue;
//            }
//        }

//        return result;
//    }
//}




//#class Solution:   #5/16/2023 11:47 PM  PYTHON
//#    SYMBOL_VALUES={
//#        'I':1,
//#        'V':5,
//#        'X':10,
//#        'L':50,
//#        'C':100,
//#        'D':500,
//#        'M':1000,
//#        }

//#    def romanToInt(self, s:str)->int:
//#        ans=0
//#        n=len(s)

//#        for i,ch in enumerate(s):
//#            value=Solution.SYMBOL_VALUES[ch]
//#            if i<n-1 and value < Solution.SYMBOL_VALUES[s[i+1]]:
//#                ans -= value
//#            else:
//#                ans += value

//#        return ans
