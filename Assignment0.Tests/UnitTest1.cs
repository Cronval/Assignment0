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

        [Fact]
        public void Main_is_2020_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2020");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

         [Fact]
        public void Main_is_1600_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1600");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

         [Fact]
        public void Main_is_2021_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2021");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }

         [Fact]
        public void Main_is_1900_LeapYear()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1900");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }
    }
}
