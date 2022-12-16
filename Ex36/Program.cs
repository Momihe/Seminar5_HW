/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0


*/
void FillArray(int[] array, int z)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-z, z+1);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
int goodboy(int[] array)
{
    int goodend = 0;
    for (int i = 1; i < array.Length; i++)
        {
        if ((i % 2) == 1) 
            {
            goodend+=array[i];
            //Console.WriteLine($"cell = {i}; number = {array[i]}");
            }
        }
    return goodend;
}

Console.Clear();
Console.Write("Введите длинну массива N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Здайте диапазон значений массива Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array, z);
Console.WriteLine($"Сумма всех чисел нечетных индексов массива: {goodboy(array)}.");
