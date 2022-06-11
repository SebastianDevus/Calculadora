//Permitindo que os métodos de Visuais sejam chamados
using Calculadora.Lib;

string operacaoDesejada;

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
    Console.Write("\nEscolha uma operação: ");
    operacaoDesejada = Console.ReadLine()!;

    // Chama o método apropriado dependendo da operação escolhida
    // Os métodos estão no diretório Calculadora.Lib, arquivo AritmeticaVisuais
    try
    {
        switch (operacaoDesejada)
        {
            case ("+"):
                AritmeticaVisuais.AdicaoVisuais();
                break;

            case ("-"):
                AritmeticaVisuais.SubtracaoVisuais();
                break;

            case ("*"):
                AritmeticaVisuais.MultiplicacaoVisuais();
                break;

            case ("/"):
                AritmeticaVisuais.DivisaoVisuais();
                break;

            case ("^"):
                AritmeticaVisuais.ExponenciacaoVisuais();
                break;

            case ("R") or ("r"):
                AritmeticaVisuais.RadiciacaoVisuais();
                break;

            case ("S") or ("s"):
                ExibeSobre();
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
        AritmeticaVisuais.ExibeMensagemDeErro(e.Message);
    }
    finally
    {
        Console.ResetColor();
    }

    // Pausando após a operação para o usuário ver o resultado e limpar o console depois
    Console.Write("\nPressione uma tecla para continuar...");
    Console.ReadKey();
} 
while (operacaoDesejada != "0");

// Não sei onde colocar, então vai aqui
static void ExibeSobre()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nSobre mim:\n");
    Console.ResetColor();

    Console.WriteLine("-Sou Sebastian Devus da Silva, nasci no dia 9 de outubro de 2004.");
    Console.WriteLine("-Fiz esse programa durante a finalização do meu curso de informática na ETEC Adolpho Berezin, localizada em Mongaguá.");
    Console.WriteLine("-Dedico esse programa a meus pais, professores e todos aqueles que me ajudaram no caminho.\n");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Site do programa: https://sebastiandevus.github.io/Calculadora/");
    Console.ResetColor();
}