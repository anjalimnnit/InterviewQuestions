using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class LinkedList<T>
    {
        public class LNode<T>
            {
            public T data;
            public LNode<T> next;
            public LNode(T data)
            {
                this.data = data;
            }
            }
        LNode<T> head = null;
        public void AddNode(T x)
        {
            LNode<T> n = new LNode<T>(x);
            if (head == null)
            {
                head = n;
            }
            else
            {
                var h = head;
                while(h.next !=null)
                {
                    h = h.next;
                }
                h.next = n;
              
            }
            n.next = null;
        }

        public void DeleteNode()
        {
            if(head==null)
            {
                Console.WriteLine("Empty ll");
                return;
            }
            if(head.next == null)
            {
                head = null;
                return;
            }
            var x = head;
            while (x.next.next != null)
            {
                x = x.next;
            }
            x.next = null;
        }

        public void DisplayLL()
        {
            var x = head;
            while(x!=null)
            {
                Console.WriteLine(x.data);
                x = x.next;
            }
        }
    }
}
