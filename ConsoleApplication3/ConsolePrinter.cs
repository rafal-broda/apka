using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ConsolePrinter : IPrinter
    {
        private readonly ILogger _logger;
        public ConsolePrinter(ILogger logger)
        {
            _logger = logger;
        }

        public ConsolePrinter()
        {
            _logger = new ConsoleLogger();
        }

        public int GetNumber()
        {
            string number = Console.ReadLine();
            return ParseNumber(number);
        }

        public CalculateOption GetCalculateOption()
        {
            CalculateOption calculateOption = CalculateOption.None;

            _logger.Log("Wprowadź odpowiednią opcje: \n 1.Dodawanie \n 2.Odejmowanie");
            int option = GetNumber();
            while (option != 1 && option != 2)
            {
                _logger.Log("Wprowadziłeś złą opcję. Wyberz 1 lub 2.");
                option = GetNumber();
            }

            if (option == 1)
            {
                calculateOption = CalculateOption.Add;
            }

            if (option == 2)
            {
                calculateOption = CalculateOption.Substract;
            }

            return calculateOption;
        }

        private int ParseNumber(string input)
        {
            int digit;

            bool isParsed = Int32.TryParse(input, out digit);
            if (!isParsed)
            {
                _logger.Log("Wprowadziłeś daną w złym formacie. Proszę, spróbuj wprowadzić cyfrę.");
                return GetNumber();
            }

            return digit;
        }
    }
}
