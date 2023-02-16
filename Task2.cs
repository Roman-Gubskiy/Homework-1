using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                  
            Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r. 
            Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.*/

            const double pi = Math.PI;
            Console.Write("Введите радиус: ");
            double r = double.Parse(Console.ReadLine());
            double area = (pi * Math.Pow(r, 2));
            Console.Write("Площадь круга: ");
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
