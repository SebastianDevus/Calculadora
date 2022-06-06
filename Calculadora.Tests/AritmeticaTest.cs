using Xunit;
using Calculadora.Lib;

namespace Calculadora.Tests;

public class AritmeticaTest
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 3, 1)]
    [InlineData(2, -3, -1)]
    [InlineData(2.5, 3, 5.5)]
    [InlineData(-2, 3.5, 1.5)]
    [InlineData(2.5, -3, -0.5)]
    [InlineData(0, 3, 3)]
    [InlineData(-2, 0, -2)]
    [InlineData(0, 0, 0)]
    public void AdicaoCalculaCorretamente(double parcela1, double parcela2, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Adicao(parcela1, parcela2));
    }

    [Theory]
    [InlineData(2, 2, 0)]
    [InlineData(2, 3, -1)]
    [InlineData(-2, 3, -5)]
    [InlineData(2, -3, 5)]
    [InlineData(2.5, 3, -0.5)]
    [InlineData(-2, 3.5, -5.5)]
    [InlineData(2.5, -3, 5.5)]
    [InlineData(0, 3, -3)]
    [InlineData(-2, 0, -2)]
    [InlineData(0, 0, 0)]
    public void SubtrairCalculaCorretamente(double minuendo, double subtraendo, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Subtracao(minuendo, subtraendo));
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(2, -3, -6)]
    [InlineData(2.5, 3, 7.5)]
    [InlineData(-2, 3.5, -7)]
    [InlineData(2.5, -3, -7.5)]
    [InlineData(0, 3, 0)]
    [InlineData(-2, 0, 0)]
    [InlineData(0, 0, 0)]
    public void MultiplicarCalculaCorretamente(double fator1, double fator2, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Multiplicacao(fator1, fator2));
    }


    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(2, 4, 0.5)]
    [InlineData(-2, 4, -0.5)]
    [InlineData(2, -4, -0.5)]
    [InlineData(-3, -2, 1.5)]
    [InlineData(3, -2, -1.5)]
    [InlineData(2.5, 2.5, 1)]
    [InlineData(2.5, 25, 0.1)]
    [InlineData(25, 2.5, 10)]
    [InlineData(250, 2, 125)]
    public void DividirCalculaCorretamente(double dividendo, double divisor, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Divisao(dividendo, divisor));
    }


    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 2, 9)]
    [InlineData(2, -1, 0.5)]
    [InlineData(-2, 2, 4)]
    [InlineData(10, 2, 100)]
    [InlineData(4, 0.5, 2)]
    [InlineData(16, 0.5, 4)]
    [InlineData(1, 1, 1)]
    [InlineData(10, 0, 1)]
    [InlineData(1, 100, 1)]
    public void ExponenciacaoCalculaCorretamente(double numeroBase, double expoente, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Exponenciacao(numeroBase, expoente));
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(16, 2, 4)]
    [InlineData(8, 3, 2)]
    [InlineData(9, 2, 3)]
    [InlineData(100, 2, 10)]
    [InlineData(16, 4, 2)]
    [InlineData(400, 2, 20)]
    [InlineData(1, 2, 1)]
    [InlineData(0, 3, 0)]
    [InlineData(32, 5, 2)]
    public void RadiciacaoCalculaCorretamente(double radicando, double indice, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Radiciacao(radicando, indice));
    }
}