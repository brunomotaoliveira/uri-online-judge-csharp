using System;
//1009 - Salario com Bonus
namespace SalarioComBonus
    {
        class UriSalarioComBonus
            {
                static void Main(string[] args)
                {
                    string nomeDoVendedor = Convert.ToString(Console.ReadLine());
                    double salarioFixo = Convert.ToDouble(Console.ReadLine());
                    double totalDeVendas = Convert.ToDouble(Console.ReadLine());

                    double totalParaReceber = salarioFixo + ((totalDeVendas * 15)/100);

                    Console.WriteLine($"TOTAL = R$ {totalParaReceber:f2}");
                }
            }
    }