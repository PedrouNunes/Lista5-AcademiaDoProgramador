using System;

namespace Ex4.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Consumo consumo = new Consumo();

            consumo.kmInicial = 200;
            consumo.kmFinal = 500;
            consumo.consumoDeCombustivel = 40;

            Console.WriteLine("Consumo de combustível por km desse veículo é de: " + consumo.consumoPorKm() + "Km/L.");
        }
    }
}
