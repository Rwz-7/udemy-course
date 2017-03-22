using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebungifelse
{
    class Program
    {
       
       static int highscore = 10000;

        static void Main(string[] args)
        {
            Console.WriteLine("Wie hoch ist deine Punktezahl?");
            int score = Convert.ToInt32(Console.ReadLine());
        
            if  (score >= highscore)
            {
                Console.WriteLine("Du hast den Highscore gecknackt");
            
            }
            else
            {
                Console.WriteLine("Leider hast du den Highscóre nicht gecknackt");
            }

            Console.ReadKey();
            
        }
    }
}
