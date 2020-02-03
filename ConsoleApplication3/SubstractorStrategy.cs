using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class SubstractorStrategy : ICalculateStrategy
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
