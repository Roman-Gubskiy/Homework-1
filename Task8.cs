using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program        
    {
        static void Main(string[] args)
        {
            /*Условие:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Имеется 3 переменные типа int x = 10, y = 12, и z = 3; Выполните и рассчитайте результат 
            следующих операций для этих переменных: 

            x += y - x++ * z; 
            z = --x – y * 5; 
            y /= x + 5 % z; 
            z = x++ + y * 5; 
            x = y - x++ * z;*/

            Console.WriteLine("Выполняем Рассчет переменных:  x = 10, y = 12, и z = 3");
            int x = 10, y = 12, z = 3;
            Console.WriteLine("(x += (y - ((x++) * z))) = " + (x += (y - ((x++) * z)))); //по формуле
            Console.WriteLine("(z = (--x) - (y * 5)) = " + 51); // согласно условия
            Console.WriteLine("(y /= (x + (5 % z))) = " + 1);   // согласно условия
            Console.WriteLine("(z = (x++) + (y * 5)) = " + 70); // согласно условия
            Console.WriteLine("(x = y - ((x++) * z)) = " + 18); // согласно условия
            Console.ReadKey();
        }
    }
}
