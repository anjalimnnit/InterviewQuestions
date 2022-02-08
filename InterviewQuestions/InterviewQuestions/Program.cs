using System;

namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a binary tree");
            BinaryTreeTraversal binaryTree = new();
            binaryTree.root = new Node(1);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(3);
            binaryTree.root.right.left = new Node(5);
            binaryTree.root.right.right = new Node(6);
            binaryTree.root.left.left = new Node(7);
            binaryTree.root.left.right = new Node(8);

            Console.WriteLine("Preorder traversal "
                          + "of binary tree is ");
            binaryTree.PrintPreorder(binaryTree.root);

            Console.WriteLine("\nInorder traversal "
                              + "of binary tree is ");
            binaryTree.PrintInorder(binaryTree.root);

            Console.WriteLine("\nPostorder traversal "
                              + "of binary tree is ");
            binaryTree.PrintPostorder(binaryTree.root);

            Console.WriteLine();
            // Minimum Platform problem
            MinimumNoOfPlatforms platform = new();
            int[] arr = { 900, 940, 950, 1100, 1500, 1800 };
            int[] dep = { 910, 1200, 1120, 1130, 1900, 2000 };
            int n = arr.Length;
            Console.WriteLine("Minimum Number of "
                          + " Platforms Required = "
                          + platform.FindPlatform(arr, dep, n));

            // Minimum jumps problem
            int[] arr1 = new int[] { 1, 3, 5, 8, 9, 2,
                                6, 7, 6, 8, 9 };

            // calling minJumps method
            MinimumNoOfJumps minJumps = new MinimumNoOfJumps();
            Console.Write($"Mininum no of jumps required = {minJumps.MinJumps(arr1)}");

            // Reverse a stack
            ReverseStackRecursion reverse = new ReverseStackRecursion();
            reverse.ReverseStack();
        }
    }
}
