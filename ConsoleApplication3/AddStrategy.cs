using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class AddStrategy : ICalculateStrategy
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            checked
            {
                int result = firstNumber + secondNumber;
                return result;
            }
        }
    }
}
