try
{
    Console.WriteLine("Digite o Dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o Divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());
    var resultado = dividendo / divisor;
    Console.WriteLine($"o resultado de {dividendo} / {divisor} = {resultado}");
}

catch(FormatException)
{
    Console.WriteLine("Entre com um valor inteiro");
}

catch(Exception ex) when (ex.Message.Contains("Format"))
{
    Console.WriteLine("Entre com um valor inteiro");
}

catch(DivideByZeroException)
{
    Console.WriteLine("Entre com um valor inteiro");
}

catch(Exception ex)
{
    Console.WriteLine($"Problema na divisão {ex.Message}");
}

finally
{
    Console.WriteLine("Acabou a divisão");
}