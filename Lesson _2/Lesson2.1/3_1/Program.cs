﻿// Задача 1: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую wbahe цифру этого числа
Console.WriteLine("Введите чило");
string NumSec(int num)
{
    if((-1000 < num && num < -100) || (num < 1000 && num >100))
      return $"{num / 10 % 10}";
    return "The number is not three-digit!";
}
Console. WriteLine(NumSec(int.Parse(Console.ReadLine()!)));