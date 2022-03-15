using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Informe um número: ");
        double banana = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
}