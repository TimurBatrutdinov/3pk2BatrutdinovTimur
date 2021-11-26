using System;
using System.IO;

namespace pz_14
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
                    int size = rd.Next(10, 100);
                    for (int i = 0; i < size; i++)
                    {
                        sw.WriteLine(rd.Next(0, 15));//Заполняем файл от 0 до 15
                    }
                }
            }
            int max = 0;
            int min = 15;

            using (StreamReader rd = new StreamReader(pathInput))
            {
                int val;
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    val = int.Parse(line);
                    if (val > max) max = val;
                    if (val < min) min = val;
                }
            }

            string pathOutput = @"C:\test\output.txt";
            using (StreamWriter wr = new StreamWriter(pathOutput))
            {
                wr.WriteLine("Максимальное число: " + max);
                wr.WriteLine("Минимальное число: " + min);
            }
        }
    }
}