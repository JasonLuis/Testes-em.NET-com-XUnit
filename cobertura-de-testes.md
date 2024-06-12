
## Executando o Stryker

Após a instalação, precisamos **executar** o *Stryker* para mapear o nosso projeto. Usaremos o seguinte comando para isso:

```console
dotnet Stryker
```

Durante a execução, o terminal exibe algumas informações. O que precisamos localizar nesse momento é o **endereço do arquivo HTML** que o *Stryker* vai gerar para nós, chamado `mutation-report.html`. Vamos copiar todo o endereço e colá-lo no navegador. 

A página que se abre é um **relatório** do *Stryker*. Ele traz uma estrutura de diretórios bem similar à que temos no Visual Studio, no nosso projeto. Como estamos trabalhando com a classe `OfertaViagens`, podemos clicar na pasta "modelos" e acessar o arquivo `OfertaViagem.cs` para entender como funciona o *Stryker*. 

O *Stryker* traz o código que já conhecemos e adiciona nele algumas modificações, que chamamos de "**mutações**" ou "**mutantes**", e executa os testes que já temos para validar se esses testes estão cobrindo essas alterações. 

No topo do código temos alguns marcadores. Vamos desmarcar todos eles antes de tudo. 

O primeiro marcador é o ***Killed***, em verde na tela. Se o marcamos, são adicionadas algumas "bolinhas" verdes ao longo do código. Isso indica que esses mutantes foram adicionados no nosso código e nossos **testes falharam**, ou seja, conseguiram identificar as alterações feitas. No código de `OfertaViagem` temos 19 mutantes eliminados (por isso "*killed*") por meio dos nossos testes.

O segundo marcador é o ***Survived***. Temos um mutante nessa situação, sendo representado pela bolinha vermelha no código. Ela está na linha 25, referente ao cálculo do desconto, verificando se é maior ou igual ao preço. 

Nesse caso, o *Stryker* adicionou uma modificação e o nosso teste **continuou passando** mesmo com a modificação. Esse é um mutante "sobrevivente", o que não é a condição ideal. Algo deve ser alterado nos nossos testes para que esse mutante seja eliminado assim como os outros.

Essa estratégia de adicionar alterações no nosso código para verificar a cobertura dos nossos testes é conhecida como **Teste de mutação**. No próximo vídeo, vamos entender o que precisamos fazer para eliminar esse mutante que continua sobrevivente. 


/*************************************/


Testes de mutação são uma técnica avançada de teste de software que visa avaliar a eficácia dos testes de unidade identificando lacunas na cobertura do código. Os testes de mutação são particularmente úteis para garantir que os testes não apenas verifiquem a implementação atual do código, mas também sejam robustos o suficiente para detectar mudanças semânticas significativas que possam introduzir bugs.

Os testes de mutação seguem o seguinte fluxo ao serem aplicados:

* **Introdução de mutações**: Um processo automatizado é usado para introduzir pequenas alterações no código-fonte, conhecidas como mutações. 

* **Execução dos testes**: Depois que as mutações são introduzidas no código-fonte, os testes de unidade existentes são executados novamente. Se um teste de unidade falhar após a introdução de uma mutação, isso indica que o teste conseguiu detectar a mudança no comportamento do código.

* **Análise dos resultados**: Os resultados dos testes de mutação são analisados para determinar a eficácia dos testes existentes. Se um grande número de mutações não são detectadas pelos testes, isso sugere que há lacunas na cobertura de teste e que os testes podem não ser robustos o suficiente para detectar todas as variações no comportamento do código.

* **Refinamento dos testes**: Com base nos resultados da análise, as pessoas desenvolvedoras podem refinar os testes de unidade existentes ou adicionar novos testes para melhorar a cobertura e garantir que o código seja mais robusto contra alterações.

Os testes de mutação são particularmente úteis em linguagens como C# devido à sua forte tipagem estática e às características do compilador que podem ocultar certos tipos de erros durante a compilação. Ao introduzir mutações no código-fonte e verificar se os testes conseguem detectá-las, as pessoas desenvolvedoras podem aumentar a confiança na qualidade e na robustez do código.

Para saber mais sobre testes de mutação e sobre a biblioteca **Stryker** que utilizamos durante o projeto você pode [acessar o artigo “Testes de mutação com Stryker.NET”](https://balta.io/blog/testes-de-mutacao-stryke-dotnet).