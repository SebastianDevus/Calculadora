namespace Calculadora.Lib;

public class AritmeticaVisuais
{
    public static void AdicaoVisuais()
    {
        double a, b, resultado;
        Console.Clear();
        Console.WriteLine("----- Adição a + b -----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        resultado = Aritmetica.Adicao(a, b);

        Console.WriteLine($"\n{a} mais {b} é igual a {resultado}");
        return;
    }

    public static void SubtracaoVisuais()
    {
        double a, b, resultado;
        Console.Clear();
        Console.WriteLine("----- Subtração a - b -----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        resultado = Aritmetica.Subtracao(a, b);

        Console.WriteLine($"\n{a} menos {b} é igual a {resultado}");
        return;
    }

    public static void MultiplicacaoVisuais()
    {
        double a, b, resultado;
        Console.Clear();
        Console.WriteLine("----- Multiplicação a * b -----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        resultado = Aritmetica.Multiplicacao(a, b);

        Console.WriteLine($"\n{a} vezes {b} é igual a {resultado}");
        return;
    }

    public static void DivisaoVisuais()
    {
        double a, b, resultado;

        Console.Clear();
        Console.WriteLine("----- Divisão a / b -----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Divisao(a, b);

        // Mudando a cor para dar destaque ao resultado
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n{a} dividido por {b} é igual a {resultado}");

        return;
    }

    public static void ExponenciacaoVisuais()
    {
        double a, b, resultado;
        Console.Clear();
        Console.WriteLine("----- Exponenciação a ^ b -----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green; // Mudando a cor para dar destaque ao resultado
        resultado = Aritmetica.Exponenciacao(a, b);

        Console.WriteLine($"\n{a} elevado a {b} é igual a {resultado}");
        return;
    }

    public static void RadiciacaoVisuais()
    {
        double a, b, resultado;
        Console.Clear();
        Console.WriteLine("----- Radiciação raiz b de a -----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green; // Mudando a cor para dar destaque ao resultado
        resultado = Aritmetica.Radiciacao(a, b);

        Console.WriteLine($"\nA raiz {b} de {a} é {resultado}");
        return;
    }
}