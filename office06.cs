////office06 https://leetcode.cn/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof/


///*using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class office06
//    {
//    }
//}
//*/



//using System.Collections.Generic;
///**
// * Definition for singly-linked list.
// * public class ListNode {
// *     public int val;
// *     public ListNode next;
// *     public ListNode(int x) { val = x; }
// * }
// */
//public class Solution  //5/28/2023 5:38 PM   2023/05/28 17:52

//{
//  //   // Definition for singly-linked list.
//  //public class ListNode
//  //  {
//  //    public int val;
//  //    public ListNode next;
//  //    public ListNode(int x) { val = x; }
//  //}
//    public int[] ReversePrint(ListNode head)
//    {
//        Stack<ListNode> stack = new Stack<ListNode>();
//        ListNode LN = head;
        
//        while(LN!=null ) { stack.Push(LN); LN = LN.next; }
//        int L=stack.Count;
//        int[] Larry = new int[L];
//        int i=0;
//        foreach(ListNode node in stack)
//        {
//            Larry[i] = node.val;
//            i++;
//        }
//        return Larry;
        
//    }
//}










//public class Solution  //2023/05/28 18:09
//{
//    //public class ListNode
//    //{
//    //    public int val;
//    //    public ListNode next;
//    //    public ListNode(int x) { val = x; }
//    }
//    public int[] ReversePrint(ListNode head)
//    {
//        List<int> list = new List<int>();

//        while (head!=null)
//        {
//            list.Add(head.val);
//            head = head.next;
//        }
//        list.Reverse();
//        return list.ToArray();  

        
//    }
//}
















//public class Solution  //2023/05/28 18:36
//{

//    public class ListNode
//    {
//        public int val;
//        public ListNode next;
//        public ListNode(int x) { val = x; }
//    }
//    public int[] ReversePrint(ListNode head)
//    {
//        List<int> listReversal = new List<int>();

//        void listRecursionReversal(ListNode node)
//        {
//            if (node == null) return;
//            listRecursionReversal(node.next);
//            listReversal.Add(node.val);
//        }

//        listRecursionReversal(head);
//        return listReversal.ToArray();
//    }
//}
