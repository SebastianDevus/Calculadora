namespace Calculadora.Lib;

public class ConversoesVisuais
{
    public static void MenuConversoes()
    {
        string conversaoDesejada;

        do
        {
            Console.Clear();
            Console.WriteLine("----- Conversões -----\n");
            Console.WriteLine("[1] Quilômetros para milhas");
            Console.WriteLine("[2] Milhas para quilômetros (KM)");
            Console.WriteLine("[3] Graus Celsius para Kelvin");
            Console.WriteLine("[4] Kelvin Para graus Celsius");
            Console.WriteLine("[5] Graus Celsius para graus Fahrenheit");
            Console.WriteLine("[6] Graus Fahrenheit para graus Celsius");
            Console.WriteLine("[7] Graus Fahrenheit para Kelvin");
            Console.WriteLine("[8] Kelvin para graus Fahrenheit");

            Console.WriteLine("\n[0] Voltar");

            Console.Write("\nEscolha uma opção: ");
            conversaoDesejada = Console.ReadLine()!;

            try
            {
                switch (conversaoDesejada)
                {
                    case "1":
                        QuilometrosParaMilhasVisuais();
                        break;

                    case "2":
                        MilhasParaQuilometrosVisuais();
                        break;

                    case "3":
                        CelsiusParaKelvinVisuais();
                        break;

                    case "4":
                        KelvinParaCelsiusVisuais();
                        break;

                    case "5":
                        CelsiusParaFahrenheitVisuais();
                        break;

                    case "6":
                        FahrenheitParaCelsiusVisuais();
                        break;

                    case "7":
                        FahrenheitParaKelvinVisuais();
                        break;

                    case "8":
                        KelvinParaFahrenheitVisuais();
                        break;

                    case "0":
                        return;

                    default:
                        throw new Exception("Opção inválida!");
                }
            }
            catch (Exception e)
            {
                VisuaisMiscelanios.ExibeMensagemDeErro(e.Message);
            }
            finally
            {
                Console.ResetColor();
            }

            VisuaisMiscelanios.Pausa();
        }
        while (conversaoDesejada != "0");

        return;
    }

    public static void QuilometrosParaMilhasVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Quilômetros para milhas -----\n");

        Console.Write("Insira a distância em KM: ");
        double distanciaQuilometros = Convert.ToDouble(Console.ReadLine());

        double distanciaMilhas = Conversoes.KmParaMilhas(distanciaQuilometros);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em milhas é aproximadamente {distanciaMilhas} M");

        return;
    }

    public static void MilhasParaQuilometrosVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Milhas para quilômetros -----\n");

        Console.Write("Insira a distância em M: ");
        double distanciaMilhas = Convert.ToDouble(Console.ReadLine());

        double distanciaQuilometros = Conversoes.MilhaParaKm(distanciaMilhas);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em quilômetros é aproximadamente {distanciaQuilometros} Km");

        return;
    }

    public static void CelsiusParaKelvinVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Celsius para Kelvin -----\n");

        Console.Write("Insira a temperatura em graus Celsius: ");
        double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

        double temperaturaKelvin = Conversoes.CelsiusParaKelvin(temperaturaCelsius);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em Kelvin é {temperaturaKelvin} K");

        return;
    }

    public static void KelvinParaCelsiusVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Kelvin para Celsius -----\n");

        Console.Write("Insira a temperatura em Kelvin: ");
        double temperaturaKelvin = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsius = Conversoes.KelvinParaCelsius(temperaturaKelvin);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em graus Celsius é {temperaturaCelsius} °C");

        return;
    }

    public static void CelsiusParaFahrenheitVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Celsius para Fahrenheit -----\n");

        Console.Write("Insira a temperatura em graus Celsius: ");
        double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

        double temperaturaFahrenheit = Conversoes.CelsiusParaFahrenheit(temperaturaCelsius);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em graus Fahrenheit é aproximadamente {temperaturaFahrenheit} °F");

        return;
    }

    public static void FahrenheitParaCelsiusVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Fahrenheit para Celsius -----\n");

        Console.Write("Insira a temperatura em graus Fahrenheit: ");
        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsius = Conversoes.FahrenheitParaCelsius(temperaturaFahrenheit);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em graus Celsius é aproximadamente {temperaturaCelsius} °C");

        return;
    }

    public static void FahrenheitParaKelvinVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Fahrenheit para Kelvin -----\n");

        Console.Write("Insira a temperatura em graus Fahrenheit: ");
        double temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsius = Conversoes.FahrenheitParaCelsius(temperaturaFahrenheit);
        double temperaturaKelvin = Conversoes.CelsiusParaKelvin(temperaturaCelsius);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em Kelvin é aproximadamente {temperaturaKelvin} K");

        return;
    }

    public static void KelvinParaFahrenheitVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Kelvin para Fahrenheit -----\n");

        Console.Write("Insira a temperatura em Kelvin: ");
        double temperaturaKelvin = Convert.ToDouble(Console.ReadLine());

        double temperaturaCelsius = Conversoes.KelvinParaCelsius(temperaturaKelvin);
        double temperaturaFahrenheit = Conversoes.CelsiusParaFahrenheit(temperaturaCelsius);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO equivalente em graus Fahrenheit é aproximadamente {temperaturaFahrenheit} °F");

        return;
    }
}