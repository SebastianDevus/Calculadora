//Permitindo que os métodos de Visuais sejam chamados
using Calculadora.Lib;

string opcaoDesejada;

do
{
    Console.Clear();

    Console.WriteLine("----- Calculadora -----\n");
    Console.WriteLine("[1] Adição");
    Console.WriteLine("[2] Subtração");
    Console.WriteLine("[3] Multiplicação");
    Console.WriteLine("[4] Divisão");
    Console.WriteLine("[5] Exponenciação");
    Console.WriteLine("[6] Radiciação");

    Console.WriteLine("\n[C] Conversões");

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
            case "1":
                AritmeticaVisuais.AdicaoVisuais();

                VisuaisMiscelanios.Pausa();
                break;

            case "2":
                AritmeticaVisuais.SubtracaoVisuais();

                VisuaisMiscelanios.Pausa();
                break;

            case "3":
                AritmeticaVisuais.MultiplicacaoVisuais();

                VisuaisMiscelanios.Pausa();
                break;

            case "4":
                AritmeticaVisuais.DivisaoVisuais();

                VisuaisMiscelanios.Pausa();
                break;

            case "5":
                AritmeticaVisuais.ExponenciacaoVisuais();

                VisuaisMiscelanios.Pausa();
                break;

            case "6":
                AritmeticaVisuais.RadiciacaoVisuais();

                VisuaisMiscelanios.Pausa();
                break;

            case "C" or "c":
                ConversoesVisuais.MenuConversoes();
                break;

            case "S" or "s":
                VisuaisMiscelanios.ExibeSobre();

                VisuaisMiscelanios.Pausa();
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
        VisuaisMiscelanios.ExibeMensagemDeErro(e.Message);
        
        VisuaisMiscelanios.Pausa();
    }
    finally
    {
        Console.ResetColor();
    }
}
while (opcaoDesejada != "0");