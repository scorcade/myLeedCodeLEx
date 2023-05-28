//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class offic30
//    {
//    }
//}

//using System.Collections;
//using System.Collections.Generic;

//public class MinStack  //2023/05/27 15:22
//{
//    Stack<int> stack = new Stack<int>();
//    Stack<int> m = new Stack<int>();
//    /** initialize your data structure here. */
//    public MinStack()
//    {
//        this.stack =new Stack<int>();
//        this.m = new Stack<int>();
//    }

//    public void Push(int x)
//    {
//        stack.Push(x);
//        if (m.Count == 0) { m.Push(x); }
//        else { m.Push(m.Peek() < x ? m.Peek() : x); }
//    }

//    public void Pop()
//    {
//        stack.Pop();
//        m.Pop();
//    }

//    public int Top()
//    {
//      return  stack.Peek();
//    }

//    public int Min()
//    {
//        return m.Peek();
//    }
//}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.Min();
 */



//public class MinStack //5/28/2023 4:18 PM   ~2023/05/28 17:20
////https://leetcode.cn/problems/bao-han-minhan-shu-de-zhan-lcof/solution/chai-zhi-cun-chu-xiang-xi-ti-jie-yi-kan-1wghu/
//{
//    Stack<long> stackN=new Stack<long>();
//    long num_min;

//    /** initialize your data structure here. */
//    public MinStack()
//    {

//    }

//    public void Push(int x)
//    {
//        if (stackN.Count == 0) { num_min = x; stackN.Push(0); return; }
//        stackN.Push((long)x-num_min);
//        if(x<num_min) { num_min = x; }        

//    }

//    public void Pop()
//    {
//        if(stackN.Peek()<0) { num_min -= stackN.Peek(); }
//        stackN.Pop();
//    }

//    public int Top()
//    {
//        if (stackN.Peek() >= 0) { return (int) (stackN.Peek()+num_min); }
//        else { return (int)num_min; }
//    }

//    public int Min()
//    {
//        return (int)num_min;
//    }
//}

///**
// * Your MinStack object will be instantiated and called as such:
// * MinStack obj = new MinStack();
// * obj.Push(x);
// * obj.Pop();
// * int param_3 = obj.Top();
// * int param_4 = obj.Min();
// */

