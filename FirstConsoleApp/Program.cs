using System;

namespace FirstConsoleApp
{
    class Program
    {
        public static double Sinc(double x)
        {
            if (x == 0) return 1;
            return Math.Sin(x) / x; //double.NaN;
        }

        public static double TestFunction(double x)
        {
            return 3 * x * x; // f(x) = 3x^2
        }

        static void Main(string[] args)
        {
            //Console.Write("Введите Xmin >");
            //string x_min_str = Console.ReadLine();
            //double x_min = double.Parse(x_min_str);

            //Console.Write("Введите Xmax >");
            //string x_max_str = Console.ReadLine();
            //double x_max = double.Parse(x_max_str);
            //Console.Write("Введите dx >");
            //string dx_string = Console.ReadLine();
            //double dx = double.Parse(dx_string);

            //FunctionPlotter.PrintTable(x_min, x_max, dx);

            double integral = FunctionPlotter.GetIntegral(0, 1, 0.0001);

            Console.WriteLine("Интеграл равен {0}", integral);

            Console.ReadLine();
        }
    }
}
