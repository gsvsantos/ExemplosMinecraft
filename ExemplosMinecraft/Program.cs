using ExemplosMinecraft.Entities; // "Usa" as classes, os arquivos que estiverem dentro da pasta Entities, quais tem o namespace "ExemplosMinecraft.Entities;".

namespace ExemplosMinecraft;

public class Program
{
    static void Main()
    {
        // Variáveis locais dentro do método Main, permanecem na memória enquanto Main() estiver rodando.
        string nomeJogador = "Steve";
        int vidaJogador = 20;

        // Criando uma instância do jogador, com nome e vida inicial declarados nas variáveis locais anteriores.
        Jogador jogador = new Jogador(nomeJogador, vidaJogador);

        // Criando um bloco do tipo "Pedra" com 3 de durabilidade.
        Bloco bloco = new Bloco("Pedra", 3);

        Console.WriteLine($"{jogador.Nome} encontrou um bloco de {bloco.Tipo}!\n");

        // Chamando o método para quebrar o bloco, quando quebrar, coleta o bloco.
        if (QuebrarBloco(jogador, bloco))
        {
            Console.WriteLine($"\n{jogador.Nome} coletou um bloco de {bloco.Tipo}!");
            Console.WriteLine($"\nCorações restantes: {jogador.Vida}");
        }
    }

    static bool QuebrarBloco(Jogador jogador, Bloco bloco) // Método para quebrar um bloco // variável "Jogador jogador" e variável "Bloco bloco" somem após sair do método.
    {
        Console.WriteLine($"{jogador.Nome} começou a quebrar um bloco de {bloco.Tipo}!\n");

        int golpes = 0; // Variável local dentro do método QuebrarBloco, quando sair do método QuebrarBloco() e voltar para Main(), ela deixara de existir.
        while (bloco.Durabilidade > 0)
        {
            golpes++;
            bloco.ReduzirDurabilidade(); // Método do bloco para reduzir a durabilidade a cada golpe dado.
            Console.WriteLine($"Golpe {golpes}");
        }

        jogador.ReduzirVida(golpes);

        Console.WriteLine($"\nBloco de {bloco.Tipo} quebrado!");
        return true; // Quando quebrar o bloco, retorna um valor booleano verdadeiro para o "if (QuebrarBloco(jogador, bloco))".
    }
}