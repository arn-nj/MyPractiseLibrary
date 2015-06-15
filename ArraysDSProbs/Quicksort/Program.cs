using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main()
        {
            //define an array to demonstrate
            int[] a = { 6, 2, 9, 1, 8, 4, 5, 3, 7 };

            QuickSort(a, 0, (a.Length));
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //Divide and conquer. - divide Until the pivot and call recursively
        static void QuickSort(int[] a, int low, int high)
        {

            //Intially we assume pivot is the last element. 
            //Partition method will choose a correct place for pivot and 
            //then return the index of the path 
            //so that we can call recursively by Div and conq
            if(low<high)
            {
            int pivot = Partition(a, low, high);
            QuickSort(a, low, pivot);
            QuickSort(a, pivot + 1, high);
            }

        }
        /// <summary>
        /// Partition will choose the last element as Pivot and then rearranges the array to get the correct spot for Pivot
        /// </summary>
        /// <param name="a"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private static int Partition(int[] a, int low, int high)
        {
            
            int pivotElement = a[high-1];
            int pivotIndex = low;

            for (int i = low; i < high-1; i++)
            {
                //if the element is less than pivot put them to the left.
                if (a[i] <= pivotElement)
                {
                    swap(ref a[i], ref a[pivotIndex]);
                    pivotIndex += 1;
                }
            }
            swap(ref a[high-1], ref a[pivotIndex]);
            return pivotIndex;
        }

        private static void swap(ref int p1, ref int p2)
        {
            var temp = p1;
            p1 = p2;
            p2 = temp;
        }
    

    }
}
