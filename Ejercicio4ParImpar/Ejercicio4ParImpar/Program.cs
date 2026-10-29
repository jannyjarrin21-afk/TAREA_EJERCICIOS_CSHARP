using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Ingrese un número entero: ");
        n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }
    }
}