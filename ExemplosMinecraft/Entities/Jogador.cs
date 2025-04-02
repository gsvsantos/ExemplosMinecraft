namespace ExemplosMinecraft.Entities;

public class Jogador // Classe que representa um jogador
{
    // Propriedades: São como "variáveis protegidas" que permitem controlar o acesso aos valores.
    // Encapsulamento: Aqui usamos { get; private set; } para permitir leitura externa, mas alteração apenas dentro da classe.
    public string Nome { get; private set; }
    public int Vida { get; private set; }

    // Construtor é um tipo de método que é chamado quando você instânciar ele, quando você criar um novo Jogador com "new Jogador(nome, vida)".
    // Define os valores iniciais das propriedades "new Jogador("Steve", 100)".
    public Jogador(string nome, int vida)
    {
        Nome = nome;
        Vida = vida;
    }
    
    // Método que reduz um coração da vida do jogador de acordo com a quantidade de golpes dado no bloco.
    public void ReduzirVida(int golpes)
    {
        for (int i = 0; i < golpes; i++)
        {
            Vida -= 2;
        }
    }
}
