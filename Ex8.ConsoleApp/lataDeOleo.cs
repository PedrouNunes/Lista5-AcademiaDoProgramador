namespace Ex8.ConsoleApp
{
    internal partial class Program
    {
        public class lataDeOleo
        {
            public double altura;
            public double raio;

            public double VolumeLata(double pi) 
            {
                double volume = (pi * raio) - (2 * altura);
                return volume;
            }

        }
        }
    }

