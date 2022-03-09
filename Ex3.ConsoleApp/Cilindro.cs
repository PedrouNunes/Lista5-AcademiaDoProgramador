namespace Ex3.ConsoleApp
{
    internal partial class Program
    {
        public class Cilindro
        {
           
            public double diametro;
            public double altura;
            public double volumeDoCilindro;
            private double areaDaBase;

            public void areaBase(double pi)
            {
                areaDaBase = pi * ((diametro/2) * (diametro/2));
            }

            public void volumeCilindro()
            {
                volumeDoCilindro = areaDaBase * altura;
            }
        }
    }
    }

