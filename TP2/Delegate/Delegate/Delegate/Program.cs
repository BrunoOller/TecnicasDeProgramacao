// Segunda Etapa
MeuDelegate del1 = new MeuDelegate(MeuMetodo);
MeuDelegate del2 = MeuMetodo;
MeuDelegate del3 = (msg) => Console.WriteLine(msg);

// Terceira Etapa
del1.Invoke("Minha mensagem 1");
del2("Minha mensagem 2");
del3("Minha mensagem 3");

static void MeuMetodo(string mensagem)
{
    Console.WriteLine(mensagem);
}
Console.ReadKey();

// Primeira Etapa
public delegate void MeuDelegate(string msg);