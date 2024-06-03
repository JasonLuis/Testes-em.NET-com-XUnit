using JornadaMilhasV1.Modelos;

namespace JormadaMilhas.Test
{
    public class OfertaViagemTest
    {
        [Fact]
        public void TestantoOfertaValida()
        {
            //cen�rio - arrange
            Rota rota = new Rota("OrigemTeste", "DestinoTeste");
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 2, 5));

            double preco = 100.0;
            var validacao = true;

            //a��o - act
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //valida��o - assert
            // M�todo do proprio XUnit
            Assert.Equal(validacao, oferta.EhValido);
        }

        [Fact]
        public void TestantoOfertaComRotaNula()
        {
            //cen�rio
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2024, 2, 1), new DateTime(2024, 2, 5));

            double preco = 100.0;

            //a��o
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //valida��o
            // M�todo do proprio XUnit
            Assert.Contains("A oferta de viagem n�o possui rota ou per�odo v�lidos.", oferta.Erros.Sumario);

            Assert.False(oferta.EhValido);
        }

        [Fact]
        public void TestantoOfertaComDataInvalida()
        {
            //cen�rio
            Rota rota = null;
            Periodo periodo = new Periodo(new DateTime(2025, 2, 1), new DateTime(2024, 2, 5));

            double preco = 100.0;

            //a��o
            OfertaViagem oferta = new OfertaViagem(rota, periodo, preco);

            //valida��o
            // M�todo do proprio XUnit
            Assert.Contains("Erro: Data de ida n�o pode ser maior que a data de volta.", periodo.Erros.Sumario);

            Assert.False(oferta.EhValido);
        }
    }
}