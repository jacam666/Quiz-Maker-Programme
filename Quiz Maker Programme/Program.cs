using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_Maker_Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeMessage();
            UI.DecisionToPlay();
            {
                string text = System.IO.File.ReadAllText(@"C:\Users\ja6ca\source\repos\Quiz Maker Programme\Quiz Maker Programme\readalllines questions and answers.zip");
            }








            //QuestionAndAnswer GameCard1 = new();
            //GameCard1.Question = "What country won the very first fifa world cup?";
            //GameCard1.Answers.Add("A)  Germany");
            //GameCard1.Answers.Add("B)  Italy");
            //GameCard1.Answers.Add("C)  UK");
            //GameCard1.Answers.Add("D)  Russia");
            //GameCard1.Answers.Add("E)  Uruguay");
            //GameCard1.CorrectAnswer = "E";

            //QuestionAndAnswer GameCard2 = new();
            //GameCard2.Question = "What year was the very first fifa world cup?";
            //GameCard2.Answers.Add("A)  1930");
            //GameCard2.Answers.Add("B)  1918");
            //GameCard2.Answers.Add("C)  1934");
            //GameCard2.Answers.Add("D)  1940");
            //GameCard2.CorrectAnswer = "A";

            //QuestionAndAnswer GameCard3 = new();
            //GameCard3.Question = "Whats the shortcut for the 'copy' function in most computers?";
            //GameCard3.Answers.Add("A)  ctrl A");
            //GameCard3.Answers.Add("B)  ctrl C");
            //GameCard3.Answers.Add("C)  ctrl 9");
            //GameCard3.Answers.Add("D)  ctrl D");
            //GameCard3.CorrectAnswer = "B";

            //QuestionAndAnswer GameCard4 = new();
            //GameCard4.Question = "Which animal can be seen in the Porsche logo?";
            //GameCard4.Answers.Add("A)  Lion");
            //GameCard4.Answers.Add("B)  Tiger");
            //GameCard4.Answers.Add("C)  Elephant");
            //GameCard4.Answers.Add("D)  Horse");
            //GameCard4.CorrectAnswer = "D";

            //QuestionAndAnswer GameCard5 = new();
            //GameCard5.Question = "What was Twitters original name?";
            //GameCard5.Answers.Add("A)  Twitter");
            //GameCard5.Answers.Add("B)  Twitch");
            //GameCard5.Answers.Add("C)  Twicker");
            //GameCard5.Answers.Add("D)  InstaTwitch");
            //GameCard5.CorrectAnswer = "A";

            //QuestionAndAnswer GameCard6 = new();
            //GameCard6.Question = "What is the common name for dried plums?";
            //GameCard6.Answers.Add("A)  Prunes");
            //GameCard6.Answers.Add("B)  Raisins");
            //GameCard6.Answers.Add("C)  Saltanas");
            //GameCard6.Answers.Add("D)  Dates");
            //GameCard6.CorrectAnswer = "A";

            //QuestionAndAnswer GameCard7 = new();
            //GameCard7.Question = "What is the primary ingredient in hummus?";
            //GameCard7.Answers.Add("A)  Rice");
            //GameCard7.Answers.Add("B)  ChickPeas");
            //GameCard7.Answers.Add("C)  Beans");
            //GameCard7.Answers.Add("D)  Eggs");
            //GameCard7.CorrectAnswer = "B";

            //QuestionAndAnswer GameCard8 = new();
            //GameCard8.Question = "Which country produces the most coffee in the world?";
            //GameCard8.Answers.Add("A)  Columbia");
            //GameCard8.Answers.Add("B)  Usa");
            //GameCard8.Answers.Add("C)  Brazil");
            //GameCard8.Answers.Add("D)  Mexico");
            //GameCard8.CorrectAnswer = "C";

            //QuestionAndAnswer GameCard9 = new();
            //GameCard9.Question = "Which country is responsible for giving us pizza and pasta?";
            //GameCard9.Answers.Add("A)  England");
            //GameCard9.Answers.Add("B)  Poland");
            //GameCard9.Answers.Add("C)  Italy");
            //GameCard9.Answers.Add("D)  Russia");
            //GameCard9.CorrectAnswer = "C";

            //QuestionAndAnswer GameCard10 = new();
            //GameCard10.Question = "Which organ has four chambers?";
            //GameCard10.Answers.Add("A)  Heart");
            //GameCard10.Answers.Add("B)  Lungs");
            //GameCard10.Answers.Add("C)  Liver");
            //GameCard10.Answers.Add("D)  Kidneys");
            //GameCard10.CorrectAnswer = "A";

            ///go through every line of thet file (you'll get those as strings) File.ReadAllLines()
            ///for each question / answer / etc
            ///create a new gamecard, 
            ///add the strings you gort from the file to the gamecard
            ///add this gamecard to your list


            List<QuestionAndAnswer> GameCards = new();

            //GameCards.Add(GameCard1);
            //GameCards.Add(GameCard2);
            //GameCards.Add(GameCard3);
            //GameCards.Add(GameCard4);
            //GameCards.Add(GameCard5);
            //GameCards.Add(GameCard6);
            //GameCards.Add(GameCard7);
            //GameCards.Add(GameCard8);
            //GameCards.Add(GameCard9);
            //GameCards.Add(GameCard10);

            QuestionAndAnswer theLastcard = GameCards.Find(g => g.CorrectAnswer == "B");

            Random rnd = new();
            List<QuestionAndAnswer> randomlyOrderdQuestions = GameCards.OrderBy(g => rnd.Next()).ToList();

            int Score = 0;
            int attempts = 10;
            while (attempts > 0)  //do we need this loop?
            {
                for (int i = 0; i < GameCards.Count; i++) //do this for everty gamecard
                {
                    int RandomIndex = rnd.Next(GameCards.Count);

                    QuestionAndAnswer aRandomGameCard = randomlyOrderdQuestions[i];    //maybe loop this for more attemts at the same question
                    bool IsCorrectAnswer = UI.AskUserForAnswer(aRandomGameCard);   //maybe loop this for more attemts at the same question
                                                                                   //maybe loop this for more attemts at the same question
                    UI.DisplaysCorrectIncorrectAnswer(IsCorrectAnswer);            //maybe loop this for more attemts at the same question
                    attempts--;                                                    //maybe loop this for more attemts at the same question
                                                                                   //maybe loop this for more attemts at the same question
                    if (IsCorrectAnswer)                                           //maybe loop this for more attemts at the same question
                    {                                                              //maybe loop this for more attemts at the same question
                        UI.DisplayScore(Score);                                    //maybe loop this for more attemts at the same question
                        Score++;                                                   //maybe loop this for more attemts at the same question
                    }
                }
            }


            //int attempts = 10;
            //Questions QuizQuestions = new();
            //QuizQuestions.FirstQuestion = "What country won the very first fifa world cup?";
            //QuizQuestions.SecondQuestion = "What year was the very first fifa world cup?";
            //QuizQuestions.ThirdQuestion = "Whats the shortcut for the 'copy' function in most computers?";
            //QuizQuestions.ForthQuestion = "What was Twitters original name?";
            //QuizQuestions.FifthQuestion = "Which animal can be seen in the Porsche logo?";
            //QuizQuestions.SixthQuestion = "What is the common name for dried plums?";
            //QuizQuestions.SeventhQuestion = "What is the primary ingredient in hummus?";
            //QuizQuestions.EighthQuestion = "Which country produces the most coffee in the world?";
            //QuizQuestions.NinthQuestion = "Which country is responsible for giving us pizza and pasta?";
            //QuizQuestions.TenthQuestion = "Which organ has four chambers?";

            //Answers MultipleAnswers = new();
            //MultipleAnswers.FirstQuestionAnswers = "A.England, B.Germany, C.Italy, or D.Uruguay";
            //MultipleAnswers.SecondQuestionAnswers = "A.1930, B.1918, C.1934, or D.1938.";
            //MultipleAnswers.ThirdQuestionAnswers = "A.ctrl a, B.ctrl 9, C.ctrl c, or D.ctrl s.";
            //MultipleAnswers.ForthQuestionAnswers = "A.Twitter, B.Twitch, C.Twicker, or D.instaTwit.";
            //MultipleAnswers.FifthQuestionAnswers = "A.lion, B.Horse, C.eagle, or D.Dolphin.";
            //MultipleAnswers.SixthQuestionAnswers = "A.prunes, B.Raisins, C.sultana's, or D.Dates.";
            //MultipleAnswers.SeventhQuestionAnswers = "A.Rice, B.ChickPeas, C.Beans, or D.Egg.";
            //MultipleAnswers.EighthQuestionAnswers = "A.Columbia, B.USA, C.Brazil, or D.Mexico.";
            //MultipleAnswers.NinthQuestionAnswers = "A.England, B.Poland, C.Italy, or D.Russia.";
            //MultipleAnswers.TenthQuestionAnswers = "A.Heart, B.Lungs, C.Liver, or D.Kidneys.";

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

            //private static string[] ReadAllLines(string path);
            //{

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


