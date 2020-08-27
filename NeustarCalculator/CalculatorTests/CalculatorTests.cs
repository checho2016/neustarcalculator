using System;
using Xunit;

using NeustarCalculator;
using System.IO;

namespace CalculatorTests
{
    public class CalculationOperationsTests
    {
        [Fact]
        public void CalculatorAddition()
        {
            var calculator = new Calculator();
            var result = calculator.Add(5, 2);
            Assert.Equal(7, result);
        }
    }

    public class CalculatorConsoleIOTests
    {
        [Fact]
        public void ConsoleValidation()
        {
            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);

                //Program program = new Program();
                Program.Main(new string[] {"7","2"});

                string expected = "Please type the first number and press enter\n";
                expected += "Please type the second number and press enter\n";
                expected += "The result is 9\n";
            }
        }

        [Fact]
        public void StructureValidation()
        {
            //This test assures that the calculation is done specifically by the Calculator class and the result log is done specifically by the Logger class
            Assert.Equal("Calculator", Program.Calculate().GetType().Name);
            Assert.Equal("Logger", Program.LogResult().GetType().Name);
        }
    }
}
