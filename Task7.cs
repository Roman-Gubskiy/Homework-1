using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Windows Forms (.Net framework). 
            оздайте программу для расчета возраста пользователя, по введенному им году рождения 
            необходимо вывести его текущий возраст. (использовать DateTime).*/

            Console.Write("Введите Ваш год рождения: ");
            int YearOfBirth = int.Parse(Console.ReadLine());
            DateTime year = DateTime.Now;
            Console.WriteLine("Сейчас Вам: " + (year.Year - YearOfBirth) + " лет.");
            Console.ReadKey();
        }
    }
}
