using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_abstracyjne
{
    internal class Program
    {
        //klasa abstrakcyjna = nie mozna tworzyc obiektow tej klasy
        //Klasa abstrakcyjna moze zawierac metody abstrakcyjne
        //Metoda abstrakcyjna nie poisiada ciala
        //Klasa dizedziczaca po klasie abstrakcyjnej musi zaimplementowac wszystkie metody abstrakcyjne
        //Klasa abstrakcyjna moze zawierac metdoy wirtualne
        //Klasa taka ma sens w przypadku gdy kilka klas pochodnych wymaga uzycia tej samej metody
        //ale z rozna implemenetjacja
        //Klasa abstrakcyjna moze zawierac pola
        abstract class Zwierzak
        {
            public string nazwa = "Zwierzak";
            public abstract void Oddychanie();
        }
        //Klasa konkretna Ryba dziedziczaca po Zwierzak
        //Implementuje abstrakcyjna metode Oddychanie
        class Ryba : Zwierzak
        {
            public Ryba(string nazwa)
            {
                this.nazwa = nazwa;
            }
            public override void Oddychanie()
            {
                Console.WriteLine("Ryba oddycha za pomoca skrzeli ");
            }
        }
        //Klasa ssak dziedziczy po Zwierzak
        //Implementuje abstrakcyjna metode oddychanie
        class Ssak : Zwierzak
        {
            public Ssak(string nazwa)
            {
                this.nazwa = nazwa;
            }
            public override void Oddychanie()
            {
                Console.WriteLine("Ssak " + nazwa + " oddycha za pomoca pluc");
            }
        }

            
        static void Main(string[] args)
        {
            Ryba ryba = new Ryba("Karp");
            Ssak ssak = new Ssak("Kot");
            ryba.Oddychanie();
            ssak.Oddychanie();
        }
    }
}
