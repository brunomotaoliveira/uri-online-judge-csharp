using System;

namespace AreaDoCirculo
{
    class URI
    {
        static void Main(string[] args)
        {
            double raio = Convert.ToDouble(Console.ReadLine());
            double n = 3.14159;
            double area = n * (raio * raio);

            Console.WriteLine($"A={area:f4}");
        }
    }
}