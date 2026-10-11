using System;

internal partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escribe el primer numero");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("escribe +, -, *, /");
        string operation = Console.ReadLine().Trim();

        Console.WriteLine("Escribe el segundo numero");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (operation == "+")
        {
            Console.WriteLine("El resultado es: " + (num1 + num2));
        }
        else if (operation == "-")
        {
            Console.WriteLine("El resultado es: " + (num1 - num2));
        }
        else if (operation == "*")
        {
            Console.WriteLine("El resultado es: " + (num1 * num2));
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                Console.WriteLine("El resultado es: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
        }
        else
        {
            Console.WriteLine("Operación no válida.");
        }

        // --- BLOQUE DE REINICIO DE LA CALCULADORA ---
        Console.WriteLine("¿Desea realizar otra operación? (s/n)");
        string respuesta = Console.ReadLine().ToLower().Trim();

        if (respuesta == "s")
        {
            Main(args); // Llamada recursiva para reiniciar el programa
        }
        else
        {
            Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
        }
    }
}
