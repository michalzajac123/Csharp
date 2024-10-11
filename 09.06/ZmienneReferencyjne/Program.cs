using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosik
{
    public class MojaKlasa
    {
        public int Dana { get; set; }
        public MojaKlasa(int d) 
        {
            this.Dana = d;
        }

        public MojaKlasa(MojaKlasa kopia)
        {
            this.Dana = kopia.Dana;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa p1 = new MojaKlasa(5);
            MojaKlasa p2 = new MojaKlasa(p1);

            Console.WriteLine("p1.Dana={0}", p1.Dana);
            Console.WriteLine("p2.Dana={0}", p2.Dana);
            p1.Dana = 8; 
            Console.WriteLine();
            Console.WriteLine("wartosci po zmianie p1");
            Console.WriteLine();
            Console.WriteLine("p1.Dana={0}", p1.Dana);
            Console.WriteLine("p2.Dana={0}", p2.Dana);
        }
    }
}