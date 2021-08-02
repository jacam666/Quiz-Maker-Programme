using System;

namespace Quiz_Maker_Programme
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string playerName;
            string response;
            Console.Write("Hi there please enter your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to my Quiz Game {playerName} are you ready to play? ");
            
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
