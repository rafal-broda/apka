using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        private static ILogger _logger;
        private static IPrinter _printer;
        private static ICalculator _calculator;

        static void Main(string[] args)
        {
            InjectServices();
            RunCalculator();
        }

        static void RunCalculator()
        {
            Console.WriteLine("Proszę, wprowadź pierwszą liczbę.");
            int firtNumber = _printer.GetNumber();

            Console.WriteLine("Proszę, wprowadź drugą cyfrę.");
            int secondNUmber = _printer.GetNumber();

            CalculateOption option = _printer.GetCalculateOption();
            _calculator.Calculate(option,firtNumber, secondNUmber);

            Console.WriteLine("Aby zakończyć wciśnij dowolny przycisk");
            Console.ReadKey();
        }



        private static void InjectServices()
        {
            _logger = new ConsoleLogger();
            _printer = new ConsolePrinter(_logger);
            _calculator = new ConsoleCalculator(_logger);
        }
    }
}