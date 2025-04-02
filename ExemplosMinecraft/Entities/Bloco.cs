namespace ExemplosMinecraft.Entities;

public class Bloco // Classe que representa um bloco
{
    // Propriedades: são como "variáveis protegidas" que permitem controlar o acesso aos valores.
    // Encapsulamento: Aqui usamos { get; private set; } para permitir leitura externa, mas alteração apenas dentro da classe.
    public string Tipo { get; private set; }
    public int Durabilidade { get; private set; }

    // Construtor é um tipo de método que é chamado quando você instânciar ele, quando você criar um novo Bloco com "new Bloco(tipo, durabilidade)".
    // Define os valores iniciais das propriedades "new Bloco("Pedra", 3)".
    public Bloco(string tipo, int durabilidade)
    {
        Tipo = tipo;
        Durabilidade = durabilidade;
    }

    // Método para reduzir a durabilidade do bloco até chegar a zero(quebrar).
    public void ReduzirDurabilidade()
    {
        if (Durabilidade > 0)
        {
            Durabilidade--;
        }
    }
}
