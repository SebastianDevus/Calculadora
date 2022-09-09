namespace Calculadora.Lib;

public class CalculosDiversos
{
    public static double BhaskaraCalculaDelta(double a, double b, double c)
    {
        return Math.Pow(b, 2) - 4 * a * c;
    }

    public static double BhaskaraCalculaRaiz1(double a, double b, double delta)
    {
        return (-b + Math.Sqrt(delta)) / (2 * a);
    }

    public static double BhaskaraCalculaRaiz2(double a, double b, double delta)
    {
        return (-b - Math.Sqrt(delta)) / (2 * a);
    }
}