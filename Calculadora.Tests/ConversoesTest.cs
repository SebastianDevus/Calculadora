using Xunit;
using Calculadora.Lib;

namespace Calculadora.Tests;

public class ConversoesTest
{
    [Theory]
    [InlineData(1.609, 1)]
    [InlineData(8, 4.972)]
    [InlineData(2, 1.243)]
    [InlineData(4, 2.486)]
    [InlineData(2.5, 1.554)]
    [InlineData(10, 6.215)]
    [InlineData(1609, 1000)]
    [InlineData(0, 0)]
    [InlineData(-10, -6.215)]
    [InlineData(5, 3.108)]
    public void KmParaMilhasCalculaCorretamente(double distanciaKm, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Conversoes.KmParaMilhas(distanciaKm));
    }

    [Theory]
    [InlineData(1, 1.609)]
    [InlineData(4.972, 8)]
    [InlineData(1.243, 2)]
    [InlineData(2.486, 4)]
    [InlineData(1.554, 2.5)]
    [InlineData(6.215, 10)]
    [InlineData(1000, 1609)]
    [InlineData(0, 0)]
    [InlineData(-6.215, -10)]
    [InlineData(3.108, 5.001)]
    public void MilhasParaKmCalculaCorretamente(double distanciaMilhas, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Conversoes.MilhaParaKm(distanciaMilhas));
    }
}