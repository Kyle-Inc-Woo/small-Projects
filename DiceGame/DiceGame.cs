using System.Net;

namespace DiceGame;

public class DiceGame
{
    public int dice;
    public int attempts = 0;
    public int isEven = 0;

    public void Roll()
    {
        Random rnd = new Random();
        dice = rnd.Next(1, 7);
    }

    public void GuessNumber(int guess)
    {
        if (guess == dice)
        {
            Console.WriteLine("Correct1!");
            attempts++;
            Console.WriteLine(GetAttempts());
            
        }
        else
        {
            Console.WriteLine("Wrong, try again!");
            attempts++;
        }
    }

    public string CheckEven()
    {
        isEven = dice % 2;

        if (isEven == 0)
        {
            return $"The number is even";
        }
        else
        {
            return $"The number is odd";
        }
    }

    public string GetAttempts()
    {
        return$"The attempts: {attempts}";
    }
}