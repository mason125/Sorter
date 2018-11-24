using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorter
{
    namespace arrayList_sort
    {
        public class ArrayListSort : sort
        {
            //ascend bubble
            public static ArrayList ascend_bubble(ArrayList data)
            {
                return bubbleSort(data, false);
            }

            //reverse bubble
            public static ArrayList decend_bubble(ArrayList data)
            {
                return bubbleSort(data, true);
            }

            //ascend selection
            public static ArrayList ascend_selection(ArrayList data)
            {
                return selectionSort(data, false);
            }

            //reverse selection
            public static ArrayList decend_selection(ArrayList data)
            {
                return selectionSort(data, true);
            }

            //ascend insertion
            public static ArrayList ascend_insertion(ArrayList data)
            {
                return inerstionSort(data, false);
            }

            //reverse insertion
            public static ArrayList decend_insertion(ArrayList data)
            {
                return inerstionSort(data, true);
            }

            //ascend gnome
            public static ArrayList ascend_gnome(ArrayList data)
            {
                return gnomeSort(data, false);
            }

            //reverse gnoce
            public static ArrayList decend_gnome(ArrayList data)
            {
                return gnomeSort(data, true);
            }

            //math functions.....................................
            //return last element in collection
            public static dynamic last(ArrayList data)
            {
                return greatest(selectionSort(data, false));
            }

            //return the first element in collection
            public static dynamic first(ArrayList data)
            {
                return least(selectionSort(data, false));
            }

            //only implement this method here this will only work for arraylist
            public static ArrayList ArrayList_Concat(ArrayList list1, ArrayList list2)
            {
                return ArrayListConcat(list1, list2);
            }
        }
    }
}
