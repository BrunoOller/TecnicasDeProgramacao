class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class Cliente
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
}

class Pedido
{
    public int Quantidade { get; set; }
    public DateTime DataPedido { get; set; }
    public Produto Produto { get; set; }
    public Cliente Cliente { get; set; }
}

class Program
{
    static void Main()
    {
        var c1 = new Cliente { Nome = "Ana", Cpf = "123" };
        var c2 = new Cliente { Nome = "João", Cpf = "456" };

        var p1 = new Produto { Nome = "Teclado", Preco = 150.0 };
        var p2 = new Produto { Nome = "Monitor", Preco = 800.0 };

        List<Pedido> pedidos = new List<Pedido>
        {
            new Pedido { Cliente = c1, Produto = p1, Quantidade = 2, DataPedido = DateTime.Now },
            new Pedido { Cliente = c1, Produto = p2, Quantidade = 1, DataPedido = DateTime.Now },
            new Pedido { Cliente = c2, Produto = p1, Quantidade = 1, DataPedido = DateTime.Now }
        };

        var agrupados = pedidos.GroupBy(p => p.Cliente.Nome);
        Console.WriteLine("--- Pedidos Agrupados por Cliente ---");
        foreach (var grupo in agrupados)
        {
            Console.WriteLine($"Cliente: {grupo.Key}");
            foreach (var p in grupo)
            {
                Console.WriteLine($"  - Produto: {p.Produto.Nome} | Qtd: {p.Quantidade}");
            }
        }

        var clientesVip = pedidos
            .Where(p => (p.Quantidade * p.Produto.Preco) > 500)
            .Select(p => p.Cliente.Nome)
            .Distinct();

        Console.WriteLine("\n--- Clientes com Pedidos > R$ 500 ---");
        foreach (var nome in clientesVip)
        {
            Console.WriteLine($"VIP: {nome}");
        }

        var totais = pedidos.GroupBy(p => p.Cliente.Nome)
            .Select(g => new {
                Nome = g.Key,
                Total = g.Sum(p => p.Quantidade * p.Produto.Preco)
            });

        Console.WriteLine("\n--- Total Gasto por Cliente ---");
        foreach (var item in totais)
        {
            Console.WriteLine($"{item.Nome}: R$ {item.Total:F2}");
        }
    }
}