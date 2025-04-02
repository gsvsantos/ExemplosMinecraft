namespace ExemplosMinecraft.Entities;

public class Jogador // Classe que representa um jogador
{
    // Atributos (variáveis dentro da classe)
    public string Nome;
    public int Vida;

    // Construtor é um tipo de método que é chamado quando você instânciar ele, quando você criar um novo Jogador com "new Jogador(nome, vida)".
    // Define os valores iniciais das propriedades "new Jogador("Steve", 100)".
    public Jogador(string nome, int vida)
    {
        Nome = nome;
        Vida = vida;
    }
}
