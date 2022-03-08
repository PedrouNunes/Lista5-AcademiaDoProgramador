namespace Ex1_Lista5.ConsoleApp
{
    internal partial class Program
    {
        public class caixaRetangular
        {
            public decimal altura;
            public decimal comprimento;
            public decimal largura;
            public decimal volumeCaixa;

            public void Volume()
            {
                volumeCaixa = altura * comprimento * largura;
            }
        }
    }
    }

