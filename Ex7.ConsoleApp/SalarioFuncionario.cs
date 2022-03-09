namespace Ex7.ConsoleApp
{
    internal partial class Program
    {
        public class SalarioFuncionario
        {
            public double salarioBase;
            public int vendas;
            public double comissaoPercenual;
            private double comissao;
            private double salarioFinal;

            public double salarioFinalFucionario()
            {
                comissao = vendas * (comissaoPercenual / 100);

                salarioFinal = salarioBase + comissao;

                return salarioFinal;
            }
        }
        }
    }

