using System;

class Program
{
    static void Main()
    {
        double n1, n2, n3, promedio;

        Console.Write("Ingrese la primera nota: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        promedio = (n1 + n2 + n3) / 3;

        Console.WriteLine("El promedio es: " + promedio);
    }
}