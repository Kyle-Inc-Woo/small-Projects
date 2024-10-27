using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                //First course & score
                Console.WriteLine("Enter the name of first coures: ");
                string course1 = Console.ReadLine();
                Console.WriteLine("Enter the score for first course: ");
                if(!int.TryParse(Console.ReadLine(), out int score1))
                {
                    Console.WriteLine("Invalid input, Please enter again");
                    continue;
                }

                //Second course & score
                Console.WriteLine("Enter the name of second coures: ");
                string course2 = Console.ReadLine();
                Console.WriteLine("Enter the score for second course: ");
                if (!int.TryParse(Console.ReadLine(), out int score2))
                {
                    Console.WriteLine("Invalid input, Please enter again");
                    continue;
                }

                //Third course & score
                Console.WriteLine("Enter the name of third coures: ");
                string course3 = Console.ReadLine();
                Console.WriteLine("Enter the score for third course: ");
                if (!int.TryParse(Console.ReadLine(), out int score3))
                {
                    Console.WriteLine("Invalid input, Please enter again");
                    continue;
                }

                Scores scores = new Scores(course1, course2, course3, score1, score2, score3);

                scores.CalculateAverage();
                Console.WriteLine(scores.ToString());

                counter++;

                Console.WriteLine("Do you want to continue? (y/n): ");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine($"\nNumber of calculations done: {counter}");
        }
    }
}
