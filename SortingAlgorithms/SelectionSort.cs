using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Execute()
        {
            /// Selection Sort
            int[] arr = new int[] { 2, 7, 3, 1, 5, 6, 4 };
            int i, j, i_min;
            for (i = 0; i < arr.Length - 1; i++)
            {
                i_min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i_min] > arr[j])
                    {
                        i_min = j;
                    }
                }
                int aux = arr[i_min];
                arr[i_min] = arr[i];
                arr[i] = aux;
            }

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
