using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + func);
            Console.WriteLine("");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentoSalario(porcent);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizado: " + func);
        }
    }
}
