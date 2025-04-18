# Exemplos de Programação com C# e Minecraft

## Objetivo
Este projeto tem o objetivo de ensinar conceitos fundamentais de programação utilizando C# de forma prática e didática, com exemplos inspirados no jogo Minecraft.

## Conceitos Abordados
O código demonstra os seguintes conceitos de programação:
- **Variáveis**
- **Atributos**
- **Classes**
- **Parâmetros**
- **Funções e Métodos**

#### Branch com Encapsulamento e Propriedades: [v2](https://github.com/gsvsantos/ExemplosMinecraft/tree/v2)

## Como Executar o Código

1. **Instale o Visual Studio** com suporte para C#.

2. **Clone o repositório** ou copie os arquivos para uma pasta local.

3. **Abra o projeto no Visual Studio.**

4. **Compile e execute o programa (F5 ou Ctrl + F5)** para ver a saída no console.

5. **Use breakpoints** para analisar o fluxo do código e entender melhor cada parte dele.

6. **Modifique valores** (como nome do jogador, vida, tipo de bloco e durabilidade) e veja como afetam a execução.

## Estrutura do código

### `Program.cs`
Arquivo principal, contém o necessário para inicializar e executar o programa.
- Define **variáveis locais** (`nomeJogador`, `vidaJogador`).
- Instancia objetos da classe **`Jogador`** e **`Bloco`**.
- Chama o método **`QuebrarBloco()`**.

### `Bloco.cs`
Classe que representa um bloco no jogo.
- Possui **atributos públicos** (`Tipo`, `Durabilidade`).
- Define um **construtor** para inicializar os valores.

### `Jogador.cs`
Classe que representa um jogador.
- Utiliza **atributos públicos** (`Nome`, `Vida`).
- Define um **construtor** para inicializar os valores.

### `QuebrarBloco()`
Método que simula a ação da quebra de um bloco.
- Trabalha com **parâmetros** (`Jogador jogador, Bloco bloco`).
- Contém um uso prático de **`while`**.
- Define **variável local** (`golpes`).
- Resulta em um **retorno booleano**.

## Saída Esperada
```
Steve encontrou um bloco de Terra!

Steve começou a quebrar um bloco de Terra!

Golpe 1
Golpe 2
Golpe 3

Bloco de Terra quebrado!

Steve coletou um bloco de Terra!
```

## Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
  
## Tecnologias
[![Tecnologias](https://skillicons.dev/icons?i=git,github,visualstudio,cs,dotnet)](https://skillicons.dev)


## Como Usar o Projeto
Para um aprendizado mais prático:
- **Abra o código no Visual Studio e adicione breakpoints** para acompanhar a execução passo a passo.
- **Altere valores** no código, como nome do jogador, vida, tipo de bloco e durabilidade, e veja como isso impacta o programa.
- **Experimente adicionar novos blocos** ou jogadores e testar diferentes cenários.

## Considerações Finais
Este projeto é uma forma interativa e divertida de aprender C# utilizando a temática do Minecraft.

# Sobre o Projeto
Este é um projeto  da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).


