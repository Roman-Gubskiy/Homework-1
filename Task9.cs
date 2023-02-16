using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Напишите программу расчета объема -V и площади поверхности - S цилиндра.Объем V
            цилиндра радиусом – R и высотой – h, вычисляется по формуле:  𝑉 = 𝜋𝑟 2 ℎ.Площадь S
            поверхности цилиндра вычисляется по формуле: S = 2πR(R + h).Результаты расчетов выведите на   
            экран.Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту
            цилинда.*/

            Console.Write("Введите радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите высту h: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь поверхности цилиндра = " + (2 * Math.PI * R * (h + R)));
            Console.WriteLine("Объем цилиндра = " + (Math.PI * R * R * h));
            Console.ReadKey();           
        }
    }
}
