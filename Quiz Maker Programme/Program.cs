using System;
using System.Collections.Generic;


namespace Quiz_Maker_Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeMessage();
            UI.DecisionToPlay();
            UI.QuizQuestions();
            UI.QuestionRandomiser();
            int attempts = 10;
            Program.Questions QuizQuestions = new();
            QuizQuestions.FirstQuestion = "What country won the very first fifa world cup?";
            QuizQuestions.SecondQuestion = "What year was the very first fifa world cup?";
            QuizQuestions.ThirdQuestion = "Whats the shortcut for the 'copy' function in most computers?";
            QuizQuestions.ForthQuestion = "What was Twitters original name?";
            QuizQuestions.FifthQuestion = "Which animal can be seen in the Porsche logo?";
            QuizQuestions.SixthQuestion = "What is the common name for dried plums?";
            QuizQuestions.SeventhQuestion = "What is the primary ingredient in hummus?";
            QuizQuestions.EighthQuestion = "Which country produces the most coffee in the world?";
            QuizQuestions.NinthQuestion = "Which country is responsible for giving us pizza and pasta?";
            QuizQuestions.TenthQuestion = "Which organ has four chambers?";
            Answers MultipleAnswers = new();
            MultipleAnswers.FirstQuestionAnswers = "A.England, B.Germany, C.Italy, or D.Uruguay";
            MultipleAnswers.SecondQuestionAnswers = "A.1930, B.1918, C.1934, or D.1938.";
            MultipleAnswers.ThirdQuestionAnswers = "A.ctrl a, B.ctrl 9, C.ctrl c, or D.ctrl s.";
            MultipleAnswers.ForthQuestionAnswers = "A.Twitter, B.Twitch, C.Twicker, or D.instaTwit.";
            MultipleAnswers.FifthQuestionAnswers = "A.lion, B.Horse, C.eagle, or D.Dolphin.";
            MultipleAnswers.SixthQuestionAnswers = "A.prunes, B.Raisins, C.sultana's, or D.Dates.";
            MultipleAnswers.SeventhQuestionAnswers = "A.Rice, B.ChickPeas, C.Beans, or D.Egg.";
            MultipleAnswers.EighthQuestionAnswers = "A.Columbia, B.USA, C.Brazil, or D.Mexico.";
            MultipleAnswers.NinthQuestionAnswers = "A.England, B.Poland, C.Italy, or D.Russia.";
            MultipleAnswers.TenthQuestionAnswers = "A.Heart, B.Lungs, C.Liver, or D.Kidneys.";

            while (attempts > 0)
            {
                Console.WriteLine("Q1):" + QuizQuestions.FirstQuestion + " " + MultipleAnswers.FirstQuestionAnswers);
                string Answer = Console.ReadLine();
                string Correct = "D";
                if (Answer == Correct)
                {
                    Console.WriteLine("Congrats that answer is correct");
                }
                else
                {
                    Console.WriteLine("Unlucky that answer is incorrect");
                }
                
            }



        }
        public class Questions
        {
            public string FirstQuestion;
            public string SecondQuestion;
            public string ThirdQuestion;
            public string ForthQuestion;
            public string FifthQuestion;
            public string SixthQuestion;
            public string SeventhQuestion;
            public string EighthQuestion;
            public string NinthQuestion;
            public string TenthQuestion;

        }
        public class Answers
        {
            public string FirstQuestionAnswers;
            public string SecondQuestionAnswers;
            public string ThirdQuestionAnswers;
            public string ForthQuestionAnswers;
            public string FifthQuestionAnswers;
            public string SixthQuestionAnswers;
            public string SeventhQuestionAnswers;
            public string EighthQuestionAnswers;
            public string NinthQuestionAnswers;
            public string TenthQuestionAnswers;
        }
    }









}
