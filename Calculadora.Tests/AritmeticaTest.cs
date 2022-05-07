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
    public void SomarCalculaCorretamente(double parcela1, double parcela2, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Aritmetica.Soma(parcela1, parcela2));
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
}