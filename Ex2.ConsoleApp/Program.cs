using System;

namespace Ex2.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Celsius conversao = new Celsius();

            conversao.fahrenheit = 86;

            conversao.Conversao();

            Console.WriteLine("Temperatura de graus Fahrenheit para Celcius: " + conversao.celsius + " C° ");
        }
    }
}
