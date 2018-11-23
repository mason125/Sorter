using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Sorter.stats;
namespace Sorter
{
    //this is the sorting class all the sorting for each 
    //collection type is done here
    public class sort: MathFuncs
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