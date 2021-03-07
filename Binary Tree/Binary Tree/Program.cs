using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = null;
            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                //int x = rng.Next(0, 400);
                int inputNode = Convert.ToInt32(Console.ReadLine());
                TreeNode n = new TreeNode(inputNode);
                if (root == null)
                {
                    Console.WriteLine("Setting " + n.value + " to the root");
                    root = n;
                }
                else
                {
                    n.NewNode(root);
                }
            }
        }
    }
}
