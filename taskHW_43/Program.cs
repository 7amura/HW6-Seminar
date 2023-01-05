// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, 
// y = k2 * x + b2 
// k1 * x + b1 = k2 * x + b2 
// (k1 - k2) * x = b2 - b1 
// x = (b2 - b1) / (k1 - k2) 
// y = k1 * x + b1


Console.WriteLine("Enter the number k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number k2: ");
int k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number b2: ");
int b2 = int.Parse(Console.ReadLine()!);

void CrossPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2)/(k2 - k1);
    double y = (k2*b1-k1*b2)/(k2-k1);
    if(k1 == k2 && b1 == b2) Console.WriteLine($"Заданные прямые не пересекаются!");
    else
    {
        Console.WriteLine($"Точка пересечения заданных прямых: ({x}, {y})");
    }
}
CrossPoint(k1, b1, k2, b2);