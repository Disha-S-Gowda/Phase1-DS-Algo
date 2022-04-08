using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class LinkedList
    {
        Node head;
        Node firstNode;

        public LinkedList()
        {

        }

        public void Do()
        {
            firstNode = head = new Node(2);
            var node3 = Insert(head, 3);
            var node4 = Insert(head, 4);
            var node5 = Insert(head, 5);
            Print();
            Delete(node5, node4);
            Print();
            var node6 = Insert(head, 6);
            var node7 = Insert(head, 7);
            Print();
            Delete(node6, node4);
            var node8 = Insert(head, 8);
            Print();
        }

        Node Insert(Node head, int num)
        {
            Node newNode = new Node(num);
            head.next = newNode;
            this.head = newNode;
           return newNode;
        }

        void Delete(Node nodeToDelete, Node previousNode)
        {
            if(nodeToDelete.next == null)
            {
                this.head = previousNode;
            }
            previousNode.next = nodeToDelete.next;
        }

        void Print()
        {
            Node fn = this.firstNode;
            while(fn != null)
            {
                Console.Write(fn.Value + " ");
                fn = fn.next;
            }
            Console.WriteLine("");
        }

    }

    class Node
    {
        public int Value;
        public Node next;

        public Node(int val)
        {
            Value = val;
            next = null;
        }

    }
}
