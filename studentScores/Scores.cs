using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentScores
{
    internal class Scores
    {
        public string course1;
        public string course2;
        public string course3;

        public int score1;
        public int score2;
        public int score3;

        public double avg;

        public Scores(string course1, string course2, string course3, int score1, int score2, int score3)
        {
            this.course1 = course1;
            this.course2 = course2;
            this.course3 = course3;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public string HighestScore()
        {
            int maxScore = (score1>score2)?(score1>score3?score1:score3):(score2>score3?score2:score3);
            if (maxScore == score1)
            {
                return $"{course1} with a score of {score1}";
            }
            else if (maxScore == score2)
            {
                return $"{course2} with a score of {score2}";
            }
            else
            {
                return $"{course3} with a score of {score3}";
            }
           
        }

        public void CalculateAverage()
        {
            this.avg = (score1 + score2 + score3) / 3.0;
        }

        public string ToGPA()
        {
            if (avg >= 95)
            {
                return "A+";
            }
            else if(avg >= 85)
            {
                return "A";
            }
            else if (avg >= 75)
            {
                return "B";
            }
            else if (avg >= 65)
            {
                return "C";
            }
            else if (avg >= 50)
            {
                return "P";
            }
            else
            {
                return "F";
            }
        }

        public override string ToString()
        {
            return $"Highest score : {HighestScore()}\n" +
                   $"Average sccore: {avg:F2}\n" +
                   $"GPA: {ToGPA()}\n";
        }
    }
}
