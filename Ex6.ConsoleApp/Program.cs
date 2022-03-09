using System;

namespace Ex6.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Fahrneheit conversao = new Fahrneheit();

            conversao.celsius = 30;

            conversao.Conversao();

            Console.WriteLine("Temperatura de graus Celcius para Fahrenheit: " + conversao.Conversao() + "F° ");
    }
    }
}
