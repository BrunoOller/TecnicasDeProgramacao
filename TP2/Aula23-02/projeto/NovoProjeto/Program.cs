// Usando
using OrientacaoObjeto;

Produto prod1 = new Produto();
prod1.Nome = "Caderno";
prod1.Preco = 50.90;

Produto prod2 = new Produto("Lápis", 1.50);

// prod1
Console.WriteLine("Nome: " + prod1.Nome);
Console.WriteLine($"Preço: {prod1.Preco}");

Console.WriteLine();

// prod2
Console.WriteLine("Nome: " + prod2.Nome);
Console.WriteLine($"Preço: {prod2.Preco}");

// Objeto de Produto 2
Produto2 prod3 = new("Borracha", 4.60, 100);
prod3.Exibir(); 

Console.ReadKey();
// Declarando

public class Produto {
    public Produto(){}

    public Produto(string nome, double Preco) {
        Nome = nome;
        this.Preco = Preco;
    }

    public string? Nome { get; set; }
    public double Preco { get; set; }
}