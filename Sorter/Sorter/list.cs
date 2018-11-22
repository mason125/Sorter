using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorter
{
    namespace ListSort
    {
        //this class handles all the sorting for Lists generic type
        public class list : sort
        {
            //bubble sort method
            public static List<T> bubbleSort<T>(List<T> data)
            {
                //both lines of code will have the same function in all following methods
                //convert list to arraylist and sort
                var ar = sort.bubbleSort(new ArrayList(data));
                
                //convert back to list and pass to main program
                return ar.Cast<T>().ToList();
            }

            //selection sort method
            public static List<T> selectionSort<T>(List<T> data)
            {
                var ar = sort.selectionSort(new ArrayList(data));
                return ar.Cast<T>().ToList();
            }

            //insertion sort
            public static List<T> insertionSort<T>(List<T> data)
            {
                var ar = list.inerstionSort(new ArrayList(data));
                return ar.Cast<T>().ToList();
            }
        }
    }
}
