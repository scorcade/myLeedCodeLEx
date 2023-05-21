// https://leetcode.cn/problems/merge-two-sorted-lists/

// https://leetcode.cn/problems/merge-two-sorted-lists/



//You are given the heads of two sorted linked lists list1 and list2.

//Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

//Return the head of the merged linked list.



//Example 1:


//Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
//Output: [1,1,2,3,4,4]
//Example 2:

//Input: list1 = [], list2 = []
//Output: []
//Example 3:

//Input: list1 = [], list2 = [0]
//Output: [0]


//Constraints:

//The number of nodes in both lists is in the range [0, 50].
//-100 <= Node.val <= 100
//Both list1 and list2 are sorted in non-decreasing order.


//using System.Xml.Linq;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _21______Merge_Two_Sorted_Lists
//    {
//    }
//}



/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

//public class ListNode  //  5/21/2023 11:26 PM 
//{
//    public int val;
//    public ListNode next;
//    public ListNode(int val = 0, ListNode next = null)
//    {
//        this.val = val;
//        this.next = next;
//    }
// }
//public class Solution
//{
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//        var head=new ListNode(0);
//        var prev = head;

//        while(list1 != null && list2!=null)
//        {
//            if (list1.val <= list2.val) { prev.next = list1; list1 = list1.next; }
//            else { prev.next = list2; list2 = list2.next; }
//            prev =prev.next;
//        }
//        if(list1 == null) {prev.next=list2 ;}
//        if(list2 == null) {prev.next=list1 ;}

//        return head.next;
//    }
//}

//    public class Solution  //5/21/2023 11:35 PM 
//{
//    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
//    {
//            if (list1 == null) return list2; 
//            if (list2 == null) return list1; 

//            if (list1.val < list2.val)
//            {
//                list1.next = MergeTwoLists(list1.next,list2);
//                return list1;
//            }
//            else 
//            {
//                list2.next = MergeTwoLists(list2.next, list1);
//                return list2;
//            }

//        }
//}
