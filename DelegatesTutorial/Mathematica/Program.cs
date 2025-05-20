
var intagrator = new Integrator();

Console.WriteLine(intagrator.Integrate(0, 1, 0.01, new Squarer()));
Console.WriteLine(intagrator.Integrate(0, 1, 0.01, new Sinuser()));

public class Integrator
{
    public double Integrate(double start, double end, double step, IIntegrable function)
    {
        var sum = 0.0;

        for (var x = start; x < end; x += step)
        {
            var y = function.Calculate(x);
            sum += y * step;
        }

        return sum;
    }
}

public interface IIntegrable
{
    double Calculate(double x);
}

public class Squarer : IIntegrable
{
    public double Calculate(double x)
    {
        return x * x;
    }
}
public class Sinuser : IIntegrable
{
    public double Calculate(double x)
    {
        return Math.Sin(x);
    }
}