using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.                                  
            Создать программу для определения гипотенузы прямоугольного треугольника, 
            используя формулу с  =  √𝑎2  + 𝑏 2 , где с – гипотенуза, а b и a катеты прямоугольного 
            треугольника. Ввод катетов должен осуществлять пользователь*/

            double katat_A, katet_B, hypotenuse;
            Console.Write("ВВедите катет (a): ");
            katat_A = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите катет (b): ");
            katet_B = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(katat_A, 2) + Math.Pow(katet_B, 2));
            Console.WriteLine("Hypotenuse: " + hypotenuse);
            Console.ReadKey();
        }
    }
}
