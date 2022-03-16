// See https://aka.ms/new-console-template for more information
Console.WriteLine("Найду минимальное число из двух.");

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

double d = (checkMinNumber(a, b) * (checkMinNumber(3 * a, 2 * b) + checkMinNumber(a - b, a + b)));
Console.WriteLine($"d = {d}");

static int checkMinNumber(int a, int b)
{
    return a < b ? a : b;
}
