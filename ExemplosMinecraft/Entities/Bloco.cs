namespace ExemplosMinecraft.Entities;

public class Bloco // Classe que representa um bloco
{
    // Atributos (variáveis dentro da classe)
    public string Tipo;
    public int Durabilidade;

    // Construtor é um tipo de método que é chamado quando você instânciar ele, quando você criar um novo Bloco com "new Bloco(tipo, durabilidade)".
    // Define os valores iniciais das propriedades "new Bloco("Pedra", 3)".
    public Bloco(string tipo, int durabilidade)
    {
        Tipo = tipo;
        Durabilidade = durabilidade;
    }
}
