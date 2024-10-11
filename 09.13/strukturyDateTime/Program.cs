using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktury
{
    internal class Program
    {
        //struktura jest typem wartosciowym (klasa referencyjna)
        //struktura nie moze dziedziczyc po klasie, ani byc przedmiotem dziedziczenia
        //Nie obsluguja destruktorow
        //nie mozna zadeklarowac konstruktora bez argumentow
        //skladowe nie moga byc inicjalizowane w mmomencie deklarowania
        //roznicca w skladni  - slowo kluczoe struct
        static void Main(string[] args)
        {
            DateTime t1 = DateTime.Now;
            Console.WriteLine("Czas poczatkowy t1 {0}",t1);

            int licznik = 0;
            for (int i = 0; i < int.MaxValue; i++) 
                licznik++;
            
            Console.WriteLine("warotsc zmiennej licznik {0}", licznik);
            
            DateTime t2 = DateTime.Now;
            Console.WriteLine("Czas koncowy t2: {0}", t2);
            Console.WriteLine("Roznica t2-t1: {0}", t2-t1);
            Console.WriteLine("Dzis jest {0}: dzien roku", t1.DayOfYear);
        }
    }
}
