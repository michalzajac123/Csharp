using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy
{
    internal class Program
    {
        class Przyklad
        {
            private int godzina; // pole prywatne
            public int Godzina // wlasciwosc publiczna
            {
                get { return godzina; } // get i set to są akcesory
                set
                {
                    if (value >= 0 && value <= 24) godzina = value;
                    else  godzina = 0; 
                }
            }//koniec wlasciwosci

            public string Info()//zwykła metoda publiczna klasy
            {
                return "jest godzina " + godzina;
            }
        }
        class Student
        {
            private string nazwisko = "";
            private long numerIndeksu = 0; // Dostęp prywatny
            public string Nazwisko
            {
                //Publiczne metody get/set
                //get { return nazwisko; }
                //set { nazwisko = value; }
                get; set; // pod warunkiem że nazwisko nie jest "jakieś tam nie wiem"
            }
            public long NumerIndeksu
            {
                get { return numerIndeksu; }
                set
                {
                    if (value < 0 || value > 999999) numerIndeksu = 0;
                    else numerIndeksu = value;
                }
            }
        }
        class P1
        {
            public P1()
            {
                Console.WriteLine("tworze nowy obiekt");
            }
            static public void Metoda_statyczna()
            {
                Console.WriteLine("metoda statyczna");
            }
        }
        static void Main(string[] args)
        {
            P1.Metoda_statyczna();
            P1 p1 = new P1();
            //p1.Metoda_statyczna(); // błąd ,Metody statyczne działają na Klasy, nie na metody(chyba)
            //Przyklad p = new Przyklad();
            //p.Godzina = 113;
            //Console.WriteLine(p.Info());

            Student s = new Student();
            s.Nazwisko = "kowalski";
            s.NumerIndeksu = 23456;
            Console.WriteLine("Student: " + s.Nazwisko + ", numer indeksu: " + s.NumerIndeksu);
        }
    }
}
