using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Написать программу для расчета скидки за покупку, скидку и цену товара должен 
            осуществлять пользователь.*/

            Console.Write("Введите размер скилки (%): ");
            int discount = int.Parse(Console.ReadLine());
            Console.Write("Введите цену товара (UAH): ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Скидка составляет: " + (price * discount / 100) + " UAH");
            Console.ReadKey();
        }
    }
}
