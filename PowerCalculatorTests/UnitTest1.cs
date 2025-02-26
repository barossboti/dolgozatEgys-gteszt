using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power;
using System;

namespace PowerCalculatorTests
{
    [TestClass]
    public class PowerCalculatorTests
    {
        [TestMethod]
        public void TestPositiveExponent()
        {
            //Arrange
            var calculator = new PowerCalculator();
            double basee = 2;
            int exponent = 3;
            //Act
            double result = calculator.CalculatePower(basee, exponent);
            //Assert
            Assert.Equals(0, result);
        }

        [TestMethod]
        public void TestNegativeExponent()
        {
            //Arrange
            var calculator = new PowerCalculator();
            double basee = 2;
            int exponent = -2;
            //Act
            double result = calculator.CalculatePower(basee, exponent);
            //Assert
            Assert.Equals(0.25, result);
        }
        [TestMethod]
        public void TestZeroBaseZeroExponent()
        {
            //Arrange
            var calculator = new PowerCalculator();
            double basee = 0;
            int exponent = 0;
            //Act
            double result = calculator.CalculatePower(basee, exponent);
            //Assert
            Assert.Equals(0, result);
        }
        [TestMethod]
        public void TestOneBaseAnyExponent()
        {
            //Arrange
            var calculator = new PowerCalculator();
            double basee = 1;
            int exponent = 100;
            //Act
            double result = calculator.CalculatePower(basee, exponent);
            //Assert
            Assert.Equals(1, result);
        }
        [TestMethod]
        public void TestNegativeBaseEvenExponent()
        {
            //Arrange
            var calculator = new PowerCalculator();
            double basee = (-3);
            int exponent = 4;
            //Act
            double result = calculator.CalculatePower(basee, exponent);
            //Assert
            Assert.Equals(1, result);
        }
    }
}
