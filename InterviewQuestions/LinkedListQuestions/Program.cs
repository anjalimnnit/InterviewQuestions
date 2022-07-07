using System;
using InterviewQuestions;

namespace LinkedListQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            var List1 = new LinkedList<int>();
            List1.AddNode(1);
            List1.AddNode(2);
            List1.AddNode(3);
            List1.AddNode(4);
            Console.WriteLine("Member of List1 are:");
            List1.DisplayLL();
            var List2 = new LinkedList<int>();
            List2.AddNode(5);
            List2.AddNode(6);
            List2.AddNode(7);
            List2.AddNode(8);
            Console.WriteLine("Member of List2 are:");
            List2.DisplayLL();
            MergeTwoSortedListsInReverse obj = new MergeTwoSortedListsInReverse();
            var mergedList = obj.MergeList(List1, List2);
            Console.WriteLine("Member of mergedList in reverse are:");
            mergedList.DisplayLL();
        }
    }
}
