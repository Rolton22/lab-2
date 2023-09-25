using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lessons
{



    class Program
    {

        static void Main(string[] args)
        {
            //27 Определить сколько процентов от всего кол-во элементов последовательности целых чисел составляют нечетные элемент

            task27();
            Console.WriteLine("\ntask27 Закончил свою работу!");

            //34 Дан массив вещественных чисел размер которого N.
            //Подсчитать сколько в нем отрицательных положительных и нулевых элементов

            task34();
            Console.WriteLine("\ntask34 Закончил свою работу!");


            //53 В целочисленной последовательности есть нулевые элементы.
            //Создать массив из номеров этих элементов.

            task53();
            Console.WriteLine("\n\ntask53 Закончил свою работу!\n");

            //90 Дана непустая последовательность целых чисел, оканчивающаяся отрицательным числом.
            //Верно ли, что все элементы последовательности равны между собой?


            task90();
            Console.WriteLine("\ntask90 Закончил свою работу!\n");

            //151 Дан массив X[N] целых чисел.
            //Не используя других массивов, переставить его элементы в обратном порядке.

            task151();
            Console.WriteLine("\n\ntask151 Закончил свою работу!\n");
            Console.ReadLine();
        }

        static void task27()
        {
            Random random = new Random();
            int[] arrayOfIntegers = new int[random.Next(1, 15)];
            int x = 0, count = 0;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                arrayOfIntegers[i] = random.Next(1, 100);
            }

            Console.Write("Ваш массив: ");
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                Console.Write(arrayOfIntegers[i] + " ");
            }

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] % 2 != 0)
                {
                    count++;
                }
            }

            if (count != 0)
            {
                x = (count * 100) / arrayOfIntegers.Length;
                Console.WriteLine($"\nОт всего кол-во элементов последовательности целых чисел составляют {x}% нечетные элементы ");
            }
            else if (count == 0)
            {
                Console.WriteLine("\nВ массиве все числа четные");
            }
        }
        static void task34()
        {
            Random random = new Random();
            double[] arrayOfRealNumbers = new double[random.Next(3, 10)];
            int plus = 0, minus = 0, zero = 0;
            Console.WriteLine("\nВаш массив: ");
            for (int i = 0; i < arrayOfRealNumbers.Length; i++)
            {
                arrayOfRealNumbers[i] = -10 + random.NextDouble() * (10 + 10);
                arrayOfRealNumbers[i] = Math.Round(arrayOfRealNumbers[i], 2);
                Console.Write(arrayOfRealNumbers[i] + "  ");
            }

            for (int i = 0; i < arrayOfRealNumbers.Length; i++)
            {
                if (arrayOfRealNumbers[i] < 0)
                {
                    minus++;
                }
                else if (arrayOfRealNumbers[i] > 0)
                {
                    plus++;
                }
                else if (arrayOfRealNumbers[i] == 0)
                {
                    zero++;
                }
            }
            Console.WriteLine($"\nОтрицательных элементов в массиве: {minus} \nПоложительных элементов в массиве: {plus} \nНулевых элементов в массиве {zero}");
        }
        static void task53()
        {
            Random random = new Random();
            int[] integerArray = new int[random.Next(1, 10)];
            int count = 0;

            for (int i = 0; i < integerArray.Length; i++)
            {
                integerArray[i] = random.Next(0, 5);
                if (integerArray[i] == 0)
                {
                    count++;
                }
            }
            Console.Write("\nВаш полный массив: ");
            for (int i = 0; i < integerArray.Length; i++)
            {
                Console.Write(integerArray[i] + " ");
            }

            Console.WriteLine();

            int[] zeroArray = new int[count];
            int count2 = 0;

            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] == 0)
                {
                    zeroArray[count2] = i;
                    count2++;

                }
            }
            Console.Write("Ваш нулевой массив: ");
            if (zeroArray.Length != 0)
            {
                for (int i = 0; i < zeroArray.Length; i++)
                {
                    Console.Write(zeroArray[i] + " ");
                }
            }
            else
            {
                Console.Write("Таких чисел нет");
            }
        }
        static void task90()
        {
            Random random = new Random();
            int[] arraySequenceOfIntegers = new int[random.Next(2, 15)];
            bool allElementsEqual = true;

            for (int i = 0; i < arraySequenceOfIntegers.Length - 1; i++)
            {
                arraySequenceOfIntegers[i] = random.Next(-20, 20);

            }
            arraySequenceOfIntegers[arraySequenceOfIntegers.Length - 1] = random.Next(-20, 0);

            for (int i = 1; i < arraySequenceOfIntegers.Length; i++)
            {
                if (arraySequenceOfIntegers[i] != arraySequenceOfIntegers[0])
                {
                    allElementsEqual = false;
                    break;
                }

            }
            Console.Write("Ваш массив: ");
            for (int i = 0; i < arraySequenceOfIntegers.Length; i++)
            {
                Console.Write(arraySequenceOfIntegers[i] + " ");
            }
            if (allElementsEqual)
            {
                Console.WriteLine("\nВсе элементы массива равны между собой");
            }
            else
            {
                Console.WriteLine("\nНе все элементы массива равны между собой");
            }
        }
        static void task151()
        {
            Random random = new Random();
            int[] integersArray = new int[random.Next(1, 10)];
            for (int i = 0; i < integersArray.Length; i++)
            {
                integersArray[i] = random.Next(-50, 50);
            }
            Console.Write("Ваш изначальный массив: ");
            for (int i = 0; i < integersArray.Length; i++)
            {
                Console.Write(integersArray[i] + " ");
            }

            Array.Reverse(integersArray);
            Console.Write("\nВаш массив в обратном порядке: ");
            for (int i = 0; i < integersArray.Length; i++)
            {
                Console.Write(integersArray[i] + " ");
            }
        }
    }
}