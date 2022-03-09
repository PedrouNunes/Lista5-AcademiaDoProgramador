namespace Ex5.ConsoleApp
{
    internal partial class Program
    {
        public class Esfera
        {
            public double diametro;
            private double volume;
            private double raio;

            public double volumeEsfera(double pi)
            {
                raio = diametro / 2;
                volume = ((4 * pi) * (raio * raio * raio))/3;
                return volume;
            }
        }
        }
    }

