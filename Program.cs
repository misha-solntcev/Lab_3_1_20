using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  20. Написать программу, которая подсчитывает произведение 
    целых чисел введенных с клавиатуры. Произведение 
    подсчитывается до тех пор, пока вводятся числа 
    в интервале от –10 до +10. */

namespace Lab_3_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число b: ");
                int b = int.Parse(Console.ReadLine());

                if ((a >= -10 && a <= 10) && (b >= -10 && b <= 10))
                    Console.WriteLine("Произведение a*b = " + a * b);
                else                    
                    break;                    
            }
            Console.WriteLine("Вы ввели число вне заданного диапазона. Exit.");
            Console.ReadKey();
        }
    }
}
