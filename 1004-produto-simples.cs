using System;
//1004 - Produto Simples
namespace ProdutoSimples
{
    class UriProdutoSimples
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int prod = a * b;

            Console.WriteLine($"PROD = {prod}");
        }
    }
}