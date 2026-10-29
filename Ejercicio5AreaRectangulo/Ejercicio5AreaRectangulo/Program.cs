using System;

class Program
{
    static void Main()
    {
        double baseRectangulo, altura, area;

        Console.Write("Ingrese la base: ");
        baseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        area = baseRectangulo * altura;

        Console.WriteLine("El área del rectángulo es: " + area);
    }
}