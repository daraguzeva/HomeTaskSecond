// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 7 && num >= 1)
{
    if (num >= 1 && num <= 5)
    {
        Console.WriteLine("Рабочий день :(");
    }
    else if (num == 6 || num == 7)
    {
        Console.WriteLine("Ура, выходной!");
    }
}
else
{

    Console.WriteLine("Такого дня недели нет :(");
}
