using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class MergeSort : SortingAlgorithm
    {
        public override void Sort(int[] items)
        {
            Reset();
            mergsort(items, 0, items.Length - 1);
        }

        public void merg(int[] input, int leftIndx, int middleIndx, int rightIndx)
        {
            int[] leftArray = new int[middleIndx - leftIndx + 1];
            int[] rightArray = new int[rightIndx - middleIndx];
            Array.Copy(input, leftIndx, leftArray, 0, middleIndx - leftIndx + 1);
            Array.Copy(input, middleIndx + 1, rightArray, 0, rightIndx - middleIndx);
            int i = 0, j = 0;
            for (int k = leftIndx; (Compare(rightIndx+1, k) > 0) ; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        private void mergsort(int[] input, int leftIndx, int rightIndx)
        {
         
            if (Compare( rightIndx , leftIndx)>0)
            {
                int middle = (leftIndx + rightIndx) / 2;
                mergsort(input, leftIndx, middle);
                mergsort(input, middle + 1, rightIndx);

                merg(input, leftIndx, middle, rightIndx);
            }
        }
    }
}
