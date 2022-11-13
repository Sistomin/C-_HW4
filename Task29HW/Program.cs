﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Массив заполненый случайными числами от 0 до 10, длиной 8: ");

int[] array = GetBinaryArray(8); 
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetBinaryArray(int size) 
{
    int[] result = new int[size]; 
    for (int i = 0; i < size; i++) 
    {
        result[i] = new Random().Next(11); 
    }

    return result; 
}