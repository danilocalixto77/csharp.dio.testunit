# Testes Unitário com C#

- Frameworks de teste
  - MSTest
  - NUnit
  - xUnit - É amplamente atualizado e com bastante documentações.
  - Para cada projeto o C# gera um Projeto.csproj (tipo console). Para os testes comumente é criado um ProjetoTests.csproj (tipo xUnit). E para este exemplo pode-se utilizar um Solution .sln. Para agrupar os projetos.

- Criando nosso projeto
  - Cria uma pasta para o projeto.
    - Exemplo: ModuloTesteUnit
  - Criar sub-pastas para o projeto e o projeto teste.
    - Exemplo: Projeto   
    - Exemplo: ProjetoTestes
  - Criar o novo projeto na pasta .\Projeto
    - Exemplo: dotnet new console
  - Criar o novo projeto na pasta .\ProjetoTestes
    - Exemplo: dotnet new xunit
  - Ir para a pasta principal e cria uma Solution.
    - Solution pode ser criada pela extensão:
      - vscode-solution-explorer
      - Identificador fernandoescolar.vscode-solution-explorer
    - Após a criação da solution, adicionar os dois projetos na solution.
  - Uma referência deve ser adicionada no ProjetoTeste para o Projeto. Dizendo entre os projetos que o projeto de teste conhece do projeto.
    - Este procedimento pode ser feito através do ícona da extensão de solution, clicando o botão direito do mouse em cima do ProjetoTeste e selecionando a opção de "Add Reference".
    
- Criando a classe de teste
  - Na criação do projeto xunit por padrão cria uma classe:
    - UnitTest1.cs 
    - A mesma pode ser reutilizada no primeiro momento. Renomei-a para seu uso de acordo com a necessidade.
  - A classe de teste possue uma notação chamada:
    - [Fact]
    - O nome do método deverá sub-entender o que o teste deverá fazer e obter de resultado.
    - Metodologia a utilizar:
      - Arrange: serve para montar o cenário. Exemplo disponibilizar os recursos ou atributos para o teste.
      - Act: É a ação do cenário, executar o cenário proposto.
      - Assert: É a validação se o cenário executado retornou o resultado esperado.

- Implementando o teste unitário.
  - Após desenvolver o código de teste seguindo a metodologia e passos:
    - Arrange -> Act -> Assert
  - Ir para a pasta do ProjetoTeste e executar:
    - dotnet test
    - Apos executar os testes analisar os resultados.
      - Aprovado!  – Com falha:     0, Aprovado:     1, Ignorado:     0, Total:     1, Duração: < 1 ms - calculadoratestes.dll (net7.0)
      - Com falha! – Com falha:     1, Aprovado:     0, Ignorado:     0, Total:     1, Duração: < 1 ms - calculadoratestes.dll (net7.0)
	

  
    
    