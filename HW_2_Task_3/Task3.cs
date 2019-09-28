using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число встречается в массиве.
 */

namespace HW_2_Task_3
{
    class Task3
    {
        
        static void Main(string[] args)
        {
            int a;
            int b = 0;

            int[] myArray = new int[] { 1, 2, 3, 0, 7, 2, 7, 5, 0, 7, 8, 0, 4, 6 };

            Console.WriteLine("Изначальный массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.Write(myArray[i]);
                Console.Write(" ");
            }

            Console.WriteLine("\nВведите число для поиска в массиве: ");            
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(myArray.Contains(a));
            for (int i = 0; i < myArray.Length; i++)
            {
                b++;
                Console.WriteLine("Повторений: ", b);
            }

            //Array.Find(myArray.Count(a));
            



        }
    }
}
