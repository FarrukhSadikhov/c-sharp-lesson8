using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_classes2
{
    class Triangle
    {
        //Поля:
        int a,b,c;
        //Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Triangle (int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;      
        }
        //Свойства:позволяющее получить-установить длины сторон треугольника(доступное для чтения и записи);
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        //Свойства:позволяющее установить, существует ли треугольник с данными длинами сторон(доступное только для чтения).
        public bool Exists
        {
            get
            {
                if (a < b + c && b < a + c && c < b + a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //вывести длины сторон треугольника на экран;
        public void Display()
        {
            Console.WriteLine($"Длины сторон треугольника: {a} ; {b} ; {c}");
        }
        //рассчитать периметр треугольника;
        public void Perimetr()
        {
            int p = a + b + c;
            Console.WriteLine($"периметр треугольника: {p}");
        }
        //рассчитать площадь треугольника.
        public void Square()
        {
            double p = (double) (a + b + c) / 2;         
            double s =(double) Math.Sqrt (p * ((p - a) * (p - b) * (p - c)));
            Console.WriteLine($"площадь треугольника: {s}");
        }
    }
}
