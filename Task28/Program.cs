// Напишите программу, которая принимает на вход число А и выдает произведение чисел от 1 до А

void GetSumNums(int number)
{
    int sum = 1;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum *= i;
    }
    Console.WriteLine($"Сумма цифр от 1 до введеного числа А = {sum}");
}
Console.Clear();
Console.Write("Ввведите число A: ");
GetSumNums(Convert.ToInt32(Console.ReadLine()));
