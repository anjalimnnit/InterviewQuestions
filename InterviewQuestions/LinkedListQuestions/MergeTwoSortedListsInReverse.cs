
using InterviewQuestions;

namespace LinkedListQuestions
{
    class MergeTwoSortedListsInReverse
    {
        public LinkedList<int> MergeList(LinkedList<int> ll1, LinkedList<int> ll2)
        {
            if (ll1.head == null && ll2.head == null)
                return null;
            var mergedList = new LinkedList<int>();
            if (ll1.head == null)
            {
                while(ll2.head!=null)
                {
                    mergedList.AddNodeBegin(ll2.head.data);
                    ll2.head = ll2.head.next;
                }
            }
            if (ll2.head == null)
            {
                while (ll1.head != null)
                {
                    mergedList.AddNodeBegin(ll1.head.data);
                    ll1.head = ll1.head.next;
                }
            }
            var first = ll1.head.data < ll2.head.data ? ll1 : ll2;
            var second = ll1.head.data > ll2.head.data ? ll1 : ll2;
            while(first.head!=null)
            {
                mergedList.AddNodeBegin(first.head.data);
                first.head = first.head.next;
            }
            while (second.head != null)
            {
                mergedList.AddNodeBegin(second.head.data);
                second.head = second.head.next;
            }
            return mergedList;
        }
        
    }
}
