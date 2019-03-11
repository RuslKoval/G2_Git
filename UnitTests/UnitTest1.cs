using NUnit.Framework;
using System;


namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {     

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            Console.WriteLine("Before All Tests");
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Console.WriteLine("After All Tests");
        }

        [SetUp]
        public void BeforeEveryTest()
        {
            Console.WriteLine("Before Every Test");
        }

        [TearDown]
        public void AfterEveryTest()
        {
            Console.WriteLine("After Every Test");
        }

        [Category("SmokeTest")]
        [Category("CalculatorTest")]
        [Test]
        public void GetSumOftwoNumbers_ValidIntegers_Success()
        {
            Console.WriteLine("Test");

            // Arrange
            int firstNumber = 2;
            int secondNumber = 5;
            int expectedResult = 7;

            // Act
            int actualResult = Calculator.
                GetSumOftwoNumbers(firstNumber, secondNumber);

            // Assert
            Assert.True(actualResult == expectedResult,
                $"SUM of {firstNumber} and {secondNumber} returned {actualResult}, but expected {expectedResult}");

        }

        [Test]
        public void SecondTest()
        {
            Console.WriteLine("Test2");
        }
    }
}
