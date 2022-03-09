using System;

namespace E10.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Mediaponderada media = new Mediaponderada();

            media.nota1 = 10;
            media.nota2 = 8;
            media.pesoNota1 = 3;
            media.pesoNota2 = 2;

            Console.WriteLine("A média ponderada das notas desse aluno é de: " + media.MediaP());
    }
    }
}
