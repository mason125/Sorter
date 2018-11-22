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
        protected static ArrayList bubble(ArrayList data)
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
    }
}
