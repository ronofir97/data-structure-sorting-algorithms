using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class SelectionSort : SortingAlgorithm
    {
        public override void Sort(int[] items)
        {
            Reset();
            int i, j, minimum;
            int size = items.Length;
            for (i = 0; i < size; i++)
            {
                minimum = i;
                for (j = 0; j <size; j++)
                {
                    if (Compare (items[j] , items[minimum] )>0)
                    {
                        minimum = j;
                        Swap( ref items[i],  ref items[minimum]);

                    }
                }
            }
        }
    }
}
        
    

