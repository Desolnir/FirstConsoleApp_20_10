using System;

namespace FirstConsoleApp
{
    class Program
    {
        static double Sinc(double x)
        {
            if (x == 0) return 1;
            return Math.Sin(x) / x; //double.NaN;
        }



        static void Main(string[] args)
        {
            Console.Write("Введите Xmin >");
            string x_min_str = Console.ReadLine();
            double x_min = double.Parse(x_min_str);

            Console.Write("Введите Xmax >");
            string x_max_str = Console.ReadLine();
            double x_max = double.Parse(x_max_str);

            Console.Write("Введите dx >");
            string dx_string = Console.ReadLine();
            double dx = double.Parse(dx_string);

            double x = x_min;

            Console.WriteLine("    x    |     y");
            Console.WriteLine("-----------------------");
            while (x < x_max)
            {
                double y = Sinc(x);

                //Console.Write(x);
                //Console.Write("  |  ");
                //Console.Write(y);

                //Console.WriteLine();s

                //Console.WriteLine(x + "  |  " + y);
                //Console.WriteLine("{0:f3}  |  {1:f5}", x, y);
                Console.WriteLine($"{x,8:f3} | {y,7:f5}");

                x += dx;
            }

            Console.ReadLine();
        }
    }
}
