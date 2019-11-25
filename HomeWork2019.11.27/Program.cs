using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Threading;

namespace HomeWork2019._11._27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            bool isFinish = false;

            while(true)
            {
                if(isFinish)
                {
                    break;
                }

                Console.Clear();

                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Best Student");
                Console.WriteLine("3.Show Worst Student");
                Console.WriteLine("4.Find Average Mark");
                Console.WriteLine("5.Exit");

                string choice = Console.ReadLine().Trim();
                int choiceInt;

                if (int.TryParse(choice, out choiceInt))
                {
                    Console.Clear();

                    switch (choiceInt)
                    {
                        case 1:
                            StudentService.AddStudent(students);
                            break;
                        case 2:
                            StudentService.ShowStudent(StudentService.FindBestStudent(students));
                            Console.ReadKey();
                            break;
                        case 3:
                            StudentService.ShowStudent(StudentService.FindWorstStudent(students));
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine($"Average Mark: {StudentService.FindAverageMark(students)}");
                            Console.ReadKey();
                            break;
                        case 5:
                            isFinish = true;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Сделайте правильный выбор");
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
