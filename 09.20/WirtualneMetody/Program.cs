using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WirtualneMetody
{
    // metoda wirtualna jest przygotowana do zastąpienia jej innym kodem w klasie potomnej metode tworzymy za pomocą słowa kluczowego virtual
    class Zwierzak
    {
        public int Wiek;
        public virtual void Oddychanie()
        {
            Console.WriteLine("Zwierzak oddycha . . . ");
        }

    }
    class Ssak : Zwierzak
    {
        public override void Oddychanie()
        {
            Console.WriteLine("Ssak oddycha płucami . . . ");
        }
    }
    class Ryba : Zwierzak
    {
        public override void Oddychanie()
        {
            Console.WriteLine("Ryba oddycha skrzelami . . . ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zwierzak zwierz;
            Console.WriteLine("1 - tworz obiekt klasy Ssak");
            Console.WriteLine("2 - tworz obiekt klasy Ryba");
            Console.WriteLine("3 - tworz obiekt klasy Zwierzak");
            // wczytamy znak z konsoli i przypiszemy go do obiektu klasy ConsoleInfo
            ConsoleKeyInfo Key = Console.ReadKey(); // Wczytuje tylko jeden znak z klawiatury
            Console.WriteLine();

            switch (Key.KeyChar)
            {
                case '1': 
                    zwierz = new Ssak(); 
                    break;
                case '2': 
                    zwierz = new Ryba(); 
                    break;
                default: 
                    zwierz = new Zwierzak(); 
                    break;
            }

            //wywoluje metode oddychanie
            zwierz.Oddychanie();


            // z hierarchi dziedziczenia wynika iż każdy obiekt klasy pochodnej jest jednocześnie obiektem klasy bazowej( np. Ryba to zwierz);

            //Metoda statyczna nie może być wirtualna ponieważ metody wirtualne są wywoływane na rzecz obiektu klasy a
            //metoda statyczna związana jest z istnieniem samej klasy i nie może być wołana z jej obiektu.

        }
    }
}
