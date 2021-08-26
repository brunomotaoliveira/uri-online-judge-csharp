using System;

namespace MediaDois
{
    class UriMediaDois
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double media = ((a * 2)+ (b * 3) + (c * 5)) / 10;

            Console.WriteLine($"MEDIA = {media:f1}");
        }
    }
}