using System;

namespace Ex5.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
          Esfera esfera = new Esfera();

         double pi = 3.14;

            esfera.diametro = 8;

            Console.WriteLine("O volume da esfera é: " + esfera.volumeEsfera(pi) + "cm³.");
        


       
        }
    }
}
