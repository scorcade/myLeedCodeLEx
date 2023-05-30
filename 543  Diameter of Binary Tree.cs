//https://leetcode.cn/problems/diameter-of-binary-tree/


////543. Diameter of Binary Tree  
////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace _2441__Largest_Positive_Integer_That_Exists_With_Its_Negative
////{
////    internal class _543_____Diameter_of_Binary_Tree
////    {
////    }
////}

///**
// * Definition for a binary tree node.
// * public class TreeNode {
// *     public int val;
// *     public TreeNode left;
// *     public TreeNode right;
// *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
// *         this.val = val;
// *         this.left = left;
// *         this.right = right;
// *     }
// * }
// */
//public class Solution2
//{
//    public class TreeNode
//    {
//        public int val;
//        public TreeNode left;
//        public TreeNode right;

//        public TreeNode(int val, TreeNode left, TreeNode right)
//        {
//            this.val = val;
//            this.left = left;
//            this.right = right;
//        }

//     }



//    /**
//     * Definition for a binary tree node.
//     * public class TreeNode {
//     *     public int val;
//     *     public TreeNode left;
//     *     public TreeNode right;
//     *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
//     *         this.val = val;
//     *         this.left = left;
//     *         this.right = right;
//     *     }
//     * }
//     */
//    public class Solution  //2023/05/30 12:56
//    {
//        public class Info
//        {
//            public int heigth;
//            public int diameter;

//            public Info(int heigth, int diameter)
//            {
//                this.heigth = heigth;
//                this.diameter = diameter;
//            }
//        }
//        Info RK(TreeNode E)
//        {

//            if (E == null) { return new Info(0, 0); }
//            Info leftNOde = RK(E.left);
//            Info rightNOde = RK(E.right);
//            int heigth = Math.Max(leftNOde.heigth, rightNOde.heigth) + 1;

//            int p1 = Math.Max(leftNOde.diameter, rightNOde.diameter);
//            int p2 = rightNOde.heigth + leftNOde.heigth;
//            int diameter = Math.Max(p1, p2);

//            //heigth = Math.Max(leftNOde.h, rightNOde.h) + 1;
//            //int rigthheigth = info(e.left).heigth;
//            //int leftheigth= info(e.left).heigth;

//            // diameter =info.diameter;

//            return new Info(heigth, diameter);
//        }

//        public int DiameterOfBinaryTree(TreeNode root)
//        {

//            return RK(root).diameter;

//        }
//    }
