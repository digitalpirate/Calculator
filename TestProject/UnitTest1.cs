using System;
using Xunit;
using Calculator;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            

            string input1 = "50";
            string input2 = "10";

            //Act

            double testResult = 50 + 10;
            Add(input1, input2);
            
            //Assert

            Assert.Equal(testResult, Add.result);

        }
    }
}
