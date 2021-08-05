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
            //List<QuestionAndAnswer> GameCards = new(GameCards);
            //{
            //    GameCards.Add(GameCard1);
            //    GameCards.Add(GameCard2);
            //    GameCards.Add(GameCard3);
            //    GameCards.Add(GameCard4);


            //    Random rnd = new();
            //    int GameCard = rnd.Next(GameCards.Count);
            //    Console.WriteLine($"Your question is :{GameCards[GameCard]}");
            //}
            //List<string> Questions = new();
            //Questions.Add("What counry won the very first fifa world cup ? : A.England, B.Germany, C.Italy, or D.Uruguay.");
            //Questions.Add("What year was the very first fifa world cup? : A.1930, B.1918, C.1934, or D.1938.");
            //Questions.Add("Whats the short cut for the 'copy' function in most computers? : A.ctrl+a, B.ctrl+9, C.ctrl+c, or D.ctrl+s.");
            //Questions.Add("What was Twitters original name? : A.Twitter, B.Twitch, C.Twicker, or D.instaTwit.");
            //Questions.Add("Which animal can be seen in the Porsche logo? : A.lion, B.Horse, C.eagle, or D.Dolphin. ");
            //Questions.Add("What is the common name for dried plums? A.prunes, B.Raisins, C.sultana's, or D.Dates. ");
            //Questions.Add("What is the primary ingredient in hummus? A.Rice, B.ChickPeas, C.Beans, or D.Egg. ");
            //Questions.Add("Which country produces the most coffee in the world? A.Columbia, B.USA, C.Brazil, or D.Mexico.");
            //Questions.Add("Which country is responsible for giving us pizza and pasta? A.England, B.Poland, C.Italy, or D.Russia. ");
            //Questions.Add("Which organ has four chambers? A.Heart, B.Lungs, C.Liver, or D.Kidneys.");
            //Random rnd = new();
            //int randomQuest = rnd.Next(Questions.Count);
            //Console.WriteLine($"Your question is : {Questions[randomQuest]}");

        }

        public static void QuizQuestions()
        {
            //Program.Questions QuizQuestions = new();

            //QuizQuestions.FirstQuestion = "What counry won the very first fifa world cup?";
            //QuizQuestions.SecondQuestion = "What year was the very first fifa world cup?";
            //QuizQuestions.ThirdQuestion = "Whats the shortcut for the 'copy' function in most computers?";
            //QuizQuestions.ForthQuestion = "What was Twitters original name?";
            //QuizQuestions.FifthQuestion = "Which animal can be seen in the Porsche logo?";
            //QuizQuestions.SixthQuestion = "What is the common name for dried plums?";
            //QuizQuestions.SeventhQuestion = "What is the primary ingredient in hummus?";
            //QuizQuestions.EighthQuestion = "Which country produces the most coffee in the world?";
            //QuizQuestions.NinthQuestion = "Which country is responsible for giving us pizza and pasta?";
            //QuizQuestions.TenthQuestion = "Which organ has four chambers?";
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
        /// asks user for an answer and displays if that is correct or incorrect
        /// </summary>
        /// <param name="gc"></param>
        public static void AskUserForAnswer(QuestionAndAnswer gc)
        {                      
                DisplayAgameCard(gc);
            string Choice = Console.ReadLine().ToUpper();
            
                if (Choice == gc.CorrectAnswer)
                {
                    Console.WriteLine("congrats that answer is correct");
                }
                else
                {
                    Console.WriteLine("Unlucky that is a wrong answer");
                }            
        }

    }
}
