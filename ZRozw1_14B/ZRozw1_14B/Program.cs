using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZRozw1_14B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj symbol temperatury, K-Kelvin, C-Celsjusz, F-Fahrenheit");
            ConsoleKeyInfo klawisz = Console.ReadKey();
            char znak = klawisz.KeyChar;
            Console.ReadLine();
            Console.WriteLine("Podaj wartość temperatury");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (znak == 'K')
            {
                Console.WriteLine("Temperatura w C = {0}", temp - 273.15);
                Console.WriteLine("Temperatura w F = {0}", 9 * (temp - 273.15) / 5 + 32);
            }
            else if (znak == 'C')
            {
                Console.WriteLine("Temperatura w K = {0}", temp + 273.15);
                Console.WriteLine("Temperatura w F = {0}", 9 * temp / 5 + 32);
            }
            else if (znak == 'F')
            {
                Console.WriteLine("Temperatura w K = {0}", 5 * (temp - 32) / 9 + 273.15);
                Console.WriteLine("Temperatura w C = {0}", 5 * (temp - 32) / 9);
            }

            Console.ReadKey();
        }
    }
}
