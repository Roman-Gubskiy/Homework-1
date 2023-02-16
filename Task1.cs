using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                  
            Создайте программу для перевода метров в сантиметры(1м = 100см), ввод метров должен
            осуществлять пользователь.*/

            Console.Write("Введите количество метров (м.) для для получения сантиметров (см.): ");
            double numberMeters = double.Parse(Console.ReadLine());
            double numberCentimeters = numberMeters * 100;
            Console.Write("Количество (см.) в " + numberMeters + "(м.) равно: " + numberCentimeters + "см.");
            Console.ReadKey();
        }
    }
}
