using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calcuInstance = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            var act = calcuInstance.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(10, 3, 7)]//Add test data <-------

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var calcuInstance = new Calculator();
            //Act
            var act = calcuInstance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(4,10,40)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calcuInstance = new Calculator();
            //Act
            var act = calcuInstance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, act);
        }

        [Theory]
        [InlineData(32, 4, 8)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calcuInstance =  new Calculator(); 
            //Act
            var act = calcuInstance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, act);
        }

    }
}
