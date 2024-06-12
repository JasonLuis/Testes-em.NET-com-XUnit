using JornadaMilhasV1.Modelos;

namespace JormadaMilhas.Test
{
    public class OfertaViagemConstrutor
    {
        [Theory]
        [InlineData("", null, "2024-01-01", "2024-01-02", 0, false)]
        [InlineData("OrigemTeste", "DestinoTeste", "2024-02-01", "2024-02-05", 100, true)]
        [InlineData(null, "São Paulo", "2024-01-01", "2024-01-02", -1, false)]
        [InlineData("Vitória", "São Paulo", "2024-01-01", "2024-01-01", 0, false)]
        [InlineData("Rio de Janeiro", "São Paulo", "2024-01-01", "2024-01-02", -500, false)]
        public void RetornaEhValidoDeAcordoComDadosdeEntrada(string origem, string destino, string dataIda, string dataVolta, double preco, bool validacao)
        {
            //cenário - arrange
            Rota rota = new Rota(origem, destino);
            Periodo periodo = new Periodo(DateTime.Parse(dataIda), DateTime.Parse(dataVolta));

            //ação - act
            JornadaMilhasV1.Modelos.OfertaViagem oferta = new JornadaMilhasV1.Modelos.OfertaViagem(rota, periodo, preco);

            //validação - assert
            // Método do proprio XUnit
            Assert.Equal(validacao, oferta.EhValido);
        }

        [Fact]
        public void RetornaMensagemDeErroDeRotaOuPeriodoInvalidosQuandoRotaNula()
        {
            //cenário
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 2, 5));

            double preco = 100.0;

            //ação
            JornadaMilhasV1.Modelos.OfertaViagem oferta = new JornadaMilhasV1.Modelos.OfertaViagem(rota, periodo, preco);

            //validação
            // Método do proprio XUnit
            Assert.Contains("A oferta de viagem não possui rota ou período válidos.", oferta.Erros.Sumario);

            Assert.False(oferta.EhValido);
        }

        [Fact]
        public void RetornaMensagemDeErroQuandoDataIdaForMenorQueDataVolta()
        {
            //cenário
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2025, 2, 1), new DateTime(2024, 2, 5));

            double preco = 100.0;

            //ação
            JornadaMilhasV1.Modelos.OfertaViagem oferta = new JornadaMilhasV1.Modelos.OfertaViagem(rota, periodo, preco);

            //validação
            // Método do proprio XUnit
            Assert.Contains("Erro: Data de ida não pode ser maior que a data de volta.", periodo.Erros.Sumario);

            Assert.False(oferta.EhValido);
        }

        [Fact]
        public void RetornaMensagemDeErroDePrecoInvalidoQuandoPrecoMenorQueZero()
        {
            //arange
            Rota rota = new Rota("Origem1", "Destino1");
            Periodo periodo = new Periodo(new DateTime(2024, 8, 20), new DateTime(2024, 8, 30));
            double preco = -158;

            //act
            JornadaMilhasV1.Modelos.OfertaViagem oferta = new JornadaMilhasV1.Modelos.OfertaViagem(rota, periodo, preco);

            //assert
            Assert.Contains("O preço da oferta de viagem deve ser maior que zero.", oferta.Erros.Sumario);
        }

        [Fact]
        public void RetornaTresErrosDeValidacaoQuandoRotaPeriodoEPrecoSaoInvalidos()
        {
            //arrange
            int quantidadeEsperada = 3;
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 6, 1), new DateTime(2024, 5, 10));
            double preco = -100;

            //act
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //assert
            Assert.Equal(quantidadeEsperada, oferta.Erros.Count());
        }
    }
}