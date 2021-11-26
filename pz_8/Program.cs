using System;
namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём одномерный массив с рандомным размером
            Random random = new Random();
            int[] arrayInt = new int[random.Next(8, 15)];
            // Создаём минимальное значение, которое будет изменяться
            int minPositiveNum = 50;
            // Заполняем массив рандомными значениями от -50 до 49
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = random.Next(-50, 49);
                if (0 <= arrayInt[i] && arrayInt[i] < minPositiveNum) minPositiveNum = arrayInt[i];
            }
            // Суммируем отрисательные значения
            int sum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < 0) sum += arrayInt[i];
            }
            // Проверям сумму меньше -100
            if (sum < -100) sum += minPositiveNum;
            // Выводим результаты
            Console.Write("Значения массива: ");
            foreach (int i in arrayInt)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма отрицательных чисел равна {sum}");
        }
    }
}