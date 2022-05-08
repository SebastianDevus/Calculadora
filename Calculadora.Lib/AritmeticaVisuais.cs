namespace Calculadora.Lib;

public class AritmeticaVisuais
{
    public static void AdicaoVisuais()
    {
        double a, b, resultado;
        Console.Clear();
        Console.WriteLine("-----Adição a + b-----\n");

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
        Console.WriteLine("-----Subtração a - b-----\n");

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
        Console.WriteLine("-----Multiplicação a * b-----\n");

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
        Console.WriteLine("-----Subtração a - b-----\n");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNão é possível dividir por 0!");
        }
        else
        {
            resultado = Aritmetica.Divisao(a, b);

            // Mudando a cor para dar destaque ao resultado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{a} dividido por {b} é igual a {resultado}");
        }

        return;
    }
}