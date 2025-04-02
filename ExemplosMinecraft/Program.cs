using ExemplosMinecraft.Entities; // "Usa" as classes, os arquivos que estiverem dentro da pasta Entities, quais tem o namespace "ExemplosMinecraft.Entities;".

namespace ExemplosMinecraft;

public class Program
{
    static void Main()
    {
        // Variáveis locais dentro do método Main, permanecem na memória enquanto Main() estiver rodando.
        string nomeJogador = "Steve";
        int vidaJogador = 100;

        // Criando um jogador
        Jogador jogador = new Jogador(nomeJogador, vidaJogador);

        // Criando um bloco do tipo Pedra
        Bloco bloco = new Bloco("Terra", 3);

        Console.WriteLine($"{jogador.Nome} encontrou um bloco de {bloco.Tipo}!\n");

        // Chamando o método para quebrar o bloco
        if (QuebrarBloco(jogador, bloco))
        {
            Console.WriteLine($"\n{jogador.Nome} coletou um bloco de {bloco.Tipo}!");
        }
    }

    static bool QuebrarBloco(Jogador jogador, Bloco bloco) // Método para quebrar um bloco // variável "Jogador jogador" e variável "Bloco bloco" somem após sair do método.
    {
        Console.WriteLine($"{jogador.Nome} começou a quebrar um bloco de {bloco.Tipo}!\n");

        int golpes = 0; // Variável local dentro do método QuebrarBloco, quando sair do método QuebrarBloco() e voltar para Main(), ela deixara de existir.
        while (golpes < bloco.Durabilidade)
        {
            golpes++;
            Console.WriteLine($"Golpe {golpes}");
        }

        Console.WriteLine($"\nBloco de {bloco.Tipo} quebrado!");
        return true; // Quando quebrar o bloco, retorna um valor booleano verdadeiro para o "if (QuebrarBloco(jogador, bloco))".
    }
}
