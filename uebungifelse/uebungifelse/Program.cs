using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebungifelse
{
    class Program
    {

        static int highscorePlayer2 = 15000;
        
        static string player1Name = "";
        static string player2Name = "DanielTheBeast";

        static void Main(string[] args)
        {

            Console.WriteLine("Wie lautet ihr name Player 1 ?");
            string player1name = Console.ReadLine();


            Console.WriteLine("Wie hoch ist deine Punktezahl?");
            int scorePlayer1 = Convert.ToInt32(Console.ReadLine());

            if (scorePlayer1 >= highscorePlayer2)
            {
                Console.WriteLine("Du hast den Highscore gecknackt" + player2Name + "Ist nun auf rang 2");

            }
            else
            {
                Console.WriteLine("Leider hast du den Highscóre nicht gecknackt. Highscore von" +  player2Name + highscorePlayer2);
                Console.WriteLine( player1name +  "Versuche es Erneurt vlt ein anderes mal");

            }

            Console.ReadKey();
            
        }
    }
}
