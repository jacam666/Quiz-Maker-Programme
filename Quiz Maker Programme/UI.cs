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
            Console.WriteLine($"You start the game with 10 attempts, good luck\n");
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
        /// Displays a game card
        /// </summary>
        /// <param name="gc"></param>
        public static void DisplayAgameCard(QuestionAndAnswer gc)
        {
            Console.WriteLine(gc.Question);
            for (int i = 0; i < gc.Answers.Count; i++)
            {
                Console.WriteLine(gc.Answers[i]);
            }
        }
        /// <summary>
        /// asks user for an answer and displays if that is correct or incorrect. also informs user of 1 attempt lost if the answer is incorrect
        /// </summary>
        /// <param name="gc"></param>
        public static bool AskUserForAnswer(QuestionAndAnswer gc)
        {
            DisplayAgameCard(gc);

            string Choice = Console.ReadLine().ToUpper();
            if (Choice == gc.CorrectAnswer)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// informs user if answer is correct or incorrect
        /// </summary>
        /// <param name="IsCorrect"></param>
        public static void DisplaysCorrectIncorrectAnswer(bool IsCorrect)
        {
            if (IsCorrect)
            {
                Console.WriteLine("That answer is correct");
            }
            else
            {
                Console.WriteLine("That answer is incorrect");
            }
        }
        /// <summary>
        /// displays score
        /// </summary>
        /// <param name="s"></param>
        public static void DisplayScore(int s)
        {
            Console.WriteLine($"Your current score is : {s}\n");         
        }
        /// <summary>
        /// displays total score at the end of the game
        /// </summary>
        /// <param name="s"></param>
        /// <param name="gc"></param>
        public static void DisplayTotalEndScore(int s,int  gc)
        {
            Console.WriteLine($"You scored {s} out of {gc}");
        }


    }
}
