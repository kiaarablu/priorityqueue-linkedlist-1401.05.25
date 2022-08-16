using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithLink_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue a = new PriorityQueue();
            a.Add(20, 1);
            a.Add(30, 5);
            a.Add(40, 6);
            a.Add(50, 2);
            a.Add(60, 3);
            a.Add(70, 4);
            a.Dequeue();
            a.print();
            Console.ReadKey();
        }
    }
}
