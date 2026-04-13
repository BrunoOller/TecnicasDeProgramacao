using System;

public class Estoque
{
    public string Nome { get; set; }
    private int _quantidade;

    public event Action<string, int> EstoqueBaixo;

    public Estoque(string nome, int qtdInicial)
    {
        Nome = nome;
        _quantidade = qtdInicial;
    }

    public void RemoverItens(int qtd)
    {
        _quantidade -= qtd;
        Console.WriteLine($"{qtd} unidades removidas de {Nome}. Restam: {_quantidade}");

        if (_quantidade < 5)
        {
            EstoqueBaixo?.Invoke(Nome, _quantidade);
        }
    }
}

class ProgramEstoque
{
    static void Main()
    {
        Estoque prod = new Estoque("Notebook", 10);

        prod.EstoqueBaixo += (nome, qtd) => {
            Console.WriteLine($"--- ALERTA DE COMPRA: O produto '{nome}' está com apenas {qtd} unidades! ---");
        };

        prod.RemoverItens(3);
        prod.RemoverItens(4);
    }
}