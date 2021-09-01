using System;
//1003 - Soma Simples
namespace SomaSimples
{
    class UriSomaSimples
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}