using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProblems
{
    class SortingAlgorithms
    {
        public int[] MergeSort(int[] array)
        {
            return MergeSort(array, 0, array.Length - 1);
        }

        private int[] MergeSort(int[] array, int low, int high)
        {
            if (low != high)
            {
                int mid = (low + high) / 2;
                MergeSort(array, low, mid);
                MergeSort(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
            return array;
        }

        private void Merge(int[] array, int low, int mid, int high)
        {
            int i = 0, j = 0, k = low;

            int[] lowHalf = new int[(mid + 1) - low];
            int[] highHalf = new int[high - mid];

            for (i = 0; k <= mid; i++, k++)
                lowHalf[i] = array[k];

            for (j = 0; k <= high; j++, k++)
                highHalf[j] = array[k];

            i = 0; j = 0; k = low;

            while (i < lowHalf.Length && j < highHalf.Length)
            {
                if (lowHalf[i] <= highHalf[j])
                    array[k] = lowHalf[i++];
                else
                    array[k] = highHalf[j++];
                k++;
            }

            while (i < lowHalf.Length)
                array[k++] = lowHalf[i++];

            while (j < highHalf.Length)
                array[k++] = highHalf[j++];

        }

        private void swap(int[] array, int i, int j)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}