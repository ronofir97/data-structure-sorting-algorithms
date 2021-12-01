using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class QuiqSort : SortingAlgorithm
    {

        public override void Sort(int[] items)
        {
            Reset();
            QuickSort(items, 0, items.Length - 1);
        }

            public void QuickSort(int[] arr, int startIndx, int endIndx)
            {
            int i;
            if (Compare(endIndx, startIndx) > 0)
            {
                i = Partition(arr, startIndx, endIndx);

                QuickSort(arr, startIndx, i - 1);
                QuickSort(arr, i + 1, endIndx);
            }
        }

        public int Partition(int[] array, int startIndx, int endIndx)
        {
            
            int p = array[endIndx];
            int i = startIndx - 1;
            for (int j = startIndx; j <= endIndx - 1; j++)
            {
                if (array[j] <= p)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }
        
            Swap(ref array[i+1], ref array[endIndx]);
            return i + 1;
        }
    }
}
