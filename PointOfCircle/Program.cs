using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            /* R0 - радиус окружности, которую мы задаем
             * x, y - координаты точки, которую нужно проверить
             * R - расстояние от начала координат до точки (длина вектора)
             * s - сумма квадратов координат
             */
            double x, y, R0, R, s;
            Console.Write("Введите радиус \"R\" вашей окружности: ");
            R0 = Convert.ToDouble(Console.ReadLine());
            if (R0 >= 0)
            {
                Console.Write("Введите координату \"x\" вашей точки: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"y\" вашей точки: ");
                y = Convert.ToDouble(Console.ReadLine());
                s = Math.Pow(x, 2) + Math.Pow(y, 2);
                R = Math.Sqrt(s);
                if (R > R0)
                {
                    Console.WriteLine("Точка с координатами x = " + x + "; y = " + y + " находится за пределами окружности");
                }
                else if (R == R0)
                {
                    Console.WriteLine("Точка с координатами x = " + x + "; y = " + y + " находится на окружности");
                }
                else
                {
                    Console.WriteLine("Точка с координатами x = " + x + "; y = " + y + " находится внутри окружности");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным!");
            }
        }
    }
}
