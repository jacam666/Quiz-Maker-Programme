using System;
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
        /// <summary>
        /// randomises the quiz questions and asks the user a question
        /// </summary>
        public static void QuestionRandomiser()
        {
            List<string> Questions = new();
            Questions.Add("What counry won the very first fifa world cup ? ");
            Questions.Add("What year was the very first fifa world cup?");
            Questions.Add("Whats the shortcut for the 'copy' function in most computers?");
            Questions.Add("What was Twitters original name?");
            Questions.Add("Which animal can be seen in the Porsche logo?");
            Questions.Add("What is the common name for dried plums?");
            Questions.Add("What is the primary ingredient in hummus?");
            Questions.Add("Which country produces the most coffee in the world?");
            Questions.Add("Which country is responsible for giving us pizza and pasta?");
            Questions.Add("Which organ has four chambers?");
            Random rnd = new();
            int randomQuest = rnd.Next(Questions.Count);
            Console.WriteLine($"Your question is : {Questions[randomQuest]}");
        }
    }
}
