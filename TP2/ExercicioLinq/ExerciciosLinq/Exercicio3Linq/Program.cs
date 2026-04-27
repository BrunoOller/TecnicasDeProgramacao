class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", Idade = 17 },
            new Pessoa { Nome = "Maria", Idade = 22 },
            new Pessoa { Nome = "Carlos", Idade = 30 }
        };

        var adultos = pessoas.Where(p => p.Idade > 18).ToList();

        var nomesOrdenados = pessoas
            .OrderBy(p => p.Nome)
            .Select(p => p.Nome)
            .ToList();

        Console.WriteLine("Maiores de 18 anos:");
        adultos.ForEach(p => Console.WriteLine($"- {p.Nome} ({p.Idade} anos)"));

        Console.WriteLine("\nNomes em ordem alfabética:");
        nomesOrdenados.ForEach(nome => Console.WriteLine($"- {nome}"));
    }
}