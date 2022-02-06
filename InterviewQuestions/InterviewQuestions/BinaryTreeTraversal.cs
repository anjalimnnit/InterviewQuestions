using System;

namespace InterviewQuestions
{
    public class BinaryTreeTraversal
    {
       public Node root;
        public BinaryTreeTraversal()
        {
            root = null;
        }
        public void PrintPreorder(Node root)
        {
            if (root == null)
                return;
            Console.Write(root.value);
            PrintPreorder(root.left);
            PrintPreorder(root.right);
        }
        public void PrintInorder(Node root)
        {
            if (root == null)
                return;
            PrintInorder(root.left);
            Console.Write(root.value);
            PrintInorder(root.right);
        }
        public void PrintPostorder(Node root)
        {
            if (root == null)
                return;
            PrintPostorder(root.left);
            PrintPostorder(root.right);
            Console.Write(root.value);
        }

    }
}
