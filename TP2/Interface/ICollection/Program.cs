// ICollection herda de IEnumerable e permite alteração na coleção
ICollection<string> nomes = new List<string> { "Selma", "Paulo" };
nomes.Add("Maria");
string[] array = new string[nomes.Count];
nomes.CopyTo(array, 0);

ExibirNomes(nomes);
Console.WriteLine();
ExibirNomes(array);

void ExibirNomes(ICollection<string> colecao)
{
    foreach (var nome in colecao)
    {
        Console.WriteLine(nome);
    }
}
