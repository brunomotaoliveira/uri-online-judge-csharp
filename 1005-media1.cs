using System;

namespace MediaUm
{
    class UriMediaUm
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());


            double media = ((a * 3.5) + (b * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {media:f5}");
        }
    }
}