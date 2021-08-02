using System;

namespace Quiz_Maker_Programme
{
    class Program
    {
        static void Main(string[] args)
        {

            UI.DisplayWelcomeMessage();
            
            string response;
            bool wantsToPlay = false;
            Console.WriteLine("Play Quiz Game? yes/no");
            response = Console.ReadLine();
            if (response == "yes")
            {
                wantsToPlay = true;
            }
            
            
              
            
            



        }
    }









}
