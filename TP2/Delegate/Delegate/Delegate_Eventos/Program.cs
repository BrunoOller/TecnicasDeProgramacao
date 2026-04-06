Console.WriteLine("Usando Evento");
Pedido pedido = new Pedido();
pedido.OnCriarPedido += EnviarEmail.email;
pedido.OnCriarPedido += EnviarSMS.sms;

pedido.criarPedido();

Console.WriteLine("Fim do Pedido");

Console.ReadLine();
delegate void PedidoEvent();
class Pedido
{
    public event PedidoEvent? OnCriarPedido;
    public void criarPedido()
    {
        Console.WriteLine("Iniciando o criar pedido");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}
class EnviarEmail
{
    public static void email()
    {
        Console.WriteLine("Email enviado!");
    }
}

class EnviarSMS
{
    public static void sms()
    {
        Console.WriteLine("SMS enviado!");
    }
}
