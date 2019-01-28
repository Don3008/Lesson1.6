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
            /* initRadius - радиус окружности, которую мы задаем
             * coordinateX, coordinateY - координаты точки, которую нужно проверить
             * distance - расстояние от начала координат до точки (длина вектора)
             * s - сумма квадратов координат
             */
            double coordinateX, coordinateY, initRadius, distance;
            Console.Write("Введите радиус вашей окружности: ");
            initRadius = Convert.ToDouble(Console.ReadLine());
            if (initRadius >= 0)
            {
                Console.Write("Введите координату \"x\" вашей точки: ");
                coordinateX = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату \"y\" вашей точки: ");
                coordinateY = Convert.ToDouble(Console.ReadLine());
                distance = Math.Sqrt(Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2));
                if (distance > initRadius)
                {
                    Console.WriteLine("Точка с координатами coordinateX = " + coordinateX + "; coordinateY = " + 
                        coordinateY + " находится за пределами окружности");
                }
                else if (distance == initRadius)
                {
                    Console.WriteLine("Точка с координатами coordinateX = " + coordinateX + "; coordinateY = " + 
                        coordinateY + " находится на окружности");
                }
                else
                {
                    Console.WriteLine("Точка с координатами coordinateX = " + coordinateX + "; coordinateY = " + 
                        coordinateY + " находится внутри окружности");
                }
            }
            else
            {
                Console.WriteLine("Радиус должен быть положительным!");
            }
        }
    }
}
