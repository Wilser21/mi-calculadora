namespace trabajo;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;
        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicacion = num1 * num2;
        int divEntera = num1 / num2;
        double divDecimal = num1 / (double)num2;
        int modulo = num1 % num2;
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División entera: {divEntera}");
        Console.WriteLine($"División decimal: {divDecimal}");
        Console.WriteLine($"Módulo: {modulo}");
        bool mayorQue = num1 > num2;
        bool igualQue = num1 == num2;
        bool diferenteQue = num1 != num2;

        Console.WriteLine("\n--- Comparaciones Relacionales ---");
        Console.WriteLine($"¿{num1} > {num2}?: {mayorQue}");
        Console.WriteLine($"¿{num1} == {num2}?: {igualQue}");
        Console.WriteLine($"¿{num1} != {num2}?: {diferenteQue}");
          }
     }

