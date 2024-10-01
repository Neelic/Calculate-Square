using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateSquare.Tests;

[TestClass]
[TestSubject(typeof(Circle))]
public class CircleTest
{
    [TestMethod]
    public void CalculateSquare()
    {
        var circle = new Circle(6);
        var square = circle.CalculateSquare();

        Assert.AreEqual(113.097, square, 0.001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithZeroRadius()
    {
        var circle = new Circle(0);
        circle.CalculateSquare();

        Assert.Fail();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CalculateSquareWithBelowZeroRadius()
    {
        var circle = new Circle(-2.5);
        circle.CalculateSquare();

        Assert.Fail();
    }
}