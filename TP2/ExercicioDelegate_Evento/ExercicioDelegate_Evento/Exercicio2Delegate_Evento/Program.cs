using System;

public delegate void AlarmeHandler(string mensagem);

public class ArCondicionado
{
    public double LimiteSuperior { get; set; } = 30.0;
    public double LimiteInferior { get; set; } = 15.0;
    private double _temperatura;

    public event AlarmeHandler AlarmeTemperatura;

    public void AjustarTemperatura(double novaTemp)
    {
        _temperatura = novaTemp;
        Console.WriteLine($"Temperatura atual: {_temperatura}°C");

        if (_temperatura > LimiteSuperior)
            AlarmeTemperatura?.Invoke($"ALERTA: Temperatura muito alta! ({_temperatura}°C)");
        else if (_temperatura < LimiteInferior)
            AlarmeTemperatura?.Invoke($"ALERTA: Temperatura muito baixa! ({_temperatura}°C)");
    }
}

public class Monitor
{
    public void OnAlarmeDisparado(string msg) => Console.WriteLine(msg);
}

// No Main:
// var ar = new ArCondicionado();
// var monitor = new Monitor();
// ar.AlarmeTemperatura += monitor.OnAlarmeDisparado;
// ar.AjustarTemperatura(35);