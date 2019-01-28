using System;
using Rectangle;
using NUnit.Framework;

namespace Rectangle.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void GetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);
            //Act
            int length = testRectangle.GetLength();
            //Assert
            Assert.AreEqual(length, 3);
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void GetWidth_input4_expectWidthEquals4()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);
            //Act
            int width = testRectangle.GetWidth();
            //Assert
            Assert.AreEqual(width, 4);
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void SetLength_input3_expectLengthEquals3()
        {
            //Arrange
            int l = 3;
            // int w = 4;
            Rectangle testRectangle = new Rectangle();
            //Act
            int length = testRectangle.SetLength(l);
            //Assert
            Assert.AreEqual(length, 3);
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void SetWidth_input4_expectWidthEquals4()
        {
            //Arrange
            //int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle();
            //Act
            int width = testRectangle.SetWidth(w);
            //Assert
            Assert.AreEqual(width, 4);
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void GetPerimeter_input3_4_expectLengthEquals14()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);
            //Act
            int length = testRectangle.GetPerimeter();
            //Assert
            Assert.AreEqual(length, 14);
            Console.WriteLine("Please check the result");
        }

        [Test]
        public void GetArea_input3_4_expectWidthEquals12()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle testRectangle = new Rectangle(l, w);
            //Act
            int width = testRectangle.GetArea();
            //Assert
            Assert.AreEqual(width, 12);
            Console.WriteLine("Please check the result");
        }
    }
}