using System;

namespace Ex3.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
               double pi = 3.14;

            Cilindro cilindro = new Cilindro();

            cilindro.altura = 5;
            cilindro.diametro = 6;

            cilindro.areaBase(pi);
            cilindro.volumeCilindro();

            Console.WriteLine("O volume do cilindro é: " + cilindro.volumeDoCilindro + "L².");
            
    }
    }
}
