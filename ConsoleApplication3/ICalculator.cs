using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface ICalculator
    {
        int Calculate(CalculateOption option, int firstNumber, int secondNumber);
    }
}
