using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
 
namespace ConsoleApp1
{
    class ISBNGenerating
    {
        public static string Start()
        {
            int[] ISBNTemp = new int[13];
            Random rnd = new Random();
            int checkSum = 0;

            ISBNTemp[0] = 9;
            ISBNTemp[1] = 7;
            ISBNTemp[2] = rnd.Next(8, 10);
            ISBNTemp[3] = 3;       

            for (var i = 4; i < ISBNTemp.Length - 2; i++)
            {
                ISBNTemp[i] = rnd.Next(0, 10);

                if (i % 2 != 0)
                {
                    checkSum += ISBNTemp[i];
                }
                else
                {
                    checkSum += ISBNTemp[i] * 3;
                }
            }          
 
            int lastNumber = (checkSum % 10);
            int Prüfziffer = 10 - lastNumber;
 
            if (Prüfziffer == 10)
            {
                Prüfziffer = 0;
            }

            ISBNTemp[12] = Prüfziffer;
            var ISBN = string.Join("", ISBNTemp);

            return ISBN;
        }
    }
}