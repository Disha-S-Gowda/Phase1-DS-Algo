using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithm
{
    class BinarySearch
    {
        public static int[] array = {23, 24, 26, 28, 30, 32, 43, 53, 63, 74};

        public static void Do()
        {
            int result;
            result = binarySearch(array, 0, array.Length - 1, 43);
            Console.WriteLine("Element found at index " + result);
            result = binarySearch(array, 0, array.Length - 1, 643);
            Console.WriteLine("Element found at index " + result);
        }

        public static int binarySearch(int[] array, int left, int right, int num)
        {
            if(right >= left)
            {
                //Step 1: Find mid element
                int mid = (right + left) / 2;

                //Step 2: Check if mid is the element/num
                if(array[mid] == num)
                {
                    return mid;
                }

                //Step 3: Check if num is less than mid
                if(num < array[mid])
                {
                    return binarySearch(array, left, mid - 1, num);
                }
                else
                {
                    return binarySearch(array, mid + 1, right, num);
                }
            }
            return -1;
        }
    }
}
