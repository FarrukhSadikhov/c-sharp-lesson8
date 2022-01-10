using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace exercises_classes1
{
    class Point
    {
        //Поля:
        int x;
        int y;
        //Конструктор с нулевыми координатами
        public Point() { }
        //Конструктор с заданными координатами
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Свойства:получить - установить координаты точки(доступное для чтений и записи)
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                x = value;
            }
        }
        //Свойства:позволяющие умножить координаты точки на скаляр(доступное только для записи).
        public int Scalar
        {
            set
            {
                x = x * value;
                y = y * value;
            }
        }
        //вывести координаты точки на экран
        public void Coordinates()
        {
            Console.WriteLine($"Координаты точки:  {x} ; {y}");
        }
        //рассчитать расстояние от начала координат до точки
        public double Сomputation()
        {
            double result = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine($"Расстояние от начала координат до точки: {result}");
            return result;
        }
        //переместить точку на плоскости на вектор(a, b).
        public void Vector(int a,int b)
        {          
           x += a;
           y += b;
        }
    }
}
