using System;
using System.Globalization;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = @"C:\test\input.txt";//Путь к файлу для чтения
            if (!File.Exists(pathInput)) // Проверяем на существование
            {
                // Создаём и записывам в этот файл
                using (StreamWriter sw = File.CreateText(pathInput))
                {

                    Random rd = new Random();
                    int size = rd.Next(10, 50);

                    for (int i = 0; i < size; i++)
                    {
                        sw.WriteLine
                        (
                        i.ToString("000") + " " +
                        (rd.Next(0, 9999) + rd.NextDouble()).ToString("0000.00")
                        );
                    }
                }

            }
            float sum = 0f;
            int count = 0;
            float max = float.MinValue;
            float min = float.MaxValue;
            using (StreamReader rd = new StreamReader(pathInput))
            {
                string line;
                float val;
                while ((line = rd.ReadLine()) != null)
                {
                    count++;
                    val = float.Parse(line.Split(' ')[1]);
                    sum += val;
                    if (val > max) max = val;
                    if (val < min) min = val;
                }
            }
            Console.WriteLine("Путь к файлу: " + pathInput);
            Console.WriteLine("Кол-во строк: " + count);
            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Сумма: " + sum);
        }
    }
}