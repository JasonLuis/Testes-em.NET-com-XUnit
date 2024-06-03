No vídeo anterior conhecemos sobre o **Padrão AAA** que nos auxilia na escrita dos testes, deixando mais organizado e melhorando a utilização. Porém existem outros padrões que também podem ser utilizados como o **Give-When-Then**.

O padrão **Give-When-Then** ajuda a estruturar os testes de maneira bem clara e compreensível seguindo uma abordagem descritiva que informa o comportamento esperado de um sistema em termos de entrada (give), ação (when) e saída (then). Nessas etapas temos:

* **Give**: fase onde é configurado o cenário para o teste;
* **When**: fase onde é executada a ação que se deseja testar;
* **Then**: fase onde é verificado o resultado da ação anterior.

Os dois padrões são bem parecidos, porém possuem algumas diferenças básicas: por exemplo, o padrão **AAA** é mais focado na estruturação do teste em termos de organização do código e na execução do teste em si, destacando a preparação do ambiente de teste, a execução da ação e a verificação do resultado. Já o padrão **Give-When-Then** é mais orientado ao comportamento e coloca mais ênfase na descrição do comportamento do sistema em termos de entradas e saídas.

No final, a decisão sobre qual padrão utilizar vai sempre depender da equipe envolvida no processo e também das particularidades de cada projeto. Para conhecer mais sobre esses padrões seguem duas sugestões de leitura complementar:

* [Artigo Martin Fowler sobre Given When Then](https://martinfowler.com/bliki/GivenWhenThen.html)
* [Artigo sobre AAA](https://xp123.com/3a-arrange-act-assert/)