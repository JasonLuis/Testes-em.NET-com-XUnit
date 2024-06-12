Há vários padrões de nomenclatura de teste, mas trouxemos apenas dois para analisar como eles funcionam.

Na <a href="https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices" target="_blank">documentação da Microsoft</a>, há uma sugestão de nomenclatura de teste amplamente utilizada que contém, nesta ordem: o **nome do método** testado, o **cenário** em que ele está sendo testado e o **comportamento esperado** quando o cenário é invocado. 

Outro padrão possível (sobre o qual podemos ler mais no <a href="https://ardalis.com/unit-test-naming-convention/" target="_blank">blog Ardalis</a>) é o que traz o nome do método para o nome da classe de teste e, no nome do teste especificamente, teremos o **retorno** esperado e em qual situação está sendo esperado. Esse é o padrão que vamos aplicar no Jornada Milhas.


Os padrões de nomenclatura que aplicamos nos testes de unidade são essenciais para que possamos garantir aos nossos testes alguns fatores, como:

* Legibilidade: utilizar nomes claros e descritivos facilita a compreensão do propósito de cada teste;
* Manutenção: padrões consistentes tornam a manutenção do código de teste mais fácil;
* Comunicação: ter padrões de nomenclatura ajuda na comunicação entre os membros da equipe;
* Documentação implícita: nomes consistentes e descritivos podem servir como documentação implícita do código de teste;
* Padronização da equipe: aplicar padrões de nomenclatura promovem consistência dentro da equipe de desenvolvimento.

Existem vários tipos de padrão que são utilizados, e a escolha de qual padrão utilizar vai depender de diversos fatores como complexidade do projeto e decisão da equipe. O mais importante é sempre manter a consistência dentro do projeto e da equipe que você está trabalhando, garantindo que os testes sejam legíveis e compreensíveis por todos os membros da equipe.

Para conhecer mais a fundo sobre os dois métodos de nomenclatura que mencionamos no vídeo anterior você pode acessar os artigos abaixo:

* [Documentação Microsoft](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices)
* [Artigo sobre convenções de nomenclatura](https://ardalis.com/mastering-unit-tests-dotnet-best-practices-naming-conventions/)