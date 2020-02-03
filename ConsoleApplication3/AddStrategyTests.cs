using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    [TestClass]
    public class AddStrategyTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.OverflowException))]
        public void Calculate_WithNumbersSumGreaterThanIntMax_ThrowsException()
        {
            //Arrange
            ICalculateStrategy addStrategy = new AddStrategy();
            int firstNumber = int.MaxValue;
            int secondNumber = 10;

            //Act
            var sum = addStrategy.Calculate(firstNumber, secondNumber);

        }
    }
}
