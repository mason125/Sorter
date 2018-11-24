using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Sorter.stats;
namespace Sorter
{
    /*
     * When comparing a char to a value the C# will compare the char's 
     * character code.  As such you may get a char mixed in with a
     * digit whether it be an int or double.  
     */

    public class sort : Funcs
    {
        //bubble sort
        protected static ArrayList bubbleSort(ArrayList data, bool reverse)
        {
            int count = data.Count;

            for (int i = 0; i < count - 1; ++i)
            {
                for (int j = 0; j < count - i - 1; ++j)
                {
                    dynamic holder1 = data[j];
                    dynamic holder2 = data[j + 1];

                    if (holder1 > holder2)
                    {
                        dynamic temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }

            return reverse_data(data, reverse);
        }

        //selection sort 
        protected static ArrayList selectionSort(ArrayList data, bool reverse)
        {
            int count = data.Count;

            for (int i = 0; i < count - 1; ++i)
            {
                dynamic min = i;
                for (int j = i + 1; j < count; ++j)
                {
                    dynamic holder1 = data[j];
                    dynamic holder2 = data[min];

                    if (holder1 < holder2)
                        min = j;

                }
                dynamic temp = data[min];
                data[min] = data[i];
                data[i] = temp;
            }
            return reverse_data(data, reverse);
        }


        //insertion sort
        protected static ArrayList inerstionSort(ArrayList data, bool reverse)
        {
            int count = data.Count;

            for (int i = 1; i < count; ++i)
            {
                dynamic key = data[i];
                dynamic j = i - 1;

                while (j >= 0 && data[j] > key)
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                    //j;
                }
                data[j + 1] = key;
            }
            return reverse_data(data, reverse);
        }

        //gnome sort
        public static ArrayList gnomeSort(ArrayList data, bool reverse)
        {
            dynamic index = 0;
            dynamic n = data.Count;
            while (index < n)
            {
                if (index == 0)
                    index++;

                if (data[index] >= data[index - 1])
                    index++;

                else
                {
                    dynamic temp = 0;
                    temp = data[index];
                    data[index] = data[index - 1];
                    data[index - 1] = temp;
                    index--;
                }
            }
            return reverse_data(data, reverse);
        }

        //heap sort
        public static ArrayList heapsort(ArrayList data, bool reverse)
        {
            int n = data.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(data, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                dynamic temp = data[0];
                data[0] = data[i];
                data[i] = temp;
                heapify(data, i, 0);
            }

            return reverse_data(data, reverse);
        }

        //heap sort heapify.  heap sort method componet 
        private static ArrayList heapify(ArrayList data, dynamic n, dynamic i)
        {
            dynamic largest = i;
            dynamic left = 2 * i + 1;
            dynamic right = 2 * i + 2;

            if (left < n && data[left] > data[largest])
                largest = left;

            if (right < n && data[right] > data[largest])
                largest = right;

            if (largest != i)
            {
                dynamic swap = data[i];
                data[i] = data[largest];
                data[largest] = swap;
                heapify(data, n, largest);
            }

            return data;
        }

        //reverse arraylist
        private static ArrayList reverse_data(ArrayList data, bool reverse)
        {
            //return non reversed
            if (!reverse)
                return data;
            //return reversed 
            else
            {
                data.Reverse();
                return data;
            }
        }
    }
}