using Microsoft.AspNetCore.Mvc;
using Quadratic_Equations_Roots_API.Logic;

namespace Quadratic_Equations_Roots_API.Controllers;

[ApiController]
[Route("equation")]
public class EquationController : Controller
{
    [HttpPost("post")]
    public double[] PostSet([FromBody] Equation equation)
    {
        return equation.SolveRoots();
    }
    
    [HttpGet("get")]
    public double[] Set(double a, double b, double c)
    {
        var equation = new Equation(a, b, c);
        return equation.SolveRoots();
    }
}