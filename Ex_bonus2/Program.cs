/*
Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, 
причём таких разложений может быть несколько. Впервые гипотезу о существовании данного 
разложения сформулировал математик Х. Гольдбах.

Требуется написать программу, производящую согласно утверждению Гольдбаха, 
разложение заданного чётного числа. Из всех пар простых чисел, сумма которых равна заданному 
числу, требуется найти пару, содержащую наименьшее простое число.

Входные данные
Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).

Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести два простых числа, сумма которых равна числу N. 
Первым выводится наименьшее число.
*/

void gold(int n, int z)
    {
    for (int i = 0; i < z; i++)
        {
        int temp = 0;
        int firstpart = new Random().Next(1, n);
        if (firstpart % 2 == 0) firstpart -=1;
        int secondpart = n - firstpart;
        if (secondpart < firstpart)
            {
                temp = secondpart;
                secondpart = firstpart;
                firstpart = temp;
            }
    Console.WriteLine($"{i+1}-я попытка: {firstpart} и {secondpart}. Контрольная сумма: {firstpart+secondpart}. ");
        }     
    }

Console.Clear();
Console.Write("Введите четное число N, где 3 < N < 999: ");
int n = Convert.ToInt32(Console.ReadLine());
while ( (n % 2 == 1) || n < 4 || n > 999)
    {
        Console.Write("Введите четное число N, где 3 < N < 999: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
Console.Write("Введите количество итерраций: ");
int z = Convert.ToInt32(Console.ReadLine());
while ( z < 1)
    {
        Console.Write("Введите количество итерраций: ");
        z = Convert.ToInt32(Console.ReadLine());
    }
gold(n,z);








