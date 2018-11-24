using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sorter
{
    namespace array_sort
    {
        public class array : sort
        {
            //ascending bubble
            public static T[] ascend_bubble<T>(params T[] data)
            {
                //convert array to arraylist
                var ar = bubbleSort(new ArrayList(data), false);
                return ar.Cast<T>().ToArray();
            }

            //reverse bubble
            public static T[] descend_bubble<T>(params T[] data)
            {
                var ar = bubbleSort(new ArrayList(data), true);
                return ar.Cast<T>().ToArray();
            }

            //ascending selection
            public static T[] ascend_selection<T>(params T[] data)
            {
                var ar = selectionSort(new ArrayList(data), false);
                return ar.Cast<T>().ToArray();
            }

            //reverse selection
            public static T[] descend_selection<T>(params T[] data)
            {
                var ar = selectionSort(new ArrayList(data), true);
                return ar.Cast<T>().ToArray();
            }

            //ascending insertion
            public static T[] ascend_insertion<T>(params T[] data)
            {
                var ar = inerstionSort(new ArrayList(data), false);
                return ar.Cast<T>().ToArray();
            }

            //reverse insertion
            public static T[] decend_insertion<T>(params T[] data)
            {
                var ar = inerstionSort(new ArrayList(data), true);
                return ar.Cast<T>().ToArray();
            }

            //ascending gnome
            public static T[] ascend_gnome<T>(params T[] data)
            {
                var ar = gnomeSort(new ArrayList(data), false);
                return ar.Cast<T>().ToArray();
            }

            //reverse gnome
            public static T[] decend_gnome<T>(params T[] data)
            {
                var ar = gnomeSort(new ArrayList(data), true);
                return ar.Cast<T>().ToArray();
            }

            //ascending heap
            public static T[] ascend_heap<T>(params T[] data)
            {
                var ar = heapsort(new ArrayList(data), false);
                return ar.Cast<T>().ToArray();
            }

            //reverse heap
            public static T[] decend_heap<T>(params T[] data)
            {
                var ar = heapsort(new ArrayList(data), true);
                return ar.Cast<T>().ToArray();
            }
            //math functions...................................
            //return last element in the array
            public static dynamic last<T>(params T[] data)
            {
                return greatest(selectionSort(new ArrayList(data), false));
            }

            //return first element in array
            public static dynamic first<T>(params T[] data)
            {
                return least(selectionSort(new ArrayList(data), false));
            }
        }
    }
}
