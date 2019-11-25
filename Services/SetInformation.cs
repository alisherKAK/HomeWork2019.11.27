using System;
using System.Linq;

namespace Services
{
    public static class SetInformation
    {
        public static string SetName()
        {
            do
            {
                try
                {
                    Console.WriteLine("Введите имя:");

                    string name = Console.ReadLine().Trim();

                    if(name.Any(letter => (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z')))
                    {
                        return name; 
                    }

                    throw new ArgumentException("Имя было введено неверно");
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } while (true);
        }

        public static double SetAverageMark()
        {
            do
            {
                Console.WriteLine("Введите средную оценку:");

                string avgMarkString = Console.ReadLine().Trim();
                double avgMark;

                if(double.TryParse(avgMarkString, out avgMark))
                {
                    return avgMark;
                }

                Console.WriteLine("Средняя оценка была введена неверно");
            } while (true);
        }
    }
}
