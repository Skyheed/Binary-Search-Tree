using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    public class TreeNode
    {
        public int value;
        public TreeNode right;
        public TreeNode left;

        public TreeNode (int data)
        {
            value = data;
            left = null;
            right = null;
        }

        public void NewNode(TreeNode root)
        {
            if (root == null)
            {
                Console.WriteLine("Root var ikke null");
                return;
            }
            else if (root.value == value)
            {
                Console.WriteLine("Ingen gentagelser. Tallet er skrevet før");
                return;
            }
            else if (value < root.value)
            {
                if (root.left != null)
                {
                    NewNode(root.left);
                }
                else
                {
                    Console.WriteLine("Added " + value + " to the left of " + root.value);
                    root.left = this;
                }
            }
            else if (value > root.value)
            {
                if (root.right != null)
                {
                    NewNode(root.right);
                }
                else
                {
                    Console.WriteLine("Added " + value + " to the right of " + root.value);
                    root.right = this;
                }
            }
        }
    }
}
