//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
Console.WriteLine("Введите чило");

void ThirdNum(int num)
{
    Console.WriteLine($"{num} ->");
    if (num < 100)
    {
        Console.WriteLine("there is no third digit");
        return;
    }

    while (num > 999) num /= 10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()!));





