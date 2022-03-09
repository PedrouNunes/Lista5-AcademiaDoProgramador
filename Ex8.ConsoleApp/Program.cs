using System;

namespace Ex8.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            lataDeOleo lata = new lataDeOleo();

            lata.altura = 7;
            lata.raio = 6;

            Console.WriteLine("O volume da lata de óleo é: " + lata.VolumeLata(pi) + "cm³.");
        }
    }
}
