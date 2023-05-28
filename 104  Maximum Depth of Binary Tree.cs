//104. Maximum Depth of Binary Tree https://leetcode.cn/problems/maximum-depth-of-binary-tree/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
//{
//    internal class _104_____Maximum_Depth_of_Binary_Tree
//    {
//    }

//}


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
//public class Solution  //5/28/2023 6:47 PM  	2023/05/28 19:05

//{
//    public class TreeNode
//    {
//        public int val;
//        public TreeNode left;
//        public TreeNode right;
//        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//        {
//            this.val = val;
//            this.left = left;
//            this.right = right;
//        }
//        public int MaxDepth(TreeNode root)
//        {
//            if (root == null) return 0;
//            else
//            {
//                return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
//            }

//        }
//    }
//}
