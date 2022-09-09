//Permitindo que os métodos de Visuais sejam chamados
using Calculadora.Lib;

string opcaoDesejada;

do
{
    Console.Clear();

    Console.WriteLine("----- Calculadora -----\n");
    Console.WriteLine("[A] Aritmética");
    Console.WriteLine("[C] Conversões");

    Console.WriteLine("\n[S] Sobre");
    Console.WriteLine("[0] Sair");

    Console.Write("\nEscolha uma opção: ");
    opcaoDesejada = Console.ReadLine()!;

    // Chama o método apropriado dependendo da operação escolhida
    // Os métodos estão no diretório Calculadora.Lib, arquivo AritmeticaVisuais
    try
    {
        switch (opcaoDesejada)
        {
            case "A" or "a":
                AritmeticaVisuais.MenuAritmetica();
                break;
            case "C" or "c":
                ConversoesVisuais.MenuConversoes();
                break;

            case "S" or "s":
                VisuaisUniversais.ExibeSobre();

                VisuaisUniversais.Pausa();
                break;

            case "0":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nObrigado por usar meu programa!");
                return;

            default:
                throw new Exception("Opção inválida!");
        }
    }
    catch (Exception e)
    {
        VisuaisUniversais.ExibeMensagemDeErro(e.Message);

        VisuaisUniversais.Pausa();
    }
    finally
    {
        Console.ResetColor();
    }
}
while (opcaoDesejada != "0");