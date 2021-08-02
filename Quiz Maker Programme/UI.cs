using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker_Programme
{
    class UI
    {/// <summary>
    /// Welcomes user to game, asks player for their name and if they are ready to play
    /// </summary>
        public static void DisplayWelcomeMessage()
        {
            string playerName;
            Console.Write("Hi there please enter your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to my Quiz Game {playerName} are you ready to play? ");


        }
    }
}
