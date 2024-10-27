using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class NumberGuess
    {
        private int num;
        public int IsEven { get; set; }
        public bool IsBigger { get; private set; }

        public NumberGuess()
        {
           Generate();
        }

        public void Generate()
        {
            Random rnd = new Random();
            num = rnd.Next(1,11);
            IsEven = num % 2;
        }

        public int GetNum()
        {
            return num;
        }

        public void Compare(int userInput)
        {
            IsBigger = userInput < num;
        }
    }
}
