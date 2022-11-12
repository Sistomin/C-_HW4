// Напишите программу, коорая принимает на вход число N и выдает количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = GetCountNums(num);
Console.WriteLine($"Количество цифр = {sum}");

int GetCountNums(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}