using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mark = 0;
            NumberGuess numberGuess = new NumberGuess();
            int generatedNum = numberGuess.GetNum();

            while (true)
            {
                Console.WriteLine
                    (
                    "Hi, please select one of the following options:\n"+
                    "1 --- you will guess the number;\n"+
                    "2 --- you want to know it is odd or even;\n"+
                    "3 --- you want to know if the num is bigger than certain nubmer;\n"+
                    "4 --- you want to quit the game;"
                    );

                if (!int.TryParse ( Console.ReadLine(), out int userInput))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (userInput == 1)
                {
                    Console.WriteLine("Please enter your guess: ");
                    if (!int.TryParse(Console.ReadLine(), out int guess))
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }

                    if (guess == generatedNum)
                    {
                        Console.WriteLine("You got it!");
                        mark += 10;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Try again!");
                        mark -= 1;
                    }
                }
                else if (userInput == 2)
                {
                    if (numberGuess.IsEven == 0)
                    {
                        Console.WriteLine("The number is even.");
                    }
                    else
                    {
                        Console.WriteLine("The number is odd.");
                    }
                    mark -= 1;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Please enter a number to compare: ");
                    if(!int.TryParse( Console.ReadLine(), out int compareNum))
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                }
                else if (userInput == 4)
                {
                    Console.WriteLine($"Your final mark is : {mark}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}
