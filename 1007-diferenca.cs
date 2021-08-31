using System;
//1007 - Diferenca
namespace Diferenca 
{
    class UriDiferenca
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));

            Console.WriteLine($"DIFERENCA = {diferenca}");

        }
    }
}