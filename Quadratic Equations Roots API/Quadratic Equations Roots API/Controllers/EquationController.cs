using Microsoft.AspNetCore.Mvc;
using Quadratic_Equations_Roots_API.Logic;

namespace Quadratic_Equations_Roots_API.Controllers;

[ApiController]
[Route("Equation")]
public class EquationController : Controller
{
    [HttpPost("Post")]
    public double[] PostSet([FromBody] Equation equantion)
    {
        return equantion.SolveRoots();
    }
    
    [HttpGet("Get")]
    public double[] Set(double a, double b, double c)
    {
        var equation = new Equation(a, b, c);
        return equation.SolveRoots();
    }
    
    [HttpGet("{a}/{b}/{c}")] 
    public double[] Set2(double a, double b, double c)
    {
        var equation = new Equation(a, b, c);
        return equation.SolveRoots();
    }
}