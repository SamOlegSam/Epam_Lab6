using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{    
    class Array4
    {
           struct fleur
        {
            public string name;
            public string view;
            public string country;
            public bool gor;
            public double cena1, cena2, cena3;
                  
         }
       public static Tuple<string, string, string, double, string> Corteg(string name1, string country1, string dat1, double cena777)
        {
            double sum = 0, srcena =0;
            string str1 = name1, kod1 = "", view1 = "", otv = "";

            fleur[] fl = new fleur[5];
            fl[0].name = "Роза";
            fl[0].view = "уличный";
            fl[0].country = "Турция";
            fl[0].gor = false;
            fl[0].cena1 = 3; fl[0].cena2 = 4; fl[0].cena3 = 5;

            fl[1].name = "Тюльпан";
            fl[1].view = "уличный";
            fl[1].country = "Нидерланды";
            fl[1].gor = false;
            fl[1].cena1 = 3; fl[0].cena2 = 4; fl[0].cena3 = 5;

            fl[2].name = "Кактус";
            fl[2].view = "домашний";
            fl[2].country = "Африка";
            fl[2].gor = true;
            fl[2].cena1 = 3; fl[0].cena2 = 4; fl[0].cena3 = 5;

            fl[3].name = "Фиалка";
            fl[3].view = "домашний";
            fl[3].country = "Россия";
            fl[3].gor = true;
            fl[3].cena1 = 3; fl[0].cena2 = 4; fl[0].cena3 = 5;

            fl[4].name = "Пион";
            fl[4].view = "уличный";
            fl[4].country = "Турция";
            fl[4].gor = false;
            fl[4].cena1 = 3; fl[0].cena2 = 4; fl[0].cena3 = 5;

            int nom = -1;
            for(int i = 0; i<5; i++)
            if (fl[i].name == name1)
                {
                    nom = i;
                    break;
                }
            if (nom!=-1)
            {
                kod1 = fl[nom].view + "-" + Convert.ToString(dat1);
                sum = fl[nom].cena1 + fl[nom].cena2 + fl[nom].cena3;
                srcena = sum / 3;
                 view1 = fl[nom].view;
                if (fl[nom].country == country1)
                {
                    otv = "Да";
                }
                else
                {
                    otv = "Нет";
                }

            }
            
            return Tuple.Create<string, string, string, double, string>(name1, view1, kod1, srcena, otv);
                }
        }
        
    }

