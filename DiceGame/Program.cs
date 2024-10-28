using System.Resources;

namespace DiceGame;

class Program
{
    static void Main(string[] args)
    {
        int attempts = 0;
        
        DiceGame game = new DiceGame();
        game.Roll();

        while (true)
        {
            Console.WriteLine("Welcome to DiceGame!\n");
            Console.WriteLine("1--- You can guess a number.\n"+
                              "2--- You can know the number is even or odd.\n"+
                              "3--- Exit the game");

            if (!int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (userInput < 1 || userInput > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3");
                    continue;
                }
            }

            if (userInput == 1)
            {
                Console.WriteLine("Please enter a number: ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess < 1 || guess > 6)
                    {
                        Console.WriteLine("Please enter a number between 1 and 6");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Processing...");
                    }
                }
                game.GuessNumber(guess);

                if (guess == game.dice)
                {
                    Console.WriteLine("You won the game!");
                    break;
                }
            }


            if (userInput == 2)
            {
                Console.WriteLine(game.CheckEven());
            }

            if (userInput == 3)
            {
                Console.WriteLine("Do you want to exit the game? : (Y/N)");
                string response = Console.ReadLine();

                if (response.ToUpper() == "Y")
                {
                    Console.WriteLine(game.GetAttempts());
                    break;
                }
            }
        }

        Console.ReadKey();
    }
}