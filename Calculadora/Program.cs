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
            case ("1"):
                AritmeticaVisuais.AdicaoVisuais();
                break;

            case ("2"):
                AritmeticaVisuais.SubtracaoVisuais();
                break;

            case ("3"):
                AritmeticaVisuais.MultiplicacaoVisuais();
                break;

            case ("4"):
                AritmeticaVisuais.DivisaoVisuais();
                break;

            case ("5"):
                AritmeticaVisuais.ExponenciacaoVisuais();
                break;

            case ("6"):
                AritmeticaVisuais.RadiciacaoVisuais();
                break;

            case ("C"):
                ConversoesVisuais.MenuConversoes();
                break;

            case ("S") or ("s"):
                VisuaisMiscelanios.ExibeSobre();
                break;

            case ("0"):
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nObrigado por usar meu programa!\n");
                return;

            default:
                throw new Exception("Opção inválida!");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(); // Espaçamento
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
while (opcaoDesejada != "0");