// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int z = num / 100;
int count = 0;
int d = num;
if (z != 0)
{
    while (d != 0)
    {
        d = d / 10;
        count++;
    }
    Console.WriteLine($"В числе {count} порядка/ов");
    if (count > 4)
    {
        Console.WriteLine("Oooops... Здесь должна быть функция");
    }
    else if (count == 4)
    {
        int x = num % 100;
        int y = x / 10;
        if (y != 0)
        {
            Console.WriteLine($"Третья цифра = {y}");
        }
    }
    else if (count == 3)
    {
        int a = num%10; 
        Console.WriteLine($"Третья цифра = {a}");
    }

}
else
{
    Console.WriteLine("Третьей цифры у числа нет");
}