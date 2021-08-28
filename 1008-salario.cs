using System;

namespace Salario
{
    class UriSalario
    {
        static void Main(string[] args)
        {
            int numeroFuncionario = Convert.ToInt32(Console.ReadLine());
            int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());
            double valorPorHora = Convert.ToDouble(Console.ReadLine());

            double salarioDoFuncionario = horasTrabalhadas * valorPorHora;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salarioDoFuncionario:f2}");
        }
    }
}