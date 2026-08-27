namespace trabajo;

class Program
{
    static void Main(string[] args)
    {
    
Console.Write("Introduce el radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());

double areaCirculo = Math.PI * Math.Pow(radio, 2);
double perimetroCirculo = 2 * Math.PI * radio;

Console.Write("Introduce la base del rectángulo: ");
double baseRect = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce la altura del rectángulo: ");
double alturaRect = Convert.ToDouble(Console.ReadLine());

double areaRectangulo = baseRect * alturaRect;
double perimetroRectangulo = 2 * (baseRect + alturaRect);

Console.WriteLine($"\n--- Resultados del Círculo ---");
Console.WriteLine($"Área: {areaCirculo:F2}");
Console.WriteLine($"Perímetro: {perimetroCirculo:F2}");

Console.WriteLine($"\n--- Resultados del Rectángulo ---");
Console.WriteLine($"Área: {areaRectangulo:F2}");
Console.WriteLine($"Perímetro: {perimetroRectangulo:F2}");


          }
     }

