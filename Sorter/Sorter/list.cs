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
            public static List<T> bubble<T>(List<T> data)
            {

                var al = new ArrayList();
                foreach (dynamic li in data)
                    al.Add(li);


                //sort
                var sorted = sort.bubble(al);


                //convert back to list
                var cl = new List<T>();
                foreach (dynamic li in sorted)
                    cl.Add(li);

                return cl;
            }
            

        }
    }
}
