H� v�rios padr�es de nomenclatura de teste, mas trouxemos apenas dois para analisar como eles funcionam.

Na <a href="https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices" target="_blank">documenta��o da Microsoft</a>, h� uma sugest�o de nomenclatura de teste amplamente utilizada que cont�m, nesta ordem: o **nome do m�todo** testado, o **cen�rio** em que ele est� sendo testado e o **comportamento esperado** quando o cen�rio � invocado. 

Outro padr�o poss�vel (sobre o qual podemos ler mais no <a href="https://ardalis.com/unit-test-naming-convention/" target="_blank">blog Ardalis</a>) � o que traz o nome do m�todo para o nome da classe de teste e, no nome do teste especificamente, teremos o **retorno** esperado e em qual situa��o est� sendo esperado. Esse � o padr�o que vamos aplicar no Jornada Milhas.


Os padr�es de nomenclatura que aplicamos nos testes de unidade s�o essenciais para que possamos garantir aos nossos testes alguns fatores, como:

* Legibilidade: utilizar nomes claros e descritivos facilita a compreens�o do prop�sito de cada teste;
* Manuten��o: padr�es consistentes tornam a manuten��o do c�digo de teste mais f�cil;
* Comunica��o: ter padr�es de nomenclatura ajuda na comunica��o entre os membros da equipe;
* Documenta��o impl�cita: nomes consistentes e descritivos podem servir como documenta��o impl�cita do c�digo de teste;
* Padroniza��o da equipe: aplicar padr�es de nomenclatura promovem consist�ncia dentro da equipe de desenvolvimento.

Existem v�rios tipos de padr�o que s�o utilizados, e a escolha de qual padr�o utilizar vai depender de diversos fatores como complexidade do projeto e decis�o da equipe. O mais importante � sempre manter a consist�ncia dentro do projeto e da equipe que voc� est� trabalhando, garantindo que os testes sejam leg�veis e compreens�veis por todos os membros da equipe.

Para conhecer mais a fundo sobre os dois m�todos de nomenclatura que mencionamos no v�deo anterior voc� pode acessar os artigos abaixo:

* [Documenta��o Microsoft](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices)
* [Artigo sobre conven��es de nomenclatura](https://ardalis.com/mastering-unit-tests-dotnet-best-practices-naming-conventions/)