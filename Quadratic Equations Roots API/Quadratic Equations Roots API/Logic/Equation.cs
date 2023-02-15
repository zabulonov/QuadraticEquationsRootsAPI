namespace Quadratic_Equations_Roots_API.Logic;

public class Equation
{
    public double A { get; }
    public double B { get;}
    public double C { get; }


    public Equation(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }
    
    public double[] SolveRoots()
    {
        var d = Math.Pow(B, 2) - 4 * A * C;
        
        switch (d)
        {
            case >0:
                var x = new double[2];
                x[0] = (-1 * B - Math.Sqrt(d)) / (2 * A); 
                x[1] = (-1 * B + Math.Sqrt(d)) / (2 * A);
                return x;
            case 0:
                var x1 = new double[1];
                x1[0] = -1 * B / (2 * A);
                return x1;
            case <0:
                throw new Exception("No roots!");
        }
        throw new Exception("Как ты сюда попал?");
    }
}