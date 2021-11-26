using System;
using System.IO;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[][] answer = new char[9][];
            char[] last = new char[9];
            char[] max = new char[9];
            char zp = ' ';
            Console.WriteLine("Массив:");
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = new char[rnd.Next(10, 36)];
                for (int c = 0; c < answer[i].Length; c++)//заполнение массива и вывод его в консоль
                {
                    answer[i][c] = (char)rnd.Next(0x0410, 0x44F);
                    Console.Write(answer[i][c] + " ");
                    if (answer[i][c] > max[i] && c != 0)
                    {
                        max[i] = answer[i][c];
                    }
                }
                last[i] = (char)answer[i][answer[i].Length - 1];//запись последнего элемента каждой строки
                Console.WriteLine();
                zp = answer[i][0];
                answer[i][0] = answer[i][answer[i].Length - 1];
                answer[i][answer[i].Length - 1] = zp;
            }

            Console.WriteLine("Последние элементы каждой строки: ");
            for (int i = 0; i < last.Length; i++)//вывод последнего элемента каждой строки
            {
                Console.WriteLine(last[i]);
            }
            Console.WriteLine("Максимальные элементы каждой строки: ");
            for (int i = 0; i < last.Length; i++)//вывод последнего элемента каждой строки
            {
                Console.WriteLine(max[i]);
            }
            Console.WriteLine("Обновленный массив:");
            for (int i = 0; i < answer.Length; i++)
            //выводим обновленный массив
            {
                for (int b = 0; b < answer[i].Length; b++)
                {
                    Console.Write(answer[i][b] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}