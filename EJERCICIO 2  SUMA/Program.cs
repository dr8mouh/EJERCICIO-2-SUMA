

using System;
namespace Ejercicio_2
{
    class programa_2
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;

            System.Console.WriteLine("Ingresa el número 1: ");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa el número 2: ");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;

            System.Console.WriteLine("El resultado es: " + resultado);
            Console.ReadLine();
        }
    }
}
