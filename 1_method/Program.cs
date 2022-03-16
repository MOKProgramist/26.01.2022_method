// See https://aka.ms/new-console-template for more information
// регистрация
Console.WriteLine("Создание новой учетной записи");
var (login_, pas_) = createUser();
// авторизация
Console.WriteLine("Авторизация"); 
checkLofinAndPasUser(login_, pas_);

static void checkLofinAndPasUser(int login_, int password_)
{
    int countPop = 3;
    while (countPop >= 0)
    {
        Console.Write("Введите логин: ");
        int login = int.Parse(Console.ReadLine());
        Console.Write("Ввелите пароль: ");
        int pas = int.Parse(Console.ReadLine());
        // проверка с пользовательским вводом
        if ((login == login_ && pas == password_) && countPop != 0)
        {
            Console.WriteLine("Добро пожаловать.");
            return;
        }
        else if (countPop != 0)
        {
            countPop--;
            Console.WriteLine($"Осталось попыток {countPop}");
        }
        else
        {
            Console.WriteLine("Попыток больше не осталось.");
            return;
        }
    }
    }
    // регистрация и вернем логин с паролем
    static (int login_, int pas_) createUser()
{
    Console.Write("Введите логин: ");
    int login = int.Parse(Console.ReadLine());
    Console.Write("Введите пароль: ");
    int pas = int.Parse(Console.ReadLine());

    return (login, pas);
}