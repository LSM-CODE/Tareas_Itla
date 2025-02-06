// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Solicitar un número al usuario
        Console.Write("Introduce un número: ");
        int numero = Console.Read();

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número ingresado es par.");
        }
        else
        {
            Console.WriteLine("El número ingresado es impar.");
            
        }
        Console.ReadKey();
    }
}
