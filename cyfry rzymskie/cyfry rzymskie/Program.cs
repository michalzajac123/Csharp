using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyfry_rzymskie
{
    internal class Program
    {
        static string zamienNaRzymska(int liczba)
        {
            string[] cyfryRzymskie = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] liczby = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int i = 0;
            string liczbaRzymska = "";
            if (liczba > 3999) {
                return "Nie da się napisać liczby wiekszej od 3999";
            }
            while (liczba > 0)
            {
                if (liczba >= liczby[i])
                {
                    liczba -=liczby[i];
                    liczbaRzymska += cyfryRzymskie[i];
                    
                }
                if (liczba < liczby[i])
                {
                    i++;
                }
            }
            return liczbaRzymska;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba " + 532+" Rzymsko to: "+zamienNaRzymska(542));


        }
    }
}
