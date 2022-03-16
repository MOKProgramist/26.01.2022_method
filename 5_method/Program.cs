// See https://aka.ms/new-console-template for more information

// площадь треугольника по формуле Герона
Console.WriteLine("площадь треугольника по формуле Герона");
Console.Write($"Введите сторону a: ");
double a = double.Parse(Console.ReadLine());
Console.Write($"Введите сторону b: ");
double b = double.Parse(Console.ReadLine()); 
Console.Write($"Введите сторону c: ");
double c = double.Parse(Console.ReadLine());

double S, P;
GetTriangleArea(a, b, c, out S, out P);
Console.WriteLine($"Площадь треугольника равна {S}, а периметр {P}");

static void GetTriangleArea(double a, double b, double c, out double S, out double P)
{
    var p = (a + b + c) / 2;
    // формлула Герона площадь
    var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    S = Math.Round(s, 3);
    P = Math.Round(p, 3);
}