using Bogus;
using Bogus.DataSets;
using JornadaMilhasV1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace JormadaMilhas.Test;

public class ExerciciosMusicaConstrutor
{
    [Fact]
    public void ValidaNomeCorretamenteDaMusica()
    {
        string nomeMusica = "Teste";

        Musica musica = new Musica(nomeMusica);


        Assert.Equal(nomeMusica, musica.Nome);
    }

    [Fact]
    public void ValidarInicializacaoIdMusica()
    {
        string nomeMusica = "Teste";
        int id = 1;

        Musica musica = new Musica(nomeMusica) { Id = id };

        Assert.Equal(id, musica.Id);
    }

    [Fact]
    public void ValidarToString()
    {
        string nomeMusica = "Teste";
        int id = 1;

        Musica musica = new Musica(nomeMusica) { Id = id };

        string toString = @$"Id: {id} Nome: {nomeMusica}";

        Assert.Equal(toString, musica.ToString());
    }

    //1 - Uma possível implementação de nomenclatura para os testes seria:

    //  InicializaNomeCorretamenteQuandoCastradaNovaMusica
    //  ExibeDadosDaMusicaCorretamenteQuandoChamadoMetodoExibeFichaTecnica
    //  ExibeDadosDaMusicaCorretamenteQuandoChamadoMetodoToString

    [Theory]
    [InlineData("Música Teste")]
    [InlineData("Outra Música")]
    [InlineData("Mais uma Música")]
    public void InicializaNomeCorretamenteQuandoCastradaNovaMusicaTheory(string nome)
    {
        // Act
        Musica musica = new Musica(nome);

        // Assert
        Assert.Equal(nome, musica.Nome);
    }

    [Theory]
    [InlineData("Música Teste", "Nome: Música Teste")]
    [InlineData("Outra Música", "Nome: Outra Música")]
    [InlineData("Mais uma Música", "Nome: Mais uma Música")]
    public void ExibeDadosDaMusicaCorretamenteQuandoChamadoMetodoExibeFichaTecnica
        (string nome, string saidaEsperada)
    {
        // Arrange
        Musica musica = new Musica(nome);
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        musica.ExibirFichaTecnica();
        string saidaAtual = stringWriter.ToString().Trim();

        // Assert
        Assert.Equal(saidaEsperada, saidaAtual);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(0)]
    public void RetornaDataDeLancamentoNulaQuandoForZeroOuNegativo(int anoInvalido)
    {
        // Arrange
        Musica musica = new Musica("Nome");

        // Act
        musica.AnoLancamento = anoInvalido;

        // Assert
        Assert.Null(musica.AnoLancamento);
    }

    [Fact]
    public void RetornaArtistaDesconhecidoQuandoValorInseridoEhNulo()
    {
        // Arrange
        Musica musica = new Musica("Nome");

        // Act
        musica.Artista = null;

        // Assert
        Assert.Equal("Artista desconhecido", musica.Artista);
    }

    [Fact]
    public void RetornaToStringCorretamenteQuandoCadastrarUmaMusicaCCorretamente()
    {
        
        var faker = new Faker();
        var id = faker.Random.Int();
        var nome = faker.Music.Genre();
        var saidaEsperada = $"Id: {id} Nome: {nome}";
        var musica = new Musica(nome) { Id = id };

        // Act
        var result = musica.ToString();


        // Assert
        Assert.Equal(saidaEsperada, result);
    }

    [Fact]
    public void RetornaArtistaDesconhecidoQuandoInseridoDadoNuloEmArtista()
    {
        // Arrange
        var nome = new Faker().Music.Genre();
        var musica = new Musica(nome)
        {
            Artista = null
        };

        // Act
        var artista = musica.Artista;

        // Assert
        Assert.Equal("Artista desconhecido", artista);
    }

    [Fact]
    public void RetornoAnoDeLancamentoNuloQuandoValorInseridoMenorQueZero()
    {
        // Arrange
        var nome = new Faker().Music.Genre();
        var musica = new Musica(nome)
        {
            AnoLancamento = -1
        };

        // Act
        var anoDelancamento = musica.AnoLancamento;

        // Assert
        Assert.Null(anoDelancamento);
    }
}