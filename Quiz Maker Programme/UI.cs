﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker_Programme
{
    class UI

    {
        /// <summary>
        /// Welcomes user to game, asks player for their name and if they are ready to play
        /// </summary>
        public static void DisplayWelcomeMessage()
        {
            string playerName;
            Console.Write("Hi there please enter your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to my Quiz Game {playerName} are you ready to play? ");


        }
        /// <summary>
        /// gives the user an option to play
        /// </summary>
        /// <returns>decision to play</returns>
        public static bool DecisionToPlay()
        {
            string response;
            bool wantsToPlay = false;
            Console.WriteLine("Play Quiz Game? yes/no");
            response = Console.ReadLine();
            if (response == "yes")
            {
                wantsToPlay = true;
            }
            return wantsToPlay;
        }
    }
}
