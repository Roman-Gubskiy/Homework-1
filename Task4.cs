using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                  
            Создать программу для определения синуса угла, ввод угла должен осуществлять 
            пользователь.*/

            Console.Write("Введите число для определение синуса угла: ");
            double angle = double.Parse(Console.ReadLine());
            double b = (angle * (Math.PI)) / 180;
            Console.Write("Синус угла: " + Math.Sin(b));
            Console.ReadKey();
        }
    }
}
