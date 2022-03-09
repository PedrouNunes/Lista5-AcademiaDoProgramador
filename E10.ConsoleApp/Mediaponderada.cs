namespace E10.ConsoleApp
{
    internal partial class Program
    {
        public class Mediaponderada
        {
            public double nota1;
            public double nota2;
            public double pesoNota1;
            public double pesoNota2;

            public double MediaP()
            {
                double media = ((nota1 * pesoNota1) + (nota2 * pesoNota2)) / (pesoNota1 + pesoNota2);
                return media;
            }
        }
    }
    }

