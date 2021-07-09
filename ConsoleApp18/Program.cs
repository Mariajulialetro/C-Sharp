using System;
using System.Globalization;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, pi, volume;

            R = double.Parse(Console.ReadLine());

            pi = 3.14159;

            volume = (double) (4 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));









        }
    }
}
