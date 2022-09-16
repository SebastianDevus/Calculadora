using Xunit;
using Calculadora.Lib;

namespace Calculadora.Tests;

public class CalculosDiversosTest
{
    [Theory]
    [InlineData(1, 2, 3, -8)]
    [InlineData(3, 2, 1, -8)]
    [InlineData(2, 2, 2, -12)]
    [InlineData(5, 3, 50, -991)]
    [InlineData(1, 2, -3, 16)]
    public void BhaskaraCalculaDeltaCalculaCorretamente(double a, double b, double c, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, CalculosDiversos.BhaskaraCalculaDelta(a, b, c));
    }

    [Theory]
    [InlineData()]
    [InlineData()]
    [InlineData()]
    [InlineData()]
    [InlineData()]
    public void BhaskaraCalculaRaiz1Corretamente(double a, double b, double delta, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, CalculosDiversos.BhaskaraCalculaRaiz1(a, b, delta));
    }
}