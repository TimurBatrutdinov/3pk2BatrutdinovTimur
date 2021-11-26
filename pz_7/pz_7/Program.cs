using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            Random rnd = new Random();
            //Заполнение массива рандомными числами
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(-50, 49);
                Console.Write(nums[i] + " ");
            }

            int sum = 0;
            //Хранилище минимального положительного числа в массиве
            int min_positive_num = 49;
            for (int i = 0; i < nums.Length; i++)
            {
                //Минимальное положительное число должно быть больше 0 и меньше остальных положительных элементов
                if (min_positive_num > nums[i] && nums[i] >= 0)
                    min_positive_num = nums[i];
                //Подсчет всех отрицательных чисел
                if (nums[i] < 0)
                    sum += nums[i];
            }

            Console.WriteLine("Минимальное положительное = " + min_positive_num);
            //Если сумма меньше -100, то прибавляется минимальное положительное число
            if (sum > -100)
                sum += min_positive_num;

            Console.WriteLine("Res: " + sum);
        }
    }
}