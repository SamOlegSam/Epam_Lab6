using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Array2
    {
        public static string AddArray(params int[] Arr)
        {
            string str = "";
            int temp;
            int Ind = -1;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 0)
                {
                    Ind = i;
                    break;
                }
            }
              if (Ind == -1)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = i + 1; j < Arr.Length; j++)
                    {
                        if (Arr[i] < Arr[j])
                        {
                            temp = Arr[i];
                            Arr[i] = Arr[j];
                            Arr[j] = temp;
                        }
                    }
                    str += Arr[i];                    
                }
                    return str;
            }
            else
            {
                for (int i = 0; i < Ind; i++)
                {
                    for (int j = i + 1; j < Ind; j++)
                    {
                        if (Arr[i] < Arr[j])
                        {
                            temp = Arr[i];
                            Arr[i] = Arr[j];
                            Arr[j] = temp;
                        }
                    }
                    Console.WriteLine(Arr[i]);
                    str += Arr[i];
                }
                return str;
            }


        }
    }
}
