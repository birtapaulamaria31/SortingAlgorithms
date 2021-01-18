using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void Execute()
        {
            /// Insertion Sort
            int[] arr = new int[] { 2, 7, 3, 1, 5, 6, 4 };
            int i, j;
            for (i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] >= key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
