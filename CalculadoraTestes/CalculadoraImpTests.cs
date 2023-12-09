using System.Diagnostics;
using Calculadora.Services;

namespace calculadoratestes;

public class CalculadoraImpTests
{
    private CalculadoraImp _calc;
    public CalculadoraImpTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        //Arange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);

    }

    [Fact]
    public void DeveSomar10com10ERetornar20()
    {
        //Arange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);

    }

    [Fact]
    public void DeveVerificarSe4EhParRetornaVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);

    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumeroSãoParesERetornarVerdadeiro(int numero)
    {
        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumeroSãoParesERetornarVerdadeiroLista(int[] numeros)
    {
        //Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}