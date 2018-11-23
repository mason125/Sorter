using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Sorter
{
    namespace stats
    {
        public class MathFuncs
        {
            //get the largest value in the collection 
            public static dynamic greatest(ArrayList data)
            {
                //data is a sorted array
                dynamic largest_val = data.Count - 1;
                return data[largest_val];
            }

            //get the smallest value in the collection
            public static dynamic least(ArrayList data)
            {
                dynamic least = data[0];
                return data[least];
            }
        }
    }
}
