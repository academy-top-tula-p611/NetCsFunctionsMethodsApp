//SayName("Привет");
//PrintStars(12);

//SayName("Добро пожаловать");

//int size = 22;
//PrintStars(size);

//int value = 0;
//Func(value);
//Console.WriteLine(value);

//int sum;
//sum = Sum(20, 30);

//Console.WriteLine(sum);

int bound = 2000;
Console.WriteLine($"Gauss Amount for { bound } = { GaussAmount(bound) }");


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
void Func(int value)
{
    value = 1000;
}

int Sum(int left, int right)
{
    int result = left + right;
    return result;
}

int Mult(int left, int right)
{
    return left * right;
}

int Sub(int left, int right)
{
    return left - right;
}

int Calc(int left, int right, char sign)
{
    int result = 0;

    switch(sign)
    {
        case '+': 
            result = Sum(left, right); 
            break;
        case '-':
            result = Sub(left, right);
            break;
        case '*':
            result = Mult(left, right);
            break;
    }

    return result;
}


int GaussAmount(int maxNumber)
{
    int amount = 0;
    for (int i = 1; i <= maxNumber; i++)
        amount += i;
    return amount;
}




void PrintInfo(string name, int age)
{
    string nameInfo = $"Имя: {name}";
    int length = nameInfo.Length;

    PrintStars(length + 4);
    
}