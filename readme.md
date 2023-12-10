# Testes Unitário com C#

## Testes Unitário com C#

### Introdução

  Aprender os principais conceitos de testes unitário, seu objetivo e sua importanacia em qualue projeto, indpendente de seu tamanho. Visando aumentar o índice de qualidade

### Introdução testes de software

  Há vários tipos de teste de software: **unitários, integração, regressivo, segurança** e etc... 

  Os testes são fundamentais para garantir a qualidade. Sevindo principalmente para garantir se o que foi desenvolvido está de acordo com o esperado.
  
### Introdução testes unitários

  Teste unitário é um teste normalmente realizado pelo próprio desenvolvedor diretamente no código fonte, visando testar a menor unidade de código possível, através de cenários que podem ocorrer no sistema.

  Em testes unitários é importantes executar em testes positivos e negativos. Com por exemplo o cadatro de um clientes e que possui todos os seus dados válidos e negativos em que falta alguma informção obrigatória ou se alguma informação está inválida.

### Vantagens dos testes

  A maior vantagem é a qualidade, que é um quesito que deve ser inegociável.

  Garante que suas alteração não tenha impactos no sistema.

  Menos bugs.

  Maior confiança de funcionamento do sistema.

  Prevenir problemas futuros.

### Frameworks de teste
  
  **MSTest**: Microsoft Test

  **NUnit**
  
  **xUnit**: É um dos mais utilizados no mercado, contem uma vasta documentação. Mas isso não quer dizer que seja melhor que os outros.

  Para cada projeto o C# gera um **Projeto.csproj** (tipo console). Para os testes comumente é criado um **ProjetoTests.csproj** (tipo xUnit). E para este exemplo pode-se utilizar uma Solution .sln. Para agrupar os projetos.

### Criando nosso projeto

  Cria uma pasta para o projeto. Exemplo: ..**ModuloTesteUnitCSharp** em seguida crie a pasta do Projeto e a pasta para o ProjetoTeste. Antes de executar qualquer um dos comandos para criação so projetos, certifique-se de estar dentro da pasta/sub-pasta criada para cada projeto.

  Criar sub-pastas para o projeto:

  ```
  dotnet new console
  ```
  
  Criar sub-pastas para o projeto teste:.

  ```
  dotnet new xunit
  ```
  Ir para a pasta principal os projetos e criar uma Solution.

  **Solution** pode ser criada pela extensão:
  
  ```
  vscode-solution-explorer
  Identificador fernandoescolar.vscode-solution-explorer
  ```
  Após a criação da solution, adicionar os dois projetos na solution.
  
  Uma referência deve ser adicionada no ProjetoTeste para o Projeto. Dizendo entre os projetos que o projeto de teste conhece do projeto.
  
  Este procedimento pode ser feito através do ícona da extensão de solution, clicando o botão direito do mouse em cima do ProjetoTeste e selecionando a opção de "Add Reference".

### Implementando a classe calculadora

  Crie uma **pasta** chamada **Services** dentro da pasta do projeto console, e logo em seguida a classe desejada.

  ```
  ..\Calculadora
  ```

  ```
  ..\Calculadora\Services\CalculadoraImp.cs
  ```

  Crie um método simples pa efetuar a soma entre duas variáveis.

  ```
  public class CalculadoraImp
  {
      public int Somar(int num1, int num2)
      {
          return num1 + num2;
      }
  }
  ```

  No Program.cs execute o instacie e chame o método

  ```
  CalculadoraImp c = new CalculadoraImp();

  int num1 = 5;
  int num2 = 10;

  System.Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");
  ```

### Criando a classe de teste

  Agora iremos para o projeto de teste.

  ```
  ..\CalculadoraTestes
  ```

  Na criação do projeto xunit por padrão foi criado uma  classe: **UnitTest1.cs**, essa mesma classe nos iremos reutilizar. Renomei-a para seu uso de acordo com a necessidade. Para o nosso cenário pasará a chamar: **CalculadoraTests.cs**.  E para casa classe que existir no projeto de principal, devemos ter pelo menos uma classe de teste equivalente a ela.

  Podemos observar que o que temos é uma classe, e dentro dessa classe temos métodos que possuem uma chamada: **[Fact]**

  ```
  [Fact]
  public void DeveSomar5com10ERetornar15()
  {
      //Arange
      int num1 = 5;
      int num2 = 10;

      //Act
      int resultado = _calc.Somar(num1, num2);

      //Assert
      Assert.Equal(15, resultado);
  }
  ```

  O nome do método deverá sub-entender o que o teste deverá fazer e obter de resultado.
  
  Metodologia a utilizar:
  
  **Arrange**: serve para montar o cenário. Exemplo disponibilizar os recursos ou atributos para o teste.

  **Act**: É a ação do cenário, executar o cenário proposto.

  **Assert**: É a validação se o cenário executado retornou o resultado esperado.

  Para desenvolvermos o método devemos instanciar a classe onde ele está:

  ```
  using Calculadora.Services;
  ```

  Posteriormente criar um construtor:

  ```
  private CalculadoraImp _calc;
  public CalculadoraImpTests()
  {
      _calc = new CalculadoraImp();
  }
  ```

  E agora no método de teste apliar a metodologia com: Arrange, Act, Assert.

  ```
  [Fact]
  public void DeveSomar5com10ERetornar15()
  {
      //Arange
      
      //Act

      //Assert
  }
  ```

### Implementando o teste unitário

  No Arrange determinamos o que iremos passar para o método, para o nosso exemplo que está testando o método Somar será então:

  ```
  //Arange
  int num1 = 5;
  int num2 = 10;
  ```

  No Act será a ação o agir a chamada para executar o método a ser testado:

  ```
  //Act
  int resultado = _calc.Somar(num1, num2);
  ```

  No Assert será a validação se o retorno do método é o esperado:
  ```
  //Assert
  Assert.Equal(15, resultado);
  ```

  Método completo, e lembrando que o que identifica como um método de teste é o **[Fact]**:

  ```
  [Fact]
  public void DeveSomar5com10ERetornar15()
  {
      //Arange
      int num1 = 5;
      int num2 = 10;

      //Act
      int resultado = _calc.Somar(num1, num2);

      //Assert
      Assert.Equal(15, resultado);
  }
  ```

  Dentro da pasta: **CalculadoraTestes**, execute o comando abaixo:

  ```
  dotnet test
  ```

  **Positivo**:

  Aprovado!  – Com falha:     0, Aprovado:     1, Ignorado:     0, Total:     1, Duração: < 1 ms - calculadoratestes.dll (net7.0)
    - Outro resultado possível: 
  
  **Negativo**:

  Com falha! – Com falha:     1, Aprovado:     0, Ignorado:     0, Total:     1, Duração: < 1 ms - calculadoratestes.dll (net7.0)


### Validando o teste

### Implementando validações de string

### Verificando se um número é par

### Utilizando o Theory

### Refatorando o método de teste

### Finalização

## Materiais de apoio e Questionário

### Materiais de apoio

### Certifique seu conhecimento




    


	

  
    
    