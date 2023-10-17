using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graus_Fahrenheit_Em_Graus_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graus Fahrenheit:");
            float fahrenheit = int.Parse(Console.ReadLine());
            float Celsius = Conversor(fahrenheit);
            Console.WriteLine(Celsius);
            Console.ReadLine();
        }
        static float Conversor(float fahrenheit)
        {
            float grausCelsius = (fahrenheit - 32f) * 5f / 9f;
            return grausCelsius;
        }
    }
}
