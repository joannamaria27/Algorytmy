using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace zadanie1._2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            StreamReader plik;
            plik = new StreamReader("in.txt");

            int maksymalnaLiczba= 1;
            int liczebnoscZb = 0;
            liczebnoscZb =int.Parse(plik.ReadLine());

            int maks = 0;
            int liczba;
            int[] tablica = new int[liczebnoscZb];          
                          
            for(int i=0;i<liczebnoscZb;i++)
            {
                liczba = Convert.ToInt32(plik.ReadLine(), 2);
                tablica[i] = liczba;
                if (liczba > maksymalnaLiczba)
                    maksymalnaLiczba = liczba;
            }

            plik.Close();

            int[] tabLiczebnosc=new int[maksymalnaLiczba];         
            int wartosc = 0;

            for(int i=0;i<liczebnoscZb;i++)
            {                
                wartosc = tablica[i];                
                tabLiczebnosc[wartosc - 1] += 1;
                if(maks < tabLiczebnosc[wartosc-1])
                    maks = tabLiczebnosc[wartosc-1];


            }          
            
            StreamWriter plikZapis;
            plikZapis = new StreamWriter("out.txt");
            plikZapis.WriteLine(maks);
            plikZapis.Close();
        }
    }
}
