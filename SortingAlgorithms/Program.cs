using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        public static void Interclasare(int[] arr, int low, int mid, int high)
        {
            int n = mid - low + 1;
            int m = high - mid;

            int[] L, R;

            L = new int[n];
            R = new int[m];

            int i, j, k;
            for (i = 0; i < n; i++)
            {
                L[i] = arr[low + i];
            }
            for (i = 0; i < m; i++)
            {
                R[i] = arr[mid + i + 1];
            }

            i = 0; j = 0; k = low;

            while (i < n && j < m)
            {
                if (L[i] < R[j])
                {
                    arr[k] = L[i];
                    i++;
                } else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < m)
            {
                arr[k] = R[j];
                j++;
                k++;

            }

        }

       public static void MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int m = (low + high) / 2;
                MergeSort(arr, low, m);
                MergeSort(arr, m + 1, high);
                Interclasare(arr, low, m, high);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 3, 1, 5, 6, 4 };
            MergeSort(arr, 0, arr.Length - 1);
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
