using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithLink_list
{
    public class node
    {
        public int Value;
        public node Next;
        public int Prior;
        public node prev;
    }
    public class PriorityQueue
    {
        node head = null;
        public bool IsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(int value, int priority)
        {
            node node = new node();
            if (IsNull())
            {
                node.Value = value;
                node.Prior = priority;
                node.Next = null;
                head = node;
            }
            else
            {
                node afternode = new node();
                node head2 = head;
                while (head2.Next != null)
                {
                    head2 = head2.Next;
                }
                afternode.Value = value;
                afternode.Prior = priority;
                afternode.Next = null;
                head2.Next = afternode;

            }

        }
        public void Remove()
        {
            if (IsNull())
            {
                Console.WriteLine("list is empty...!");
            }
            else
            {

            }
        }

        public void print()
        {
            node printhead = head;
            while (printhead != null)
            {
                Console.WriteLine(printhead.Value);
                printhead = printhead.Next;
            }

        }
        public void Dequeue()
        {
            if (!IsNull())
            {
                node tempHead = head;
                node min = tempHead;

                while (tempHead.Next != null)
                {
                    tempHead = tempHead.Next;
                    if (min.Prior > tempHead.Prior)
                    {
                        min = tempHead;
                    }
                }

                if (min == head)
                {
                    tempHead = head.Next;
                    head = null;
                    head = tempHead;
                }
                else if (min.Next == null)
                {
                    min.prev.Next = null;
                }
                else
                {
                    var tempBeforeNode = min.prev;

                    min.prev.Next = min.Next.prev;

                    min.Next.prev = min.prev.Next;



                }
            }
            else
            {
                Console.WriteLine("Queue Is Null!");
            }
        }


    }
}
