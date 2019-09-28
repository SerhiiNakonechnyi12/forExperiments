using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
 * Идеи:
 * - метод поиска элемента
 * - Метод замены найденного элемента другим значением
 *
 * 2. Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные (0 считать положительным)
 * Идеи:
 * - Примениь метод сорт
 */

namespace forExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 0, 5, 0, 7, 8, 0, 4, 6 };

            int a = 0;
            Console.WriteLine("Изначальный массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i]);
                Console.Write(" ");
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 0) a++;
                else myArray[i - a] = myArray[i];
            }

            for (int i = myArray.Length - a; i < myArray.Length; i++)
            {
                myArray[i] = -1;
                //Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\n\nИзмененный массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i]);
                Console.Write(" ");
            }
            Console.ReadKey();

            // BinarySearch
            //Console.WriteLine(Array.BinarySearch(myArray, 0));
            //Console.WriteLine(Array.IndexOf(myArray, 0));





            //===============================================

            /*
            int[,] myArray = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {

                    Console.Write(myArray[i, j]);

                }

                Console.WriteLine();
            }
            */
        }
    }
}



