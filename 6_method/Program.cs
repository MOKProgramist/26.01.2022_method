// See https://aka.ms/new-console-template for more information
Console.WriteLine("Вычисление площади эллипса ");

Console.Write("Введите а: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());

double area = getAreaAlips(a, b);
Console.WriteLine(area);

static double getAreaAlips(double a, double b)
{
    double S = a * b * Math.PI;
    return Math.Round(S, 3);
}
