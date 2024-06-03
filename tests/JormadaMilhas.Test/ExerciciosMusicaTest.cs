using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JormadaMilhas.Test;

public class ExerciciosMusicaTest
{
    [Fact]
    public void ValidarNomeDaMusica()
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
}
