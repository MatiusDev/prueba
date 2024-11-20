using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Hola, mundo!");
        
        // Solicitar información al usuario
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        // Saludar al usuario
        Console.WriteLine($"Hola, {nombre}! Bienvenido a tu aplicación de consola.");

        // Mantener la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
