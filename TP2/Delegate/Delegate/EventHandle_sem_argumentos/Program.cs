Console.WriteLine("Usando Evento");
Pedido pedido = new Pedido();
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;

pedido.criarPedido();

Console.WriteLine("Fim do Pedido");

Console.ReadLine();

class Pedido
{
    public event EventHandler? OnCriarPedido;
    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (OnCriarPedido != null)
        {
            OnCriarPedido(this,EventArgs.Empty);
        }
    }
}
class EnviarEmail
{
    public static void email(Object? sender, EventArgs e)
    {
        Console.WriteLine("Email enviado!");
    }
}

class EnviarSMS
{
    public static void sms(Object? sender, EventArgs e)
    {
        Console.WriteLine("SMS enviado!");
    }
}
