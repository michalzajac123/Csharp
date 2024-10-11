using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//skladniki statyczne klasy


//1. Klasy sa ladowane do pamieci w momencie gdy ladowany jest pgrogram lub przesztrzen nazw ktora ją zawiera
//2. metody - sa zwiazane z sama klasa(nie musi istniec obiekt klasy aby mozna bylo skorzystac z metody statycznej)
//3. wlasociwsoci analogicznie jak metody

// Polimorfizm (wielopstwaciwoosc) - jest zwiazany z dziedziczeniem i realizuje mozliwosc operowania na obiektach
//nalezacych do roznych klas ustawionych w hierarchi


namespace klasy_i_obiekty
{

    class A
    {
        public void Run()
        {
            Console.WriteLine("Metoda Run() z klasy A");
        }

    }

    class B : A
    {
        new public void Run() //swiadome przesunieniecie metody nadklasy
        {
            base.Run(); //korzystamy z nad klasy
            Console.WriteLine("Metoda Run() z klasy B");
        }
    }

    class Przyklad
    {
        private int liczba = 12; // liczba (pole prywatne) - male litery
        public int Liczba //metoda wlasciwosc get (poberz) //metoda wlosciwosci set ustaw
        {
            get { return liczba; }
            set { liczba = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Run();

            Przyklad p1 = new Przyklad();
            //Console.WriteLine("miesiac: " + p1.liczba); blad pole prywante
            Console.WriteLine("miesac: " + p1.Liczba);
        }
    }
}
