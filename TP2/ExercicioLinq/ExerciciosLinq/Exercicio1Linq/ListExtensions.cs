namespace Exercicio1Linq
{
    public static class ListExtensions
    {
        public static int SomaImpares(this List<int> lista)
        {
            return lista.Where(n => n % 2 != 0).Sum();
        }
    }
}
