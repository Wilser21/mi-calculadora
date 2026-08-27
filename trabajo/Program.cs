namespace trabajo;

class Program
{
    static void Main(string[] args)
    {
Console.Write("Introduce la temperatura en grados Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
double kelvin = celsius + 273.15;
Console.WriteLine($"\n--- Resultados de Conversión ---");
Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
Console.WriteLine($"Kelvin: {kelvin:F2} K");

          }
     }

