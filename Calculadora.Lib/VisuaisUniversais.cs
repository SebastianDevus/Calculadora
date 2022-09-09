namespace Calculadora.Lib;

// Esse arquivo existe para separar alguns visuais aleatórios
public class VisuaisUniversais
{
    public static void ExibeMensagemDeErro(string mensagemDeErro)
    {
        Console.WriteLine(); // Espaçamento
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagemDeErro);
    }

    public static void ExibeSobre()
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

    public static void Pausa()
    {
        Console.ResetColor();

        // Pausando após a operação para o usuário ver o resultado e limpar o console depois
        Console.Write("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
}