using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Group
    {
        private List<Student> students;

        public Group()
        {
            students = new List<Student>();
        }

        public void DataInit()
        {
            students.AddRange(new List<Student> {
                new Student { Name = "Иван", Mark = 4.5 },
                new Student { Name = "Пётр", Mark = 5.0 },
                new Student { Name = "Сергей", Mark = 4.1 },
                new Student { Name = "Александра", Mark = 4.5 },
                new Student { Name = "Марина", Mark = 4.2 },
                new Student { Name = "Наталья", Mark = 4.8 },
                new Student { Name = "Михаил", Mark = 4.7 }
            });
        }

        public void DataInput()
        {
            string name, markstr;
            double markdbl;

            Console.WriteLine("\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\tДобавление новой записи по студенту");

            while (true)
            {
                Console.Write("\n\tИмя студента (ПУСТО - закончить ввод) = ");
                name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                markdbl = 0;
                while (true)
                {
                    Console.Write("\tСредняя оценка (ПУСТО - закончить ввод) = ");
                    markstr = Console.ReadLine();

                    if (markstr == "")
                    {
                        break;
                    }
                    try
                    {
                        markdbl = Convert.ToDouble(markstr);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\n\tВведите число!\n\tДля разделения целой и дробной частей используйте запятую!\n");
                    }

                }
                if (markstr =="")
                {
                    break;
                }

                students.Add(new Student { Name = name, Mark = markdbl });
            }

        }

        public void Best()
        {
            Seek(true, "Лучший", "Лучшие");
        }

        public void Worst()
        {
            Seek(false, "Худший", "Худшие");
        }

        private void Seek(bool bestStudent, string titleOne, string titleMany)
        {
            double markResult;
            int count;
            string title;
            Console.WriteLine("\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            if (students.Count == 0)
            {
                Console.WriteLine("\n\tСписок студентов пуст!");
                return;
            }

            // markResult - лучшая или худшая оценка по всему списку
            markResult = 0;
            if (bestStudent == true)
            {
                markResult = students.Max(x => x.Mark);
            }
            else
            {
                markResult = students.Min(x => x.Mark);
            }
            // количество записей с оценкой = markResult
            count = students.Where(x => x.Mark == markResult).Count();

            title = "";
            if (count == 1)  // с оценкой markResult один студент в списке
            {
                title = titleOne + " студент";
            }
            else  // с оценкой markResult более одного студента в списке
            {
                title = titleMany + " студенты";
            }

            Console.WriteLine("\n\t" + title + " по успеваемости\n");
            foreach (Student student in students)
            {
                if (student.Mark == markResult)
                {
                    Console.WriteLine("\t" + student.Name + " - " + student.Mark.ToString());
                }
            }
        }

        public void Average()
        {
            double sum, avg;
            Console.WriteLine("\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            if (students.Count == 0)
            {
                Console.WriteLine("\n\tСписок студентов пуст!");
                return;
            }

            sum = 0;
            foreach (Student student in students)
            {
                sum += student.Mark;
            }

            avg = sum / students.Count;

            Console.WriteLine("\n\tОбщая средняя оценка по группе = " + avg.ToString());
        }

        public void List()
        {
            Console.WriteLine("\n\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n\tСписок студентов с оценками\n");

            if (students.Count == 0)
            {
                Console.WriteLine("\n\tСписок студентов пуст!");
                return;
            }
            foreach (Student student in students)
            {
                Console.WriteLine("\t" + student.Name + " - " + student.Mark.ToString());
            }
        }
    }

}