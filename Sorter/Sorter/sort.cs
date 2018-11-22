using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorter
{
    //this is the sorting class all the sorting for each 
    //collection type is done here
    public class sort
    {
        //bubble sort
        protected static ArrayList bubbleSort(ArrayList data)
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

            return data;
        }

        //selection sort 
        protected static ArrayList selectionSort(ArrayList data)
        {
            int count = data.Count;
            
            for(int i = 0; i < count - 1; ++i)
            {
                int min = i;
                for(int j = i+1; j < count; j++)
                {
                    dynamic holder1 = data[j];
                    dynamic holder2 = data[min];

                    if (holder1 < holder2)
                        min = j;

                    dynamic temp = data[min];
                    data[min] = data[i];
                    data[i] = temp;
                }
            }

            return data;
        }

        //insertion sort
        protected static ArrayList inerstionSort(ArrayList data)
        {
            int count = data.Count;

            for (int i = 1; i < count; ++i)
            {
                dynamic key = data[i];
                dynamic j = i - 1;
                dynamic holder = data[j];

                while (j >= 0 && holder > key)
                { 

                    data[j+1] = data[j];

                    --j;
                }

                data[j + 1] = key;
            }

            return data;
        }
    }
}
