class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 12, 8, 20, 3, 15, 7 };

        int maior = numeros.Max();

        int somaMaioresQueDez = numeros.Where(n => n > 10).Sum();

        Console.WriteLine($"Lista: {string.Join(", ", numeros)}");
        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Soma dos maiores que 10: {somaMaioresQueDez}");
    }
}