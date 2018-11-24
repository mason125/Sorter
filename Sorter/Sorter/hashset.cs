using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorter
{
    namespace hashset_sort
    {
        /*
        Converting from hastset to ArrayList for sorting can be very complex with many steps.
        Each method has to be converted many times using a custom converstion method
        that converts and selects the necessary sorting method all at one shot.
        */
        public class hashset: sort
        {
            //asending bubble
            public static HashSet<T> ascend_bubble<T>(HashSet<T> data)
            {
                return pass(data, "bubble", false);
            }

            //descending bubble
            public static HashSet<T> decend_bubble<T>(HashSet<T> data)
            {
                return pass(data, "bubble", true);
            }

            //ascend selection
            public static HashSet<T> ascend_selection<T>(HashSet<T> data)
            {
                return pass(data, "selection", false);
            }

            //descending selection
            public static HashSet<T> decend_selection<T>(HashSet<T> data)
            {
                return pass(data, "selection", true);
            }

            //ascend insert
            public static HashSet<T> ascend__insert<T>(HashSet<T> data)
            {
                return pass(data, "insert", false);
            }

            //decend insert
            public static HashSet<T> decend_insert<T>(HashSet<T> data)
            {
                return pass(data, "insert", true);
            }

            //ascend gnome
            public static HashSet<T> ascend_gnome<T>(HashSet<T> data)
            {
                return pass(data, "gnome", false);
            }

            //decend gnome
            public static HashSet<T> decend_gnome<T>(HashSet<T> data)
            {
                return pass(data, "gnome", true);
            }

            //math function..........................................
            //last element in hashset
            public static dynamic first<T>(HashSet<T> data)
            {
                return greatest(selectionSort(new ArrayList(data.Cast<T>().ToList()), false));
            }

            public static dynamic last<T>(HashSet<T> data)
            {
                return least(selectionSort(new ArrayList(data.Cast<T>().ToList()), true));
            }
            //.......................................................
            
            //sorting the hashset
            private static HashSet<T> pass<T>(HashSet<T> data, string name, bool selection)
            {
                var ar = new ArrayList(data.Cast<T>().ToList());// convert hastset to ArrayList

                switch (name)
                {
                    case "bubble":
                        ar = bubbleSort(ar, selection);
                        break;

                    case "selection":
                        ar = selectionSort(ar, selection);
                        break;

                    case "insert":
                        ar = inerstionSort(ar, selection);
                        break;

                    case "gnome":
                        ar = gnomeSort(ar, selection);
                        break;
                }

                return (new HashSet<T>(ar.Cast<T>().ToList()));
            }
        }
    }
}
