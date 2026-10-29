using System;

class Program
{
    static void Main()
    {
        double a, b;

        Console.Write("Ingrese el primer número: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("El mayor es: " + a);
        }
        else if (b > a)
        {
            Console.WriteLine("El mayor es: " + b);
        }
        else
        {
            Console.WriteLine("Los dos números son iguales");
        }
    }
}