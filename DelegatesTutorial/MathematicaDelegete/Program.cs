
var intagrator = new Integrator();

Console.WriteLine(intagrator.Integrate(0, 1, 0.01, x => Math.Sin(x)));
Console.WriteLine(intagrator.Integrate(0, 1, 0.01, x => x*x));

void OutputMessage(string message)
{
    Console.WriteLine(message);
}
public class Integrator
{
    public double Integrate(double start, double end, double step, Func<double, double> function)
    {
        var sum = 0.0;

        for (var x = start; x < end; x += step)
        {
            var y = function(x);
            sum += y * step;
        }

        return sum;
    }
}
