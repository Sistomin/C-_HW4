// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма цифр от 1 до введеного числа А = {sum}");
}
Console.Clear();
//Console.Write("Ввведите число A: ");
//int numberRead = Convert.ToInt32(Console.ReadLine());
//GetSumNums(numberRead);
// или так
Console.Write("Ввведите число A: ");
GetSumNums(Convert.ToInt32(Console.ReadLine()));