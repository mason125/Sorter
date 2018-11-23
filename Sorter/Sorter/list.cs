using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorter
{
    namespace list_sort
    {
        
        //this class handles all the sorting for Lists generic type
        public class list : sort
        {
           
            //ascending bubble sort method
            public static List<T> ascend_bubbleSort<T>(List<T> data)
            {
                //both lines of code will have the same function in all following methods
                //convert list to arraylist and sort
                var ar = sort.bubbleSort(new ArrayList(data), false);
                
                //convert back to list and pass to main program
                return ar.Cast<T>().ToList();
            }

            //decending reversed bubble
            public static List<T> decend_bubbleSort<T>(List<T> data)
            {
                var ar = sort.bubbleSort(new ArrayList(data), true);
                return ar.Cast<T>().ToList();
            }
            
            //ascending selection sort method
            public static List<T> ascend_selectionSort<T>(List<T> data)
            {
                var ar = sort.selectionSort(new ArrayList(data), false);
                return ar.Cast<T>().ToList();
            }

            // decending revrsed selection sort
            public static List<T> decend_selectionSort<T>(List<T> data)
            {
                var ar = sort.selectionSort(new ArrayList(data), true);
                return ar.Cast<T>().ToList();
            }

            //ascending insertion sort
            public static List<T> ascend_insertionSort<T>(List<T> data)
            {
                var ar = sort.inerstionSort(new ArrayList(data), false);
                return ar.Cast<T>().ToList();
            }

            //decending reverse insertion 
            public static List<T> decend_insertionSort<T>(List<T> data)
            {
                var ar = sort.selectionSort(new ArrayList(data), true);
                return ar.Cast<T>().ToList();
            }
            
            //ascending gnome sort
            public static List<T> ascend_gnomeSort<T>(List<T> data)
            {
                var ar = sort.gnomeSort(new ArrayList(data), false);
                return ar.Cast<T>().ToList();
            }

            //decending reverse gnome
            public static List<T> decend_gnomeSort<T>(List<T> data)
            {
                var ar = gnomeSort(new ArrayList(data), true);
                return ar.Cast<T>().ToList();    
            }

            //math functions.................................
            public static dynamic greatest<T>(List<T> data)
            {
               return selectionSort(new ArrayList(data), false);
            }
        }
    }
}
