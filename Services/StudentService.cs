using Models;
using System;
using System.Collections.Generic;

namespace Services
{
    public static class StudentService
    {
        public static void ShowStudent(Student student)
        {
            Console.WriteLine($"Имя: {student.Name}");
            Console.WriteLine($"Средняя оценка: {student.AvgerageMark}");
        }

        public static Student FindBestStudent(List<Student> students)
        {
            Student bestStudent = students[0];

            foreach(Student student in students)
            {
                if(student.AvgerageMark > bestStudent.AvgerageMark)
                {
                    bestStudent = student;
                }
            }

            return bestStudent;
        }

        public static Student FindWorstStudent(List<Student> students)
        {
            Student worstStudent = students[0];

            foreach (Student student in students)
            {
                if (student.AvgerageMark < worstStudent.AvgerageMark)
                {
                    worstStudent = student;
                }
            }

            return worstStudent;
        }

        public static double FindAverageMark(List<Student> students)
        {
            double sum = 0;

            foreach(Student student in students)
            {
                sum += student.AvgerageMark;
            }

            return sum / students.Count;
        }

        public static void AddStudent(List<Student> students)
        {
            Student newStudent = new Student()
            {
                Name = SetInformation.SetName(),
                AvgerageMark = SetInformation.SetAverageMark()
            };

            students.Add(newStudent);
        }
    }
}
