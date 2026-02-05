using System;

public class TriangleArea
{
    public static void Main(string[] args)
    {
        double baseValue;
        double height;

        Console.WriteLine("Triangle Area Calculator");
        Console.WriteLine("------------------------");

        Console.Write("Enter the base of the triangle: ");
        while (!double.TryParse(Console.ReadLine(), out baseValue) || baseValue <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number for the base.");
            Console.Write("Enter the base of the triangle: ");
        }

        Console.Write("Enter the height of the triangle: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number for the height.");
            Console.Write("Enter the height of the triangle: ");
        }

        double area = (baseValue * height) / 2;

        Console.WriteLine($"\nThe area of the triangle is: {area}");
    }
}
