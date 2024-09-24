# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar conta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 |
| Objetivo do Teste 	| Verificar se a criação de conta está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Cadastre-se" <br> - Preencher os campos obrigatórios (nome, e-mail, senha e confirme a senha) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Editar perfil** 	|
|	Requisito Associado 	| RF-02 |
| Objetivo do Teste 	| Verificar se a edição do perfil do usuário está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Perfil" <br> - Clicar em "Editar perfil" <br> - Editar campos desejados <br> - Clicar em "Salvar" |
|Critério de Êxito | - A edição foi realizada com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Fazer login** 	|
|	Requisito Associado 	| RF-03 |
| Objetivo do Teste 	| Verificar se o login do usuário está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Perfil" <br> - Clicar em "Entre" <br> - Preencher campos obrigatórios <br> - Clicar em "Entrar" |
|Critério de Êxito | - A login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Cadastro de alimentos** 	|
|	Requisito Associado 	| RF-04 |
| Objetivo do Teste 	| Verificar se o cadastros de alimentos a despensa virtual está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Despensa" <br> - Clicar em "Cadastrar Alimento" <br> - Preencher campos obrigatórios (alimento, quantidade, data de compra, data de validade e categoria) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro do alimento foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Listagem de alimentos** 	|
|	Requisito Associado 	| RF-05 |
| Objetivo do Teste 	| Verificar se a listagem de alimentos da despensa virtual está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Despensa" <br> |
|Critério de Êxito | - Lista os alimentos da despensa virtual da forma adequada. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Exclusão de alimentos** 	|
|	Requisito Associado 	| RF-06 |
| Objetivo do Teste 	| Verificar se a exclusão dos alimentos da despensa virtual está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Despensa" <br> - Clicar em "Excluir" no alimento escolhido <br> |
|Critério de Êxito | - A exclusão do alimento da despensa virtual foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Recuperar senha** 	|
|	Requisito Associado 	| RF-08 |
| Objetivo do Teste 	| Verificar se a recuperação da senha está acontecendo da forma esperada. |
| Passos 	| - Clicar em "Recuperar senha" <br> |
|Critério de Êxito | - O usuário consegue recuperar a senha de forma adequada de forma adequada. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Exibir alimentos próximos ao vencimento** 	|
|	Requisito Associado 	| RF-08 |
| Objetivo do Teste 	| Verificar se a exibição dos alimentos próximos a data de vencimento está correta. |
| Passos 	| - Clicar em "Despensa" <br> |
|Critério de Êxito | - Exibe os alimentos próximos a data de vencimento da despensa virtual de forma adequada. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 – Enviar dúvidas ao suporte** 	|
|	Requisito Associado 	| RF-09 |
| Objetivo do Teste 	| Verificar se o envio de dúvidas ao suporte acontece da forma esperada. |
| Passos 	| - Clicar em "Suporte" <br> - Preencher campos obrigatórios <br> - Criar em "Enviar" <br> |
|Critério de Êxito | - O envio de dúvidas ao suporte foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 – Acessar area sobre nós** 	|
|	Requisito Associado 	| RF-10 |
| Objetivo do Teste 	| Verificar se a exibição de informações do projeto está correta. |
| Passos 	| - Clicar em "Sobre Nós" <br> |
|Critério de Êxito | - Exibe as informações do projeto de forma adequada. |
|  	|  	|
 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
