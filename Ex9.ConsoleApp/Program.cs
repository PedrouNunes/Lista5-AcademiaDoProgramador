using System;

namespace Ex9.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica media = new MediaHarmonica();

            media.nota1 = 1;
            media.nota2 = 2;
            media.nota3 = 3;

            Console.WriteLine("A média harmonica das notas desse aluno é de: " + media.MediaH());
        }
    }
}
