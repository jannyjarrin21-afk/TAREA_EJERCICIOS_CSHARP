using System;

class Program
{
    static void Main()
    {
        double num1, num2, suma;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        suma = num1 + num2;

        Console.WriteLine("La suma es: " + suma);
    }
}