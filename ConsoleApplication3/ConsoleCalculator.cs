using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ConsoleCalculator : ICalculator
    {
        private readonly ILogger _logger;
        public ConsoleCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public ConsoleCalculator()
        {
            _logger = new ConsoleLogger();
        }

        public int Calculate(CalculateOption option, int firstNumber, int secondNUmber)
        {
            ICalculateStrategy strategy;

            switch(option)
            {
                case CalculateOption.Add:
                    strategy = new AddStrategy();
                    break;
                case CalculateOption.Substract:
                    strategy = new SubstractorStrategy();
                    break;
                default:
                    string message = "Nie wybrałeś odpowiedniej opcji. Wybierz 1 lub 2.";
                    _logger.Log(message);
                    throw new NotSupportedException(message);
            }

            int result = strategy.Calculate(firstNumber, secondNUmber);
            _logger.Log("Wynik obliczeń: " + result);

            return result;
        }
    }
}
