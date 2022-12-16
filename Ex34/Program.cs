/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
int goodboy(int[] array)
{
    int goodend = 0;
    for (int i = 0; i < array.Length; i++)
        if ((array[i] % 2) == 0) goodend++;
    return goodend;
}

Console.Clear();
Console.Write("Введите длинну массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
{
    Console.Write("Введите длинну массива N: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[n];
FillArray(array);
Console.WriteLine($"Количество четных чисел: {goodboy(array)}.");
