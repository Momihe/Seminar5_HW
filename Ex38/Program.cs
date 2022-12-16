/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3, 7, 22, 2, 78] -> 76
*/

void FillArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++ )
            {
                array[i] = Math.Round(new Random().NextDouble(),2)+new Random().Next(1,100);
            }
    Console.WriteLine($"Массив [{string.Join(" | ", array)}]");
    }
void minmax(double[] array)
    {
        double max = array[1];
        double min = array[1];
        for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
    Console.WriteLine($"Максимум равен: {max}. Минимум равен: {min}. Разность равна: {Math.Round((max-min),2)}");
    }
Console.Clear();
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
    {
    Console.Write("Введите длинну массива: ");
    n = Convert.ToInt32(Console.ReadLine());
    }
double[] array = new double[n];
FillArray(array);
minmax(array);
