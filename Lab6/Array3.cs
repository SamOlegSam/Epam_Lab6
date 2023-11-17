using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Array3
    {
        public static string Poloj(string s, out string P)
        {
            P = "";            

            string[] str = s.Split( new char[] { '\n' });

            string[][] split2 = new string[str.Length][];

            for (int i = 0; i < str.Length; i++)
            {                
                    split2[i] = str[i].Split(new char[] { ' ' });            

            }

            int[][] nums = new int[str.Length][];
            

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < split2[i].Length; j++)
                {
                    nums[i] = new int[split2[i].Length];
                    nums[i][j] = Convert.ToInt32(split2[i][j]);
                }
            }
                int Ind = -1;
            ///Поиск положительного элемента в столбце
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < split2[i].Length; j++)
                {
                    if (nums[i][j] > 0)
                    {
                        Ind = j + 1;
                    }
                }
            }
            if (Ind == -1)
            {
                P = "нет!";
            }

            else
            {
                P = Convert.ToString(Ind);
            }
            return P;
            
        }
        
    }
}
