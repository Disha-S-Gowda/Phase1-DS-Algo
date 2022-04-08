using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Queue
    {
        int[] array;
        int maxsize;
        int front;
        int rear;

        public Queue()
        {
            this.maxsize = 5;
            this.array = new int[maxsize];
            this.front = this.rear = -1;
        }

        public void Do()
        {
            Insert(2);
            Insert(7);
            Insert(4);
            Print();
            Console.WriteLine();
            Delete();
            Print();
            Console.WriteLine();
            Insert(8);
            Insert(9);
            Print();
            Console.WriteLine();
        }

        void Insert(int num)
        {
            // Check if queue is full
            if(this.rear == maxsize -1 && this.front == 0)
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                //if front is -1, set it to 0
                if(front == -1)
                {
                    front = 0;
                }
                //increment read and add value
                rear = rear + 1;
                array[rear] = num;
            }
        }

        int Delete()
        {
            //check if queue is empty
            if(front == -1 && rear == -1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int num = array[front];
                if(front >= rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = front + 1;
                }
                return num;
            }
        }

        void Print()
        {
            for(int i = front; i <= rear; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
