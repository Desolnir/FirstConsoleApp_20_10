using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    class FunctionPlotter
    {
        //public    // открывает доступ для всех
        //private   // скрывает от всех 
        //internal  // открывает доступ для всех внутри текущего проекта
        //protected // открывает доступ только для наследников класса

        public static void PrintTable(double Xmin, double Xmax, double dx)
        {
            double x = Xmin;

            Console.WriteLine("    x    |     y");
            Console.WriteLine("-----------------------");
            while (x < Xmax)
            {
                double y = Program.Sinc(x);

                Console.WriteLine($"{x,8:f3} | {y,7:f5}");

                x += dx;
            }
        }
    }
}
