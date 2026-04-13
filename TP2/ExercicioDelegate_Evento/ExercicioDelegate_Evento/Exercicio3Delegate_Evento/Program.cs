using System;

public delegate void CliqueHandler();

public class Botao
{
    public event CliqueHandler Clique;

    public void SimularClique()
    {
        Console.WriteLine("Botão pressionado...");
        Clique?.Invoke();
    }
}

public class ContadorCliques
{
    private int _quantidade = 0;

    public void Incrementar()
    {
        _quantidade++;
        Console.WriteLine($"Total de cliques: {_quantidade}");
    }
}

// No Main:
// var botao = new Botao();
// var contador = new ContadorCliques();
// botao.Clique += contador.Incrementar;
// botao.SimularClique();