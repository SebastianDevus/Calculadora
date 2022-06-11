namespace Calculadora.Lib;

public class ConversoesVisuais
{
    public static void MenuConversoes()
    {
        Console.Clear();
        string conversaoDesejada;

        do
        {
            Console.WriteLine("----- Conversões -----\n");
            Console.WriteLine("[1] Quilômetros para milhas");
            Console.WriteLine("[2] Milhas para quilômetros (KM)");
            Console.WriteLine("[3] Graus Celsius para Kelvin");
            Console.WriteLine("[4] Kelvin Para graus Celsius");
            Console.WriteLine("[5] Graus Celsius para graus Fahrenheit");
            Console.WriteLine("[6] Graus Fahrenheit para graus Celsius");

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

                    case "0":
                        return;
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

            // Pausando após a operação para o usuário ver o resultado e limpar o console depois
            Console.Write("\nPressione uma tecla para continuar...");
            Console.ReadKey();
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

        Console.WriteLine($"\nO equivalente em milhas é aproximadamente {distanciaMilhas}");
        return;
    }

    public static void MilhasParaQuilometrosVisuais()
    {
        Console.Clear();

        Console.WriteLine("----- Milhas para quilômetros -----\n");

        Console.Write("Insira a distância em M: ");
        double distanciaMilhas = Convert.ToDouble(Console.ReadLine());

        double distanciaQuilometros = Conversoes.KmParaMilhas(distanciaMilhas);

        Console.WriteLine($"\nO equivalente em quilômetros é aproximadamente {distanciaQuilometros}");
        return;
    }
}