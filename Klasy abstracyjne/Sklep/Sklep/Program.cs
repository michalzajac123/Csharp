using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sklep.Program;

namespace Sklep
{
    internal class Program
    {
        public abstract class ProductToSell
        {
            public abstract string getName();
            public abstract double getPrice();
            public abstract int getPercentDiscount();
            public abstract string getCategory();
            public string getWarehous()
            {
                return "Magazyn nr 1";
            }
        }
        public class Book : ProductToSell
        {
            public override string getName()
            {
                return "Potop";
            }
            public override double getPrice()
            {
                return 50.0;
            }
            public override int getPercentDiscount()
            {
                return 10;
            }
            public override string getCategory()
            {
                return "Książki";
            }
        }
        public class Cup : ProductToSell
        {
            public override string getName()
            {
                return "Kubek Programisty";
            }
            public override double getPrice()
            {
                return 15.0;
            }
            public override int getPercentDiscount()
            {
                return 5;
            }
            public override string getCategory()
            {
                return "Kubek";
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            Cup cup = new Cup();
            Console.WriteLine("Nazwa: " + book.getName());
            Console.WriteLine("Cena: " + book.getPrice());
            Console.WriteLine("Procent zniżki: " + book.getPercentDiscount());
            Console.WriteLine("Kategoria: " + book.getCategory());
            Console.WriteLine("Magazyn: " + book.getWarehous());
            Console.WriteLine();
            Console.WriteLine("Nazwa: " + cup.getName());
            Console.WriteLine("Cena: " + cup.getPrice());
            Console.WriteLine("Procent zniżki: " + cup.getPercentDiscount());
            Console.WriteLine("Kategoria: " + cup.getCategory());
            Console.WriteLine("Magazyn: " + cup.getWarehous());
        }
    }
}
