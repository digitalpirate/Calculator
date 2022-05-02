using System;
using Xunit;
using static Calculator.Program;
namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            double expected = 50;


            //Act
            double actual = Calculator.Program.Add(10, 40);

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}