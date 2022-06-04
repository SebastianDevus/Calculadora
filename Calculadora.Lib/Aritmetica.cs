namespace Calculadora.Lib;
public class Aritmetica
{
    public static double Adicao(double parcela1, double parcela2)
    {
        return parcela1 + parcela2;
    }

    public static double Subtracao(double minuendo, double subtraendo)
    {
        return minuendo - subtraendo;
    }

    public static double Multiplicacao(double fator1, double fator2)
    {
        return fator1 * fator2;
    }
    
    public static double Divisao(double dividendo, double divisor)
    {
        if (divisor == 0)
        {
            throw new Exception("Não é possivel dividir por 0");
        }
        else
        {
            return dividendo / divisor;
        }
    }

    public static double Exponenciacao(double numeroBase, double expoente)
    {
        return Math.Pow(numeroBase, expoente);
    }

    public static double Radiciação(double radicando, double indice)
    {
        if (radicando <= 0 && indice % 2 == 0)
        {
            throw new Exception("O radicando deve ser maior do que 0 quando o índice é par");
        }
        else if (indice <= 0)
        {
            throw new Exception("O índice deve ser maior que 0");
        }
        else
        {
            return Math.Pow(radicando, 1.0 / indice);
        }
    }
}
