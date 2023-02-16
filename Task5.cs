using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Создайте две целочисленные переменные и выведите на экран результаты всех арифметических 
            операций над этими двумя переменными.*/

            Console.WriteLine("Для выводы арифметических операций: +, -, *, /, %,");
            Console.Write("Введите первое целочисленное число: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.Write("Введите ворое целочисленное число: ");
            int numTwo = int.Parse(Console.ReadLine());
            int a = numOne + numTwo;
            int b = numOne - numTwo;
            int c = numOne * numTwo;
            int d = numOne / numTwo;
            int e = numOne % numTwo;
            Console.WriteLine(numOne + " + " + numTwo + " = " + a);
            Console.WriteLine(numOne + " - " + numTwo + " = " + b);
            Console.WriteLine(numOne + " * " + numTwo + " = " + c);
            Console.WriteLine(numOne + " / " + numTwo + " = " + d);
            Console.WriteLine(numOne + " % " + numTwo + " = " + e);
            Console.ReadKey();
        }
    }
}
