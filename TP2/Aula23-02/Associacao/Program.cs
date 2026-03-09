Fornecedor fornecedor1 = new Fornecedor("Empresa1", "1111111");
Produto produto1 = new Produto("Produto1", 10.20);
Categoria categoria1 = new Categoria("Categoria1");

//Associação bilateral produto->fornecedor
produto1.Fornecedores.Add(fornecedor1);

//Agregação Unilateral Produto->Categoria
produto1.CategoriaProduto = categoria1;

//Associação bilateral fornecedor->produto
Fornecedor fornecedor2 = new Fornecedor("Empresa2", "22222222");
Produto produto2 = new Produto("Produto2", 10.30);
Produto produto3 = new Produto("Produto3", 100);

fornecedor2.Produtos.Add(produto2);
fornecedor2.Produtos.Add(produto3);

Console.WriteLine($"Nome: {produto1.Nome}\n Preço: {produto1.Preco}\n Categoria: {produto1.CategoriaProduto.Descritivo}");
foreach(var dado  in produto1.Fornecedores)
{
    Console.WriteLine($"Razão Social: {dado.RazaoSocial}\n CNPJ: {dado.Cnpj}");
}

Console.WriteLine("Outro lado do Bilateral");
Console.WriteLine($"Razão Social: {fornecedor2.RazaoSocial}\n CNPJ: {fornecedor2.Cnpj}");
foreach(var dado in fornecedor2.Produtos)
{
    Console.WriteLine($"Nome: {dado.Nome} - Preço: {dado.Preco}");
}

public class Produto
{
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public string? Nome { get; set; };
    public double Preco { get; set; };
    public Categoria CategoriaProduto { get; set; }
    public List<Fornecedor> Fornecedores = new List<Fornecedor>();
}

public class Categoria
{
    public Categoria(string descritivo)
    {
        Descritivo = descritivo;
    }
    public string? Descritivo { get; set; }
}

public class Fornecedor
{
    public Fornecedor(string razaoSocial, string cnpj)
    {
        RazaoSocial = razaoSocial;
        Cnpj = cnpj;
    }
    public string? RazaoSocial { get; set; }
    public string? Cnpj { get; set; }
    public List<Produto> Produtos = new List<Produto>();
}