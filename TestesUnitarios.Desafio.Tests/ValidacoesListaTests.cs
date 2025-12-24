using TestesUnitarios.Desafio.Console.Services;
using Xunit;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();
    
    /// <summary>
    /// Ao passar uma lista com diversos números, incluindo positivos e negativos, deve ser retornado uma nova lista apenas com números positivos
    /// </summary>
    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    /// <summary>
    /// Ao passar uma lista com diversos números, incluindo o número 9, deve retornar verdadeiro, pois encontrou o 9 na lista
    /// </summary>
    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    /// <summary>
    /// Ao passar uma lista com diversos números, mas sem o número 10, deve retornar falso, pois não encontrou o 10 na lista
    /// </summary>
    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    /// <summary>
    /// Ao passar uma lista de inteiros, deve retornar uma nova lista, com todos os elementos da lista multiplicados por 2
    /// </summary>
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    /// <summary>
    /// Ao passar uma lista de números inteiros, sendo o maior deles 9, deve retornar o 9 como maior elemento dentro dessa lista
    /// </summary>
    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };


        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        Assert.Equal(9, resultado);
    }

    /// <summary>
    /// Ao passar uma lista de números inteiros, sendo o menor deles -8, deve retornar o -8 como menor elemento dentro dessa lista
    /// </summary>
    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 }; 

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        Assert.Equal(-8, resultado);
    }
}
