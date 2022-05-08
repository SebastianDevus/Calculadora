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
}
