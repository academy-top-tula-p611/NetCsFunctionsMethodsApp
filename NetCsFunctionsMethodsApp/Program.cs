SayName("Привет");
PrintStars(12);

SayName("Добро пожаловать");
PrintStars(22);


void SayName(string sayWord)
{
    Console.Write("Введите имя: ");
    string name = Console.ReadLine();
    Console.WriteLine($"{sayWord} {name}");
}

void PrintStars(int length)
{
    for(int i = 0; i < length; i++)
        Console.Write("*");
    Console.WriteLine();
}

