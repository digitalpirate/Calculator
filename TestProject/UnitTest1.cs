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
            
            
            double x = 50;
            double y = 10;
            double testResult = 50 + 10;


            Calculator.Program.Add(x, y).Equals(testResult);


        }
    }
}