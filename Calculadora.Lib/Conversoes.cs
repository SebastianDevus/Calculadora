namespace Calculadora.Lib;

public class Conversoes
{
    public static double KmParaMilhas(double distanciaKm)
    {
        return Math.Round((distanciaKm / 1.609), 3);
    }

    public static double MilhaParaKm(double distanciaMilhas)
    {
        return Math.Round((distanciaMilhas * 1.609), 3);
    }
}