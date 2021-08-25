using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz_Maker_Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            //UI.DisplayWelcomeMessage();
            //UI.DecisionToPlay();

            string[] Lines = System.IO.File.ReadAllLines(@"C:\Users\ja6ca\source\repos\Quiz Maker Programme\Quiz Maker Programme\readalllines questions and answers.txt");

            for (int i = 0; i < 5; i += 6)
            {
                var gc = new QuestionAndAnswer();
                gc.Question = Lines[i];
                gc.Answers.Add(Lines[i + 1]);

            }

            ///go through every line of thet file (you'll get those as strings) File.ReadAllLines()
            ///for each question / answer / etc
            ///create a new gamecard, 
            ///add the strings you gort from the file to the gamecard
            ///add this gamecard to your list
            List<QuestionAndAnswer> GameCards = new();
            for (int i = 0; i < Lines.Length; i += 6)
            {
                var gc = new QuestionAndAnswer();
                gc.Question = Lines[i];
                for (int j = 0; j < 4; j++)
                {
                    gc.Answers.Add(Lines[i + 1 + j]);
                }
                gc.CorrectAnswer = Lines[i + 5];
                GameCards.Add(gc);
            }

            Random rnd = new();
            List<QuestionAndAnswer> randomlyOrderdQuestions = GameCards.OrderBy(g => rnd.Next()).ToList();

            int Score = 0;
            int Attempts = 10;

            for (int i = 0; i < GameCards.Count; i++) //do this for every gamecard
            {
                int RandomIndex = rnd.Next(GameCards.Count);

                QuestionAndAnswer aRandomGameCard = randomlyOrderdQuestions[i];    //maybe loop this for more attemts at the same question
                bool IsCorrectAnswer = UI.AskUserForAnswer(aRandomGameCard);   //maybe loop this for more attemts at the same question
                                                                               //maybe loop this for more attemts at the same question
                UI.DisplaysCorrectIncorrectAnswer(IsCorrectAnswer);            //maybe loop this for more attemts at the same question
                                                                               //maybe loop this for more attemts at the same question
                                                                               //maybe loop this for more attemts at the same question
                if (IsCorrectAnswer)                                           //maybe loop this for more attemts at the same question
                {
                    Score++;  
                    UI.DisplayScore(Score);                                    //maybe loop this for more attemts at the same question           
                }
                Attempts -= 1;
                UI.DisplayAttemptsRemaining(Attempts);
                
            }
            UI.DisplayTotalEndScore(Score, GameCards.Count);
            
            //Console.WriteLine($"You scored {Score} out of {GameCards.Count}");

            //QuestionAndAnswer theLastcard = GameCards.Find(g => g.CorrectAnswer == "B");

            //Random rnd = new();
            //List<QuestionAndAnswer> randomlyOrderdQuestions = GameCards.OrderBy(g => rnd.Next()).ToList();

            
            //while (attempts > 0)
            //{
            //    Console.WriteLine("Q1):" + QuizQuestions.FirstQuestion + " " + MultipleAnswers.FirstQuestionAnswers);
            //    string Answer = Console.ReadLine();
            //    string Correct = "D";
            //    if (Answer == Correct)
            //    {
            //        Console.WriteLine("Congrats that answer is correct");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Unlucky that answer is incorrect");
            //    }

            //}

           

        }
        

        //public class Questions
        //{
        //    public string FirstQuestion;
        //    public string SecondQuestion;
        //    public string ThirdQuestion;
        //    public string ForthQuestion;
        //    public string FifthQuestion;
        //    public string SixthQuestion;
        //    public string SeventhQuestion;
        //    public string EighthQuestion;
        //    public string NinthQuestion;
        //    public string TenthQuestion;

        //}
        //public class Answers
        //{
        //    public string FirstQuestionAnswers;
        //    public string SecondQuestionAnswers;
        //    public string ThirdQuestionAnswers;
        //    public string ForthQuestionAnswers;
        //    public string FifthQuestionAnswers;
        //    public string SixthQuestionAnswers;
        //    public string SeventhQuestionAnswers;
        //    public string EighthQuestionAnswers;
        //    public string NinthQuestionAnswers;
        //    public string TenthQuestionAnswers;
        //}
    }







}


