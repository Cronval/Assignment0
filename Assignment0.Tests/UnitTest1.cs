using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void test_is_2020_LeapYear()
        {
            //Arrange
            var input = 2020;

            //Act
            var output = Program.isLeapyear(input);

            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void test_is_1600_LeapYear()
        {
            //Arrange
            var input = 1600;

            //Act
            var output = Program.isLeapyear(input);

            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void test_is_2021_LeapYear()
        {
            //Arrange
            var input = 2021;

            //Act
            var output = Program.isLeapyear(input);

            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void test_is_1900_LeapYear()
        {
            //Arrange
            var input = 1900;

            //Act
            var output = Program.isLeapyear(input);

            //Assert
            Assert.Equal(false, output);
        }
    }
}
