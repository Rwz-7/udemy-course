using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int meineGlobaleVariable = 15;
        static int testVariable = 10;
        const double pi = 3.14159;


        static void Main(string[] args)
        {
            meineFunktion(25);
            Console.WriteLine("globale testVariable" + testVariable);
            Console.ReadKey();
        }

        static void meineFunktion(int testVariable)
        {
            int meineLokaleVariable = 10;
            Console.WriteLine("global" + meineGlobaleVariable);
            Console.WriteLine("lokal" + meineLokaleVariable);

            Console.WriteLine("lokale testVariable" + testVariable);
        }
    }
}
