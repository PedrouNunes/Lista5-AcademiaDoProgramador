using System;

namespace Ex1_Lista5.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            caixaRetangular caixa = new caixaRetangular();

            caixa.altura = 5;
            caixa.largura = 6;
            caixa.comprimento = 7;

            caixa.Volume();
            Console.WriteLine("O volume da caixa retângular é de: " + caixa.volumeCaixa + "m².");
    }
    }
}
