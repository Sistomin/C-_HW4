// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

int Exponentiation(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.WriteLine("Программа которая выводит число А в степени В.");
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = Exponentiation(A, B);
Console.WriteLine($"Число А в степени В = {result}.");