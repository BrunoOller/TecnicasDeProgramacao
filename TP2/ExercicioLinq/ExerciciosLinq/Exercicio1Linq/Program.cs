using Exercicio1Linq;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 12, 8, 20, 3, 15, 7 };

        int resultado = numeros.SomaImpares();

        Console.WriteLine("A soma dos números ímpares é: " + resultado);
    }
}