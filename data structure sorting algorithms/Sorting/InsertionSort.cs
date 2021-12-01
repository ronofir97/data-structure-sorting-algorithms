using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class InsertionSort : SortingAlgorithm
    {
        public override void Sort(int[] items)
        {
            Reset();
            InsertionSor1t(items);

        }



        public void InsertionSor1t(int[] array)
        {


            int j, tmp;
            int size = array.Length;
            for (int i = 1; i <= size - 1; i++)
            {
                tmp = array[i];
                j = i - 1;
                while (j >= 0 && Compare(array[j], tmp) > 0)
                {

                    array[j + 1] = array[j];
                    j--;

                }
                array[j + 1] = tmp;
            }
        }
    }
}
    

