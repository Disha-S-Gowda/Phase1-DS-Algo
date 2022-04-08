 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Stack
    {
        int[] array;
        int topPointer = -1;
        int maxsize;

        public void Do()
        {
            Stack stack = new Stack();
            stack.maxsize = 5;
            stack.array = new int[5];
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Pop();
            stack.Pop();
            stack.Print();
            Console.WriteLine();
            stack.Push(7);
            stack.Push(8);
            stack.Print();
            Console.WriteLine();
        }

        void Push(int num)
        {
            //1. Check if stack is full.
            if(this.topPointer == this.maxsize - 1)
            {
                Console.WriteLine("");
            }
            else
            {//increment topPointer and store the value
                this.topPointer = this.topPointer + 1;
                array[topPointer] = num;
            }
        }

        int Pop()
        {
            //Check if stack is empty
            if(this.topPointer == -1)
            {
                Console.WriteLine();
                return -1;
            }
            else
            {//get value and decrement the topPointer
                int element = array[topPointer];
                topPointer = topPointer - 1;
                return element;
            }
        }

        void Print()
        {
            Console.WriteLine(array[topPointer]);
        }

    }
}
