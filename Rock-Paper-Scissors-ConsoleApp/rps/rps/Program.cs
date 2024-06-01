namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Enter rock, paper, or scissors:");
                string userChoice = Console.ReadLine().ToLower();

                if (!Array.Exists(choices, choice => choice == userChoice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                string computerChoice = choices[random.Next(choices.Length)];
                Console.WriteLine($"Computer chose: {computerChoice}");

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((userChoice == "rock" && computerChoice == "scissors") ||
                         (userChoice == "paper" && computerChoice == "rock") ||
                         (userChoice == "scissors" && computerChoice == "paper"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                string playAgainResponse = Console.ReadLine().ToLower();
                playAgain = playAgainResponse == "y";
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}