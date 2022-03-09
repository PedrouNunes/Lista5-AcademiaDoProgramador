namespace Ex6.ConsoleApp
{
    internal partial class Program
    {
        public class Fahrneheit
        {
            public double fahrenheit;
            public double celsius;

            public double Conversao()
            {
                fahrenheit = celsius * 1.8 + 32;
                return fahrenheit;
            }
        }
    }
    }

