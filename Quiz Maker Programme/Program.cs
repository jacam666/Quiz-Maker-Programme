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

            answers MultipleAnswers = new();
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
        public class answers
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
