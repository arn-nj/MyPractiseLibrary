using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        class Node
        {
            public object Element;
            public Node Next;
        }

        private Node head;

        private int size;

        public int Count
        {
            get
            {
                return size;
            }
        }

        public LinkedList()
        {
            size = 0;
            head = null;
        }

        public void insertFirst(object Content)
        {
            size++;

            var NewNode = new Node();
            NewNode.Element = Content;
            NewNode.Next = head;

            head = NewNode;
        }

        public void insertLast(object Content)
        {
            size++;
            Node tempNode = head;
            Node newNode = new Node();
            newNode.Element = Content;
            newNode.Next = null;

            while (tempNode.Next != null)
                tempNode = tempNode.Next;

            tempNode.Next = newNode;
        }

        public void printList()
        {
            var tempNode = head;

            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Element.ToString());
                tempNode = tempNode.Next;
            }
        }

        public void deleteNode(object content)
        {
            var previousNode = head;
            var currentNode = head;

            while (currentNode != null && currentNode.Element != content)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            if (currentNode != null)
            {               
                previousNode.Next = currentNode.Next;
                currentNode = null;
            }
            else
            {
                Console.WriteLine(content + " Not found");
            }
        }
            


    }
}
