using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateSquare.Tests;

[TestClass]
[TestSubject(typeof(Triangle))]
public class TriangleTest
{

    [TestMethod]
    public void CalculateSquare()
    {
        var triangle = new Triangle(3, 3, 5);
        var square = triangle.CalculateSquare();
        
        Assert.AreEqual(4.145, square, 0.001);
    }
    
    [TestMethod]
    public void CalculateSquareRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        var square = triangle.CalculateSquare();
        
        Assert.AreEqual(6, square, 0.001);
        Assert.IsTrue(triangle.IsRightTriangle);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithBelowZeroSide1()
    {
        var triangle = new Triangle(-3, 4, 5);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithBelowZeroSide2()
    {
        var triangle = new Triangle(3, -4, 5);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithBelowZeroSide3()
    {
        var triangle = new Triangle(3, 4, -5);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithZeroSide1()
    {
        var triangle = new Triangle(0, 4, 5);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithZeroSide2()
    {
        var triangle = new Triangle(3, 0, 5);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithZeroSide3()
    {
        var triangle = new Triangle(3, 4, 0);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithNonExistTriangle()
    {
        var triangle = new Triangle(10, 4, 5);
        triangle.CalculateSquare();
        
        Assert.Fail();
    }
}
