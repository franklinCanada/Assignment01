using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment01.Tests
{
    public class Tests
    {
        [Test]
        public void GetRectangleLength_WhenLengthIsValid_OutputLength()
        {
            int length = 4;
            int width = 2;
            int expected = 4;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.GetLength();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleLength_WhenLengthIsLessThanZero_OutputLength()
        {
            int length = -3;
            int width = 2;
            int expected = 3;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.GetLength();
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleLength_WhenLengthIsUndefined_OutputDefaultLength()
        {
            int expected = 1;
            var rectangle = new Rectangle();
            int actual = rectangle.GetLength();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void SetRectangleLength_WhenLengthIsValid_OutputLength()
        {
            int length = 6;
            int width = 2;
            int expected = 6;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.SetLength(length);
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void SetRectangleLength_WhenLengthIsLessThanZero_OutputLength()
        {
            int length = -1;
            int width = 2;
            int expected = 4;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.SetLength(length);
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void SetRectangleLength_WhenLengthIsRedefined_OutputDefaultLength()
        {
            int expected = 1;
            var rectangle = new Rectangle();
            int actual = rectangle.SetLength(3);
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleWidth_WhenLengthIsValid_OutputWidth()
        {
            int length = 4;
            int width = 10;
            int expected = 12;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.GetWidth();
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleWidth_WhenLengthIsLessThanZero_OutputWidth()
        {
            int length = 3;
            int width = 6;
            int expected = 3;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.GetWidth();
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleWidth_WhenLengthIsUndefined_OutputDefaultWidth()
        {
            int expected = 1;
            var rectangle = new Rectangle();
            int actual = rectangle.GetLength();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void SetRectangleWidth_WhenWidthIsValid_OutputWidth()
        {
            int length = 6;
            int width = 2;
            int expected = 2;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.SetWidth(width);
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void SetRectangleWidth_WhenWidthIsLessThanZero_OutputWidth()
        {
            int length = -1;
            int width = 2;
            int expected = 4;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.SetLength(length);
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void SetRectangleWidth_WhenWidthIsRedefined_OutputDefaultWidth()
        {
            int expected = 3;
            var rectangle = new Rectangle();
            int actual = rectangle.SetWidth(3);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void GetRectanglePerimeter_WhenLengthAndBreadthIsValid_OutputPerimeter()
        {
            int length = 4;
            int width = 10;
            int expected = 28;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectanglePerimeter_WhenLengthAndBreadthNotDefined_OutputPerimeter()
        {
            int expected = 4;
            var rectangle = new Rectangle();
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectanglePerimeter_WhenLengthIsChanged_OutputPerimeter()
        {
            int expected = 20;
            var rectangle = new Rectangle();
            rectangle.SetLength(4);
            int actual = rectangle.GetPerimeter();
            Assert.AreNotEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleArea_WhenLengthAndBreadthIsValid_OutputArea()
        {
            int length = 4;
            int width = 10;
            int expected = 40;
            var rectangle = new Rectangle(length, width);
            int actual = rectangle.GetArea();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleArea_WhenLengthAndBreadthNotDefined_OutputArea()
        {
            int expected = 4;
            var rectangle = new Rectangle();
            int actual = rectangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        } 
        
        [Test]
        public void GetRectangleArea_WhenLengthIsChanged_OutputArea()
        {
            int expected = 20;
            var rectangle = new Rectangle();
            rectangle.SetLength(4);
            int actual = rectangle.GetArea();
            Assert.AreNotEqual(expected, actual);
        } 

    }
}