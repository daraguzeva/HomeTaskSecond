﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 1000 == 0)
{
    int x = num % 100;
    int y = x / 10;
    Console.WriteLine($"Вторая цифра у числа {num} - {y}");
}