using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class HeapSort : SortingAlgorithm
    {
        public override void Sort(int[] items)
        {
            Reset();
            int size = items.Length;
            for (int i = size / 2 - 1; i >= 0; i--)
                heapify(items, size, i);
            for (int i = size - 1; i > 0; i--)
            {
                Swap(ref items[0], ref items[i]);
                heapify(items, i, 0);
            }
        }


        public void heapify(int[] array, int size, int indx)
        {
            int largest = indx;
            int l = 2 * indx + 1;
            int r = 2 * indx + 2;
            if (l < size && Compare( array[l] , array[largest])>0)
                largest = l;
            if (r < size && Compare( array[r] , array[largest])>0)
                largest = r;
            if (largest != indx)
            {
                Swap(ref array[indx], ref array[largest]);
                heapify(array, size, largest);
            }
        }

    }
}
