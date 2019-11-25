using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu;

            var group = new Group();
            group.DataInit();

            while (true)
            {
                Console.WriteLine("\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\n\t\tГлавное меню:\n");
                Console.WriteLine("\t1 - Ввод данных по студентам");
                Console.WriteLine("\t2 - Лучший студент по успеваемости");
                Console.WriteLine("\t3 - Худший студент по успеваемости");
                Console.WriteLine("\t4 - Общая средняя оценка по группе");
                Console.WriteLine("\t5 - Список студентов с оценками");
                Console.WriteLine("\t0 - Выход\n");
                Console.Write("\tВаш выбор = ");
                menu = Console.ReadLine();

                if (menu == "0")
                {
                    break;
                }

                else if (menu == "1")   // Ввод данных по студентам
                {
                    group.DataInput();
                }
                else if (menu == "2")   // Лучший студент по успеваемости
                {
                    group.Best();
                }

                else if (menu == "3")   // Худший студент по успеваемости
                {
                    group.Worst();
                }

                else if (menu == "4")   // Общая средняя оценка по группе
                {
                    group.Average();
                }

                else if (menu == "5")   // Список студентов с оценками
                {
                    group.List();
                }

            }

        }
    }
}
