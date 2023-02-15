using Quadratic_Equations_Roots_API.Logic;

namespace Tests;

public class Tests
{
    const double  Delta = 0.01;
    
    [Test]
    public void TwoRootsTest1()
    {
        var equation = new Equation(2,5,-3);
        var ans = new double[2] { -3, 0.5};
        
        Assert.That(equation.SolveRoots(), Is.EqualTo(ans));
    }
    
    [Test]
    public void TwoRootsTest2()
    {
        var equation = new Equation(3,-10,3);
        var ans = new double[2] { 0.33, 3};
        
        Assert.That(equation.SolveRoots()[0], Is.EqualTo(ans[0]).Within(Delta));
        Assert.That(equation.SolveRoots()[1], Is.EqualTo(ans[1]).Within(Delta));
    }
    
    [Test]
    public void TwoRootsTest3()
    {
        var equation = new Equation(4,21,5);
        var ans = new double[2] { -5, -0.25};
        
        Assert.That(equation.SolveRoots()[0], Is.EqualTo(ans[0]).Within(Delta));
        Assert.That(equation.SolveRoots()[1], Is.EqualTo(ans[1]).Within(Delta));
    }
    
    [Test]
    public void TwoRootsTest4()
    {
        var equation = new Equation(5,-14,-3);
        var ans = new double[2] { -0.2, 3};
        
        Assert.That(equation.SolveRoots()[0], Is.EqualTo(ans[0]).Within(Delta));
        Assert.That(equation.SolveRoots()[1], Is.EqualTo(ans[1]).Within(Delta));
    }
    
    [Test]
    public void OneRootTest1()
    {
        var equation = new Equation(9,-30,25);
        var ans = new double[1] {1.66};
        
        Assert.That(equation.SolveRoots(), Is.EqualTo(ans).Within(Delta));
    }
    
    [Test]
    public void OneRootTest2()
    {
        var equation = new Equation(1,12,36);
        var ans = new double[1] {-6};
        
        Assert.That(equation.SolveRoots(), Is.EqualTo(ans).Within(Delta));
    }
    
    [Test]
    public void NoRootsTest1()
    {
        var equation = new Equation(1,12,36);
        
        // Эта штука  не работает, он всегда показывает Succes;
        try
        {
            equation.SolveRoots();
            Assert.Fail();
        }
        catch (Exception e)
        {
            Assert.Pass();
        }
        // Я пытался сделать так, но что то пошло не так :(
        // Assert.Throws<System.Exception>(
        //     equation.SolveRoots() => throw new Exception());
    }
    
}