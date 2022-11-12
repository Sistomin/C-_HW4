// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

void GetSumNums(int number)
{
int sum = 0;
for (int i = 1; i <= Math.Abs(number); i++)
{
    sum += i;
}
Console.WriteLine($"Сумма цифр от 1 жо введеного числа: {sum}");
}
Console.Clear();
GetSumNums(5);
GetSumNums(50);
GetSumNums(25);
GetSumNums(325);