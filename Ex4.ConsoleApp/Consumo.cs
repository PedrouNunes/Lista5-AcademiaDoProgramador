namespace Ex4.ConsoleApp
{
    internal partial class Program
    {
        public class Consumo
        {
            public double kmInicial;
            public double kmFinal;
            public int consumoDeCombustivel;
            public double consumoTotal;

            public double consumoPorKm()
            {
                consumoTotal = (kmFinal - kmInicial) / consumoDeCombustivel;
                return consumoTotal;
            }
        }
        }
    }

