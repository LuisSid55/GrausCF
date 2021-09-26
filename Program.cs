using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;
            Console.WriteLine("\n--Conversor de °C para °F--");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n°C: ");
            c = Convert.ToDouble(Console.ReadLine());

            f = (c * 1.8) + 32;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n {c}°C equivale a {f}°F\n");
            Console.ResetColor();
        }
    }
}
