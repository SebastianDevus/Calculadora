using Xunit;
using Calculadora.Lib;

namespace Calculadora.Tests;

public class ConversoesTest
{
    // ================================================================================================================
    // ================================================== DISTÂNCIAS ==================================================
    // ================================================================================================================
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
    

    // ================================================================================================================
    // ================================================= TEMPERATURAS =================================================
    // ================================================================================================================
    [Theory]
    [InlineData(0, 273.15)]
    [InlineData(-273.15, 0)]
    [InlineData(100, 373.15)]
    [InlineData(30.15, 303.30)]
    [InlineData(-273, 0.15)]
    public void CelsiusParaKelvinCalculaCorretamente(double temperaturaCelsius, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Conversoes.CelsiusParaKelvin(temperaturaCelsius));
    }

    [Theory]
    [InlineData(273.15, 0)]
    [InlineData(0, -273.15)]
    [InlineData(373.15, 100)]
    [InlineData(303.30, 30.15)]
    [InlineData(0.15, -273)]
    public void KelvinParaCelsiusCalculaCorretamente(double temperaturaKelvin, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Conversoes.KelvinParaCelsius(temperaturaKelvin));
    }

    [Theory]
    [InlineData(0, -17.78)]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    [InlineData(86.5, 30.28)]
    [InlineData(-4, -20)]
    public void FahrenheitParaCelsiusCalculaCorretamente(double temperaturaFah, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Conversoes.FahrenheitParaCelsius(temperaturaFah));
    }

    [Theory]
    [InlineData(-17.78, 0)]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(30.28, 86.5)]
    [InlineData(-20, -4)]
    public void CelsiusParaFahrenheitCalculaCorretamente(double temperaturaCelsius, double resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, Conversoes.CelsiusParaFahrenheit(temperaturaCelsius));
    }

}