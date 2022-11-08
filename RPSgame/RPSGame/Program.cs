using System;

namespace RSPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string computerChoice = GetComputerChoice();
                // User chooses rock, paper, or scissors from the console
                string userChoice = GetUserChoice();
                // Compare the two choices and determine the winner
                string result = CompareResults(computerChoice, userChoice);
                Console.WriteLine(result);
                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain == "n")
                {
                    break;
                }
            }
            
        }
        static string GetUserChoice()
        {
            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine("Choose Rock, Paper, or Scissors: ");
                userChoice = Console.ReadLine();
                validChoice = userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            return userChoice;
        }

        static string CompareResults(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                return "Tie";
            }
            else if (userChoice == "Rock" && computerChoice == "Scissors" ||
                userChoice == "Paper" && computerChoice == "Rock" ||
                userChoice == "Scissors" && computerChoice == "Paper")
            {
                return "Win";
            }
            else
            {
                return "Lose";
            }
        }
        static string GetComputerChoice()
        {
            // Computer chooses a random number between 1 and 3
            Random random = new Random();
            //int computerChoice = random.Next(1, 4);
            string [] choices = { "Rock", "Paper", "Scissors" };
            // convert to string (rock, paper, scissors)
            string computerChoice = choices[random.Next(1, 4) - 1];
            return computerChoice;
        }
    }
}
