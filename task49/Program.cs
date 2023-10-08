// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[] MakeArray()
{
    Console.WriteLine("Введите b1, k1, b2 и k2 поочерёдно через пробел: ");
    double[] number = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
    return number;
}

void MakeСompute(double[] number)
{
    double b1 = number[0];
    double k1 = number[1];
    double b2 = number[2];
    double k2 = number[3];

    if (k1 == k2)
    {
        if (b1 == b2)
            Console.WriteLine("Прямые совпадают");
        else
            Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;        
        Console.WriteLine($"({x};{y})");
    }
}
MakeСompute(MakeArray());