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

        public static void PrintTable(Func<double, double> f, double Xmin, double Xmax, double dx)
        {
            double x = Xmin;

            Console.WriteLine("    x    |     y");
            Console.WriteLine("-----------------------");
            while (x < Xmax)
            {
                double y = f(x);

                Console.WriteLine($"{x,8:f3} | {y,7:f5}");

                x += dx;
            }
        }

        public static double GetIntegral(double a, double b, double dx)
        {
            double s = 0;

            double x = a;

            while (x < b)
            {
                double y = Program.TestFunction(x);
                double ds = y * dx;

                x = x + dx;
                s += ds;
            }

            return s;
        }

        public static double GetIntegral(Func<double, double> f, double a, double b, double dx)
        {
            //Func<string, int> get_length;

            double s = 0;

            double x = a;

            while (x < b)
            {
                double y = f(x);
                double ds = y * dx;

                x = x + dx;
                s += ds;
            }

            return s;
        }
    }
}
