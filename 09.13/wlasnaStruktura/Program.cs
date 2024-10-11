using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wlasnaStruktura
{

    struct Kwadrat
    {
        int bok;
        ConsoleColor color;
        public Kwadrat(int bok1, ConsoleColor color1)
        {
            bok = bok1;
            color = color1;
        }

        public void RysujKwadrat()
        {
            Console.ForegroundColor = color;
            for (int i = 1; i <= bok; i++)
            {
                for (int j = 1; j <= bok; j++)
                    Console.Write("* ");

                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kwadrat k1 = new Kwadrat(5, ConsoleColor.Magenta);
            k1.RysujKwadrat();
        }
    }
}
