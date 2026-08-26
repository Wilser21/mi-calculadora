namespace trabajo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("introduce tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("introduce tu edad");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("introduce la inicial de tu apellido");
        char inicialApellido = char.Parse(Console.ReadLine());
        Console.WriteLine("Es estudiante activo?");
        bool esActivo = bool.Parse(Console.ReadLine());
        Console.WriteLine($"ficha: \nNombre: {nombre}\nEdad: {edad}\nInicial del apellido: {inicialApellido}\nEstudiante activo: {esActivo} ");
        }

    }

