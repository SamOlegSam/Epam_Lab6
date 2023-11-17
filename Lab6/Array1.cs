using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Array1
    {
       public static int Addition (params int[] integers)
        {
            int max = integers[0];
            int imax = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (Math.Abs(integers[i]) >= Math.Abs(max))
                {
                    imax = i;
                    max = integers[i];
                }
            }
            
            int result = 1;
            for (int i=imax; i<integers.Length; i++)
            {
                result *= integers[i];
            }
            return result;
        }
    }
}
