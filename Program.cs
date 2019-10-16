using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание (начальное):
1.	Объявить одномерный (5 элементов ) массив с именем A //+
и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. //+
 Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, //+
 а двумерный массив В случайными числами с помощью циклов.//+
 Вывести на экран значения массивов: массива А в одну  строку, //+
 массива В – в виде матрицы. //+
Найти в данных массивах 
- общий максимальный элемент,//+ 
- минимальный элемент,// 
- общую сумму всех элементов, 
- общее произведение всех элементов, 
- сумму четных элементов массива А, 
- сумму нечетных столбцов массива В. 
 */


namespace forExperiments
{
    class bus
    {
        string number;//номер автобуса
        string name;//имя водителя
        int route;//номер маршрута 
        int number_seats;// количество мест 
        string color;// цвет автобуса 
        public static int count;

        //bus(string number, string name, int route, int number_seats, string color)

        //{ this.number = number; this.name = name; this.route = route; this.number_seats = number_seats; this.color = color; }
        static bus()
        { count = 0; }
        public bus(string number_1, string name_1, int route_1, int number_seats_1) : this(number_1, name_1, route_1, number_seats_1, "black")
        {
            number = number_1;
            name = name_1;
            route = route_1;
            number_seats = number_seats_1;/* count++; */
        }
        public bus(string number_1, string name_1, int route_1, string color_1) : this(number_1, name_1, route_1, 18, color_1)
        {
            number = number_1;
            name = name_1;
            route = route_1;
            color = color_1; /*count++;*/
        }

        public bus(string number_1, string name_1, int route_1) : this(number_1, name_1, route_1, 18, "black")

        {
            number = number_1;
            name = name_1;
            route = route_1;/* count++;*/ }
        public bus(string number, string name, int route, int number_seats, string color)

        {
            this.number = number; this.name = name; this.route = route; this.number_seats = number_seats; this.color = color; count++;
        }
        public bus()

        { number = ""; name = ""; route = 0; number_seats = 0; color = ""; count++; }
        public void Show_bus()
        {
            Console.WriteLine("номер автобуса " + number);
            Console.WriteLine("имя водителя " + name);
            Console.WriteLine("номер маршрута " + route);
            Console.WriteLine("количество мест " + number_seats);
            Console.WriteLine("цвет автобуса " + color);
            Console.WriteLine();
        }


        public string Number { get { return number; } set { number = value; } }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Route
        {
            get { return route; }
            set { route = value; }
        }
        public int Number_seats
        {
            get { return number_seats; }
            set { number_seats = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }


    }
    class ДЗ
    {
        static void Main(string[] args)
        {
            //Если цвет автомобуса не указан, он регестрируеться как черный;
            // Если количество мест автобуса не указано, в реестр записываеться 18 мест
            bus A = new bus("AF1582", "Андрей Гончаренко", 3);
            bus B = new bus("KL122", "Михаил Артемов", 323, 25, "белый");
            bus C = new bus("MB6542", "Георгий Вертинский", 59, "синий");
            bus K = new bus("LK563", "Артем Белый", 45, "красный");
            bus D = new bus("IK638", "Марат Федоров", 203, 56, "черный");
            int x = 0;
            int n = 1, k = 0;
            bus[] arry = new bus[n];
            while (x != 4)
            {
                Console.WriteLine("Aвтообусный парк");
                Console.WriteLine("Для получения информации о количестве машин в автопарке -1");
                Console.WriteLine("Для регистрации нового автобуса -2");
                Console.WriteLine("Для получения информации о всех автобусах парка  -3");
                Console.WriteLine("Для выхода  -4");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 1) { Console.WriteLine("Количество машин  " + bus.count); }
                //int n =1,k=0;
                //bus[] arry = new bus[n];
                if (x == 2)
                {
                    Console.WriteLine("Введите количество новых автобусов");
                    k = Convert.ToInt32(Console.ReadLine());
                    //int t = 5 + n;
                    //bus[] arry = new bus[n];
                    for (int i = 0; i < k; i++)
                    {
                        arry[i] = new bus();
                        Console.WriteLine("Введите имя водителя №" + i);
                        arry[i].Name = Console.ReadLine();
                        Console.WriteLine("Введите номер автомобиля№" + i);
                        arry[i].Number = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите номер маршрута №" + i);
                        arry[i].Route = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите количество мест №" + i);
                        arry[i].Number_seats = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите цвет  автомобиля №" + i);
                        arry[i].Color = Convert.ToString(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine();
                        n++;
                        Array.Resize(ref arry, n);

                    }
                }

                if (x == 3)
                {
                    Console.WriteLine("Вывод данных ");
                    A.Show_bus(); C.Show_bus(); K.Show_bus(); D.Show_bus(); B.Show_bus();


                    for (int i = 0; i < k; i++)
                    {
                        arry[i].Show_bus();
                    }
                }


            }

            Console.WriteLine();
        }
    }
}




