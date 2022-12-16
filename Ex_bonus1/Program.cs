/*
Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, 
чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным 
дням месяца он получал тройки, а по четным – четверки. Так же он помнит, 
в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того,
чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, 
расположив четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, 
если четверок не меньше, чем троек.

Входные данные
В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов 
целочисленного массива (1 ≤ N ≤ 100). Вторая строка содержит N чисел, представляющих заданный массив.
 Каждый элемент массива – натуральное число от 1 до 31. Все элементы массива разделены пробелом.

Выходные данные
В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев,
в которые Вася получил тройки, а во второй строке соответственно расположить числа месяца, 
в которые Вася получил четверки. В третьей строке нужно вывести «YES», если Вася может рассчитывать
на четверку и «NO» в противном случае. В каждой строчке числа следует выводить в том же порядке, 
в котором они идут во входных данных. При выводе числа отделяются пробелом.
*/

void FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++ )
            {
                array[i] = new Random().Next(1,32);
            }
    Console.WriteLine($"Дни всего: [{string.Join(", ", array)}])");
    }
string goodboy(int[] array)
    {   int goodend = 0;
        int badend = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) == 0) goodend++;
                else badend++;                       
            }
        int[] goodarray = new int[goodend];
        int[] badarray = new int[badend];
        int g = 0;
        int b = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    {
                        goodarray[g] = array[i];
                        g++;  
                    }
                else
                    {
                        badarray[b] = array[i];
                        b++;
                    }
            }
        Console.WriteLine($"Вася получил тройки: [{string.Join(", ", badarray)}]. Всего {badarray.Length} раз(a).");
        Console.WriteLine($"Вася получил четверки: [{string.Join(", ", goodarray)}]. Всего {goodarray.Length} раз(a).");
        //int good = goodarray.Length;
        //int bad = badarray.Length;
        //Console.WriteLine(good);
        //Console.WriteLine(bad);
        if (goodarray.Length == badarray.Length) return "Вот это поворот!"; 
        if (goodarray.Length > badarray.Length) 
        return "Вася может рассчитывать на четверку!"; 
        return "Вася не может рассчитывать на четверку. =(";
    }    
Console.Clear();
Console.Write("Введите длинну выборки дней N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 100)
    {
    Console.WriteLine("N должен быть: 0 < N < 101.");
    Console.Write("Введите длинну выборки дней N: ");
    n = Convert.ToInt32(Console.ReadLine());
    }
int[] array = new int[n];
FillArray(array);
Console.WriteLine(goodboy(array));













