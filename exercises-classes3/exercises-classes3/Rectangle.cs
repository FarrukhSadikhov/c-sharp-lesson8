using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_classes3
{
    class Rectangle
    {
       /* Поля: int a, b;*/
        int a, b;
       
        //Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
        public Rectangle (int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        //Свойства: получить - установить длины сторон прямоугольника(доступное для чтения и записи);
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
        //Свойства: позволяющее установить, является ли данный прямоугольник квадратом(доступное только для чтения).
        public bool Exists
        {
            get
            {
                if (a == b)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //вывести длины сторон прямоугольника на экран;
        public void Display()
        {
            Console.WriteLine($"Длины сторон : {a} ; {b}");
        }
        //рассчитать периметр прямоугольника;
        public void Perimetr()
        {
            int p = a + a + b + b;
            Console.WriteLine($"периметр : {p}");
        }
        //рассчитать площадь прямоугольника.
        public void Square()
        {
            int s = a * b;
            Console.WriteLine($"площадь : {s}");
        }
    }
}
