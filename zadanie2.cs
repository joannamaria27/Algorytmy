using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ASD_zadanie2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter plik;
            plik = new StreamWriter("in.txt");

            int szerokosc = 0;
            int wysokosc = 0;

            szerokosc = Console.Read();
            wysokosc = Console.Read();

            char[][] tabCzekolady = new char[szerokosc][]; //[wysokosc]
            for(int i=0;i<szerokosc;i++)
            {
                for(int j=0;j<wysokosc;j++)
                {
                    tabCzekolady[i][j] = (char)Console.Read();
                }
            }
            plik.Close();

            int ilosc = 0;


            Dziel(szerokosc, wysokosc);


            StreamReader plik2;
            plik2 = new StreamReader("out.txt");
            Console.Write(ilosc);
            plik2.Close();

        }


        public static int Dziel(int n, int m)
        {
            int ilosc = 0;

            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < m; l++)
                {
                    if ()//'c' lub 'b' wystepuje tylko raz
                    {
                        ilosc += 1;
                        return ilosc;
                    }
                    else
                    {
                        char[][] tab1 = new char[][];
                        char[][] tab2 = new char[][];
                        return Dziel();// dzielenie


                    }
                }
            }
            
        }
    }
}
