# TestCalculator

using System;
using Xunit;
using TestCalculator;

namespace TestCalculator.Test
{
    public class MathTest
    {
        [Fact]
        public void MathiniTest()

        {
       //Arrange
            decimal num1 = 10;
            decimal num2 = 2;
            int num3 = 3;
            int num4 = 6;
            int resultm = 0;
            int resultd = 0;
            int[] Addarray = { 1, 2, 3, 1 };
            int[] subtracts = new int[3] { 30, 10, 15 };
            //Act

            CountNumber count  = new CountNumber(num1, num2,num3, num4,resultm,resultd, Addarray,subtracts);

            //Assert
            Assert.Equal( 10 , count.num1);
            Assert.Equal(2, count.num2);
            Assert.Equal(3,count.num3);
            Assert.Equal(6,count.num4);
            Assert.Equal(2, count.resultm);
            Assert.Equal(2, count.resultd);
            Assert.Equal(5, count.subtracts);
            Assert.Equal(7, count.Addarray);

        }
        [Fact]
        public void AddMathTest()
        {
            //Arrange
            decimal num1 = 10;
            decimal num2 = 2;
            int num3 = 3;
            int num4 = 6;
            int resultm = 0;
            int resultd = 0;
            int[] Addarray = { 1, 2, 3, 1 };
            int[] subtracts = new int[3] { 30, 10, 15 };
            //Act
            //assert 
            
            CountNumber count = new CountNumber(num1, num2, num3, num4, resultm, resultd, Addarray, subtracts);

            int Result  = count.Addarray;

            Assert.True(Result == 1);
            //Assert

        }
        [Fact]
        public void SubtractMathTest()
        {
            //Arrange
            decimal num1 = 10;
            decimal num2 = 2;
            int num3 = 3;
            int num4 = 6;
            int resultm = 0;
            int resultd = 0;
            int[] Addarray = { 1, 2, 3, 1 };
            int[] subtracts = new int[3] { 30, 10, 15 };
            //Act
            //assert 

            CountNumber count = new CountNumber(num1, num2, num3, num4, resultm, resultd, Addarray, subtracts);

            int Test = count.subtracts;

            Assert.True(Test == 1);
            //Assert

        }
        [Fact]
        public void DevisionMathTest()
        {
            //Arrange
            decimal num1 = 10;
            decimal num2 = 2;
            int num3 = 3;
            int num4 = 6;
            int resultm = 0;
            int resultd = 0;
            int[] Addarray = { 1, 2, 3, 1 };
            int[] subtracts = new int[3] { 30, 10, 15 };
            //Act
            //assert

            CountNumber count = new CountNumber(num1, num2, num3, num4, resultm, resultd, Addarray, subtracts);

            int devision = count.resultd;

            Assert.True(devision == 1);
            //Assert

        }
        [Fact]
        public void MultyplayTest()
        {
            //Arrange
            decimal num1 = 10;
            decimal num2 = 2;
            int num3 = 3;
            int num4 = 6;
            int resultm = 0;
            int resultd = 0;
            int[] Addarray = { 1, 2, 3, 1 };
            int[] subtracts = new int[3] { 30, 10, 15 };
            //Act
            //assert 

            CountNumber count = new CountNumber(num1, num2, num3, num4, resultm, resultd, Addarray, subtracts);

            int multplay = count.resultm;

            Assert.True(multplay == 1);
            //Assert

        }
    }
   
}
