using System;
using System.Collections;
using Quadratic_Equations_Roots_API.Logic;

namespace Tests;

public class Tests
{
    const double Delta = 0.01;

    [TestCaseSource(nameof(GenerateTestCasesForTwoRootsTest))]
    public void TwoRootsTest1(int a, int b, int c, double[] expectedRoots)
    {
        //arrange
        var equation = new Equation(a, b, c);

        //act
        var roots = equation.SolveRoots();

        //assert
        Assert.That(roots[0], Is.EqualTo(expectedRoots[0]).Within(Delta));
        Assert.That(roots[1], Is.EqualTo(expectedRoots[1]).Within(Delta));
    }

    [Test]
    public void TwoRootsTest3()
    {
        var equation = new Equation(4, 21, 5);
        var expectedRoots = new double[2] { -5, -0.25 };

        Assert.That(equation.SolveRoots()[0], Is.EqualTo(expectedRoots[0]).Within(Delta));
        Assert.That(equation.SolveRoots()[1], Is.EqualTo(expectedRoots[1]).Within(Delta));
    }

    [Test]
    public void TwoRootsTest4()
    {
        var equation = new Equation(5, -14, -3);
        var expectedRoots = new[] { -0.2, 3 };
        var roots = equation.SolveRoots();

        Assert.That(roots[0], Is.EqualTo(expectedRoots[0]).Within(Delta));
        Assert.That(roots[1], Is.EqualTo(expectedRoots[1]).Within(Delta));
    }

    public class DoubleComparer : IComparer
    {
        private double _eps = 0.0000001;

        public int Compare(object? x, object? y)
        {
            var xValue = x is double dx ? dx : 0;
            var yValue = x is double dy ? dy : 0;
            if (Math.Abs(xValue - yValue) < _eps)
            {
                return 0;
            }

            return 1;
        }
    }

    [Test]
    public void OneRootTest1()
    {
        var equation = new Equation(9, -30, 25);
        var ans = new double[1] { 1.66 };
        var solvedRoots = equation.SolveRoots();
        //
        // Assert.That(equation.SolveRoots(), Is.EqualTo(ans).Within(Delta));
    }

    [Test]
    public void OneRootTest2()
    {
        var equation = new Equation(1, 12, 36);
        var ans = new double[1] { -6 };

        Assert.That(equation.SolveRoots(), Is.EqualTo(ans).Within(Delta));
    }

    [Test]
    public void NoRootsTest1()
    {
        var equation = new Equation(1, 12, 40);
        Assert.Throws<Exception>(() => equation.SolveRoots());
    }

    private static object[][] GenerateTestCasesForTwoRootsTest()
    {
        return new[]
        {
            new object[] { 2, 5, -3, new[] { -3, 0.5 } },
            new object[] { 3, -10, 3, new[] { 0.33, 3 } },
        };
    }
}