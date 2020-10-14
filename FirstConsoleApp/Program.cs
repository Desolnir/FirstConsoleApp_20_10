using System;
using System.IO;
using System.Threading;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

             Многострочный комментарий

             */

            Console.Write("Введите своё имя >"); // Вывод текста на экран без переноса каретки
            // Console.WriteLine("Введите своё имя >");

            //string str;
            //str = "123";
            string name = Console.ReadLine();

            Console.WriteLine("Введено имя " + name);

            string str = "Hello World!";
            int i32 = 42; // 4 байта со знаком

            Console.WriteLine("Минимум int " + int.MinValue);
            Console.WriteLine("Максимум int " + int.MaxValue);

            long i64 = 13; // 8 байт со знаком
            short i16 = 0; // 4 байта со знаком
            byte i8 = 255; // 1 байт без(!) знака

            uint ui32 = 4; // 4 байта без знака
            ulong ui64;
            ushort ui16;
            sbyte si8; // 1 байт со знаком -128..127

            double d64 = 3.14159265358979; // 8 байт - двойная точность
            short d32 = (short)3.14; // 4 байта
            decimal dc = 3.14m; // для финансовой сферы, либо для точных научных вычислений

            bool b_true = true;
            bool b_false = false;

            bool is_true = d64 > 3.14;
            bool is_true2 = d64 < 3.14;
            bool is_true3 = d64 >= 3.14;
            bool is_true4 = d64 <= 3.14;
            bool is_true5 = d64 == 3.14;
            bool is_true6 = d64 != 3.14;

            bool is_true7 = !(b_true == b_false);

            bool is_false = !b_true;
            

            string str2 = "123";

            char c1 = str2[0];
            char c2 = '2';

            int[] ints = new int[10];
            //delete ints;

            // i++; // i = i + 1;
            // i--; // i = i - 1;
            // i+=5;// i = i + 5;
            // i-=5;
            // i*=5;
            // i/=5; // i = i / 5;

            for (int i = 0; i < 10; i++) // i++; - увеличение на 1 значения переменной 
            {
                ints[i] = i * 10;
            }


            string[] strings = new string[10];
            strings[0] = "123";
            strings[5] = "QWE";


            for (int i = 0; i < ints.Length; i++)
            {

            }

            int iterator = 0;
            while (iterator < ints.Length)
            {
                ints[iterator] = iterator - 100;
                iterator++;
            }

            iterator = 0;
            do
            {
                ints[iterator] = iterator + 100;
                iterator++;
            }
            while (iterator < ints.Length);

            iterator = 0;
            foreach (int value in ints)
            {
                Console.WriteLine(value);
                iterator++;
            }

            if (ints.Length > 5)
            {

            }


            if (ints.Length > 3)
            {

            }
            else
            {

            }

            if (ints.Length > 0)
            {

            }
            else if (ints.Length > 4)
            {

            }
            else if(str == "Hello World!")
            {
                
            }

            if (ints.Length > 0)
            {

            }
            else
            {
                if (ints.Length > 4)
                {

                }
                else
                {
                    if (str == "Hello World!")
                    {

                    }
                }
            }

            double pi = 3.1415;
            int int_pi = (int)pi;
            int int_pi2 = (int) 3.1415;

            pi = int_pi;

            string string_int_value = "123";

            //int value123 = (int)string_int_value; // Невозможно

            int value123 = int.Parse(string_int_value);
            double pi_from_str = double.Parse("3,1415");

            Console.Write("Введите значение x >");
            string x_str = Console.ReadLine();

            int x = int.Parse(x_str);

            Console.WriteLine("Было введено значение x = " + x);

            Console.ReadLine();
        }
    }
}
