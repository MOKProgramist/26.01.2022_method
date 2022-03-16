// See https://aka.ms/new-console-template for more information
Console.WriteLine("Посчитаю это f(x)= 3x-x^2");

Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
// вычисляем
double functionA = getFunction(a);
double functionB = getFunction(b);
// позиции элементов относительно друг друга
Console.WriteLine(functionA > functionB ? "А больше" : (functionA == functionB ? "А и Б равны" : "B больше"));

static double getFunction(int x)
{
    double f = (3 * x) - Math.Pow(x, 2);
    return f;
}