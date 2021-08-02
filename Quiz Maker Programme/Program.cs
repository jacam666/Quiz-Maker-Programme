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

            Questions QuizQuestions = new();

            QuizQuestions.FirstQuestion = "What counry won the very first fifa world cup?";
            QuizQuestions.SecondQuestion = "What year was the very first fifa world cup?";
            QuizQuestions.ThirdQuestion = "Whats the shortcut for the 'copy' function in most computers?";
            QuizQuestions.ForthQuestion = "What was Twitters original name?";
            QuizQuestions.FifthQuestion = "Which animal can be seen in the Porsche logo?";
            QuizQuestions.SixthQuestion = "What is the common name for dried plums?";
            QuizQuestions.SeventhQuestion = "What is the primary ingredient in hummus?";
            QuizQuestions.EighthQuestion = "Which country produces the most coffee in the world?";
            QuizQuestions.NinthQuestion = "Which country is responsible for giving us pizza and pasta?";
            QuizQuestions.TenthQuestion = "Which organ has four chambers?";
            //Console.WriteLine(QuizQuestions.TenthQuestion);
            //Console.ReadLine();
            //UI.QuestionRandomiser();
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
    }









}
