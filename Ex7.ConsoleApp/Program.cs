using System;

namespace Ex7.ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            SalarioFuncionario funcionario = new SalarioFuncionario();

            funcionario.salarioBase = 1000;
            funcionario.vendas = 20;
            funcionario.comissaoPercenual = 10;

            Console.WriteLine(" O salário do funcionario é de: R$" + funcionario.salarioFinalFucionario());
        }
    }
}
