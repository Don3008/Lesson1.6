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
            /* init_radius - радиус окружности, которую мы задаем
             * x_coordinate, y_coordinate - координаты точки, которую нужно проверить
             * distance - расстояние от начала координат до точки (длина вектора)
             * s - сумма квадратов координат
             */
            double x_coordinate, y_coordinate, init_radius, distance;
            Console.Write("Введите радиус \"distance\" вашей окружности: ");
            init_radius = Convert.ToDouble(Console.ReadLine());
            if (init_radius >= 0)
            {
                Console.Write("Введите координату \"x_coordinate\" вашей точки: ");
                x_coordinate = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"y_coordinate\" вашей точки: ");
                y_coordinate = Convert.ToDouble(Console.ReadLine());
                distance = Math.Sqrt(Math.Pow(x_coordinate, 2) + Math.Pow(y_coordinate, 2));
                if (distance > init_radius)
                {
                    Console.WriteLine("Точка с координатами x_coordinate = " + x_coordinate + "; y_coordinate = " + 
                        y_coordinate + " находится за пределами окружности");
                }
                else if (distance == init_radius)
                {
                    Console.WriteLine("Точка с координатами x_coordinate = " + x_coordinate + "; y_coordinate = " + 
                        y_coordinate + " находится на окружности");
                }
                else
                {
                    Console.WriteLine("Точка с координатами x_coordinate = " + x_coordinate + "; y_coordinate = " + 
                        y_coordinate + " находится внутри окружности");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным!");
            }
        }
    }
}
