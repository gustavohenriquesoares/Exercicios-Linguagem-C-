using System;
using System.Collections.Generic;

abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double VelocidadeMaxima { get; set; }

    public abstract double CalcularConsumo();

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Velocidade Máxima: {VelocidadeMaxima} km/h");
        Console.WriteLine($"Consumo: {CalcularConsumo()} km/l");
    }
}

class Carro : Veiculo
{
    public override double CalcularConsumo()
    {
        return 12;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("Tipo: Carro");
    }
}

class Moto : Veiculo
{
    public override double CalcularConsumo()
    {
        return 40;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("Tipo: Moto");
    }
}

class Caminhao : Veiculo
{
    public override double CalcularConsumo()
    {
        return 8;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("Tipo: Caminhão");
    }
}

class Program
{
    static void Main()
    {
        var veiculos = new List<Veiculo>
        {
            new Carro { Marca = "Ford", Modelo = "Fusion", VelocidadeMaxima = 200 },
            new Moto { Marca = "Honda", Modelo = "CB500", VelocidadeMaxima = 180 },
            new Caminhao { Marca = "Scania", Modelo = "R500", VelocidadeMaxima = 120 }
        };

        foreach (var veiculo in veiculos)
        {
            veiculo.ExibirInformacoes();
            Console.WriteLine();
        }
    }
}
