using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.insertFirst(10);
            list.insertLast(20);
            list.insertFirst(0);
            list.insertLast(30);
            list.insertLast(40);

            list.printList();

            list.deleteNode(30);

            list.printList();
            Console.Read();
        }
    }
}
