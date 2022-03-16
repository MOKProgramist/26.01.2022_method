// See https://aka.ms/new-console-template for more information
Console.WriteLine("Заменяю нечетные числа на 0, а четные делю на 2 :) ");


Console.Write("Введите число: ");
int a = CheckEvenNumber(int.Parse(Console.ReadLine()));
Console.Write(a);


static int CheckEvenNumber(int a)
{
    return a % 2 == 0 ? a / 2 : 0;
}
