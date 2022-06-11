namespace Calculadora.Lib;

public class Conversoes
{
    public static double KmParaMilhas(double distanciaKm)
    {
        return Math.Round((distanciaKm / 1.609), 3); // Arredondando para evitar resultado exageradamente longo e específico
    }

    public static double MilhaParaKm(double distanciaMilhas)
    {
        return Math.Round((distanciaMilhas * 1.609), 3); // Arredondando para evitar resultado exageradamente longo e específico
    }

    public static double CelsiusParaKelvin(double temperaturaCelsius)
    {
        if (temperaturaCelsius < -273.15)
        {
            throw new Exception("A temperatura inserida é menor que o zero absoluto (-273.15 C)");
        }
        else
        {
            // O número é Arredondado pois, por algum motivo, o C# retorna números longos e incorretos como resultado
            // EX: 30,15 + 273,15 retorna 303,29999999999995, ao invés de 303,3
            // O mesmo é valido para as outras conversões de temperatura
            return Math.Round((temperaturaCelsius + 273.15), 2);
        }
    }

    public static double KelvinParaCelsius(double temperaturaKelvin)
    {
        if (temperaturaKelvin < 0)
        {
            throw new Exception("A temperatura inserida é menor que o zero absoluto (0 K)");
        }
        else
        {
            return Math.Round((temperaturaKelvin - 273.15), 2);  // Arredondando para evitar resultado exageradamente longo e específico
        }
    }

    public static double FahrenheitParaCelsius(double temperaturaFah)
    {
        if (temperaturaFah < -459.67)
        {
            throw new Exception("A temperatura inserida é menor que o zero absoluto (-459.67 F)");
        }
        else
        {
            return Math.Round(((temperaturaFah - 32) * 5 / 9), 2); // Arredondando para evitar resultado exageradamente longo e específico
        }
    }

    public static double CelsiusParaFahrenheit(double temperaturaCelsius)
    {
        if (temperaturaCelsius < -273.15)
        {
            throw new Exception("A temperatura inserida é menor que o zero absoluto (-273.15 C)");
        }
        else
        {
            return Math.Round(((temperaturaCelsius * 9/5) + 32), 2); // Arredondando para evitar resultado exageradamente longo e específico
        }
    }

}