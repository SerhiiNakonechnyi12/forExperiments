using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forExperiments
{    
    static void Main(string[] args)
    { 
        enum DistanceSun : ulong
        {
            Sun = 0, Mercury = 57900000, Venus = 108200000,
            Earth = 149600000,
            Mars = 227900000, Jupiter = 7783000000,
            Saturn = 1427000000,
            Uranus = 2870000000, Neptune = 4496000000,
            Pluto = 5946000000
        }
    class Program
    {
        static void Main(string[] args)
        {
            string moon = "Moon";
            //проверка наличия константы в заданном перечислении
            if (!Enum.IsDefined(typeof(DistanceSun), moon))
            {
                Console.WriteLine($"\tЗначения {moon} нет в перечислении DistanceSun.");
            }
            Console.WriteLine("\n\tФорматированный выводвсех значений констант указанного перечисления.");
            foreach (DistanceSun item in Enum.
            GetValues(typeof(DistanceSun)))
            {
                Console.WriteLine("{0,-10} {1,-10} {2,20}",
                //вывод в виде строки с именем константы
                Enum.Format(typeof(DistanceSun), item, "G"),
                //вывод в виде десятичного значения
                Enum.Format(typeof(DistanceSun), item, "D"),
                //вывод в виде 16-ричного значения
                Enum.Format(typeof(DistanceSun), item, "X"));
            }
            Console.WriteLine("\n\tВсе значения констант указанного перечисления.");
            foreach (string str in Enum.
            GetNames(typeof(DistanceSun)))
            {
                Console.WriteLine(str);
            }
            ulong number = 227900000;
            Console.WriteLine($"\n\tИмя константы со значением { number} из указанного перечисления.\n");
            Console.WriteLine(Enum.GetName(typeof(DistanceSun), number));
            Console.WriteLine(Enum.GetName(typeof(DistanceSun), number));
        }
    }    
}
