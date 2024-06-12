
## Executando o Stryker

Ap�s a instala��o, precisamos **executar** o *Stryker* para mapear o nosso projeto. Usaremos o seguinte comando para isso:

```console
dotnet Stryker
```

Durante a execu��o, o terminal exibe algumas informa��es. O que precisamos localizar nesse momento � o **endere�o do arquivo HTML** que o *Stryker* vai gerar para n�s, chamado `mutation-report.html`. Vamos copiar todo o endere�o e col�-lo no navegador. 

A p�gina que se abre � um **relat�rio** do *Stryker*. Ele traz uma estrutura de diret�rios bem similar � que temos no Visual Studio, no nosso projeto. Como estamos trabalhando com a classe `OfertaViagens`, podemos clicar na pasta "modelos" e acessar o arquivo `OfertaViagem.cs` para entender como funciona o *Stryker*. 

O *Stryker* traz o c�digo que j� conhecemos e adiciona nele algumas modifica��es, que chamamos de "**muta��es**" ou "**mutantes**", e executa os testes que j� temos para validar se esses testes est�o cobrindo essas altera��es. 

No topo do c�digo temos alguns marcadores. Vamos desmarcar todos eles antes de tudo. 

O primeiro marcador � o ***Killed***, em verde na tela. Se o marcamos, s�o adicionadas algumas "bolinhas" verdes ao longo do c�digo. Isso indica que esses mutantes foram adicionados no nosso c�digo e nossos **testes falharam**, ou seja, conseguiram identificar as altera��es feitas. No c�digo de `OfertaViagem` temos 19 mutantes eliminados (por isso "*killed*") por meio dos nossos testes.

O segundo marcador � o ***Survived***. Temos um mutante nessa situa��o, sendo representado pela bolinha vermelha no c�digo. Ela est� na linha 25, referente ao c�lculo do desconto, verificando se � maior ou igual ao pre�o. 

Nesse caso, o *Stryker* adicionou uma modifica��o e o nosso teste **continuou passando** mesmo com a modifica��o. Esse � um mutante "sobrevivente", o que n�o � a condi��o ideal. Algo deve ser alterado nos nossos testes para que esse mutante seja eliminado assim como os outros.

Essa estrat�gia de adicionar altera��es no nosso c�digo para verificar a cobertura dos nossos testes � conhecida como **Teste de muta��o**. No pr�ximo v�deo, vamos entender o que precisamos fazer para eliminar esse mutante que continua sobrevivente. 


/*************************************/


Testes de muta��o s�o uma t�cnica avan�ada de teste de software que visa avaliar a efic�cia dos testes de unidade identificando lacunas na cobertura do c�digo. Os testes de muta��o s�o particularmente �teis para garantir que os testes n�o apenas verifiquem a implementa��o atual do c�digo, mas tamb�m sejam robustos o suficiente para detectar mudan�as sem�nticas significativas que possam introduzir bugs.

Os testes de muta��o seguem o seguinte fluxo ao serem aplicados:

* **Introdu��o de muta��es**: Um processo automatizado � usado para introduzir pequenas altera��es no c�digo-fonte, conhecidas como muta��es. 

* **Execu��o dos testes**: Depois que as muta��es s�o introduzidas no c�digo-fonte, os testes de unidade existentes s�o executados novamente. Se um teste de unidade falhar ap�s a introdu��o de uma muta��o, isso indica que o teste conseguiu detectar a mudan�a no comportamento do c�digo.

* **An�lise dos resultados**: Os resultados dos testes de muta��o s�o analisados para determinar a efic�cia dos testes existentes. Se um grande n�mero de muta��es n�o s�o detectadas pelos testes, isso sugere que h� lacunas na cobertura de teste e que os testes podem n�o ser robustos o suficiente para detectar todas as varia��es no comportamento do c�digo.

* **Refinamento dos testes**: Com base nos resultados da an�lise, as pessoas desenvolvedoras podem refinar os testes de unidade existentes ou adicionar novos testes para melhorar a cobertura e garantir que o c�digo seja mais robusto contra altera��es.

Os testes de muta��o s�o particularmente �teis em linguagens como C# devido � sua forte tipagem est�tica e �s caracter�sticas do compilador que podem ocultar certos tipos de erros durante a compila��o. Ao introduzir muta��es no c�digo-fonte e verificar se os testes conseguem detect�-las, as pessoas desenvolvedoras podem aumentar a confian�a na qualidade e na robustez do c�digo.

Para saber mais sobre testes de muta��o e sobre a biblioteca **Stryker** que utilizamos durante o projeto voc� pode [acessar o artigo �Testes de muta��o com Stryker.NET�](https://balta.io/blog/testes-de-mutacao-stryke-dotnet).