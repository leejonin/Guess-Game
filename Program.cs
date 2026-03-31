using System; 

namespace ConsoleAppPlay 
{
    class Program
    {
        static bool GameDone()
        {
            Console.WriteLine("Do you want to play again? (y/n)");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                return false; 
            }
            else if (input.ToLower() == "n")
            {
                return true; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                return GameDone(); 
            }
        }
        static void Main(string[] args) 
        {
            Random rdm = new Random();
            int an = rdm.Next(1, 100), guess, round = 0;
            bool game_done = false;
            while (!game_done)
            {
                if (round == 0)
                {
                    Console.WriteLine("Guess a number between 1 and 100:");
                }
                if(round == 3)
                {
                    Console.WriteLine($"The answer is {an}.");
                    game_done = GameDone();
                    if (!game_done)
                    {
                        an = rdm.Next(1, 100);
                        round = 0;
                        continue;
                    }
                    else if (game_done)
                    {
                        break;
                    }
                }
                guess = int.Parse(Console.ReadLine());
                if (guess < an)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > an)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (guess == an)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    game_done = GameDone();
                    if (!game_done)
                    {
                        an = rdm.Next(1, 100);
                        round = 0;
                        continue;
                    }
                    else if (game_done)
                    {
                        break;
                    }
                }
                round++;
            }
        }
    }
}