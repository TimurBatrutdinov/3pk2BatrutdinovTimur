using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
internal class Program
{

    private static void Main(string[] args)
    {
        // Рандом
        Random rand = new Random();
        // массив с данными
        int[] array = new int[10000];
        // список данных
        List<int> list = new List<int>();
        // хэш таблица
        Hashtable hash = new Hashtable();

        // заполнение рандомными числами
        for (int i = 0; i < array.Length; i++)
        {
            int random = rand.Next(1, 1000);
            hash.Add(i, random);
            array[i] = random;
            list.Add(random);

        }


        Stopwatch stopWatch = new Stopwatch();

        Console.WriteLine($"ЗНАЧЕНИЕ МОЖНО?");
        int target = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("ПРЯМОЙ!");
        Console.WriteLine();

        Console.WriteLine($"Число {target} внутри массива");

        stopWatch.Start();

        int index = 0;
        while (index < array.Length && array[index] != target)
        {
            index++;
            if (index < array.Length)
            {
                Console.WriteLine($"НАШЕ {target} ВОТ ОНО!");
                break;
            }
            else
            {
                Console.WriteLine($"НАШЕГО {target} НЕТ");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"СТОПВОТЧ: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"Вот {target} в списке");
        stopWatch.Reset();
        stopWatch.Start();

        index = 0;
        while (index < list.Count && list[index] != target)
        {
            index++;
            if (index < list.Count)
            {
                Console.WriteLine($"НАШЕ {target} ВОТ ОНО!");
                break;
            }
            else
            {
                Console.WriteLine($"НАШЕГО {target} НЕТ!");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"СТОПВОТЧ: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"НАШЕ {target} в hash-Tabl");
        stopWatch.Reset();
        stopWatch.Start();

        index = 0;
        while (index < hash.Count && Convert.ToInt32(hash[index]) != target)
        {
            index++;
            if (index < hash.Count)
            {
                Console.WriteLine($"Наше {target} ВОТ ОНО!");
                break;
            }
            else
            {
                Console.WriteLine($"НАШЕГО {target} НЕТ!");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"СТОПВОТЧ: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("БИНАРНЫЙ ");
        Console.WriteLine();


        Console.WriteLine($"Наше {target} в массиве");
        stopWatch.Reset();
        stopWatch.Start();

        int middle, left = 0, right = array.Length - 1;
        middle = (left + right) / 2;
        if (target > array.Length)
            left = middle + 1;
        else
            right = middle - 1;
        while ((array[middle] != target) && (left <= right))
        {
            if (array[middle] == target)
            {
                Console.WriteLine($"НАШЕ {target} ВОТ ОНО!");
                break;
            }
            else
            {
                Console.WriteLine($"НАШЕГО {target} НЕТ!");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"СТОПВОТЧ: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"Наше {target} в списке");
        stopWatch.Reset();
        stopWatch.Start();

        left = 0;
        right = list.Count - 1;
        middle = (left + right) / 2;
        if (target > list.Count)
            left = middle + 1;
        else
            right = middle - 1;
        while ((list[middle] != target) && (left <= right))
        {
            if (list[middle] == target)
            {
                Console.WriteLine($"НАШЕ {target} ВОТ ОНО!");
                break;
            }
            else
            {
                Console.WriteLine($"НАШЕГО {target} НЕТ!");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"СТОПВОТЧ: {stopWatch.Elapsed}");

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"Наше {target} в массиве");
        stopWatch.Reset();
        stopWatch.Start();

        left = 0;
        right = hash.Count - 1;
        middle = (left + right) / 2;
        if (target > hash.Count)
            left = middle + 1;
        else
            right = middle - 1;
        while ((Convert.ToInt32(hash[middle]) != target) && (left <= right))
        {
            if (Convert.ToInt32(hash[middle]) == target)
            {
                Console.WriteLine($"НАШЕ {target} ВОТ ОНО!");
                break;
            }
            else
            {
                Console.WriteLine($"НАШЕГО {target} НЕТ");
                break;
            }
        }

        stopWatch.Stop();
        Console.WriteLine($"СТОПВОТЧ: {stopWatch.Elapsed}");

    }
}
