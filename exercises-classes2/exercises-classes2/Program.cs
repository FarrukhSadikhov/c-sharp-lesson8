using System;

namespace exercises_classes2
{
    class Program
    {
        static int CheckNumber()
        {
            int x;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                {

                    return x;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите сторону трекгольника корректно");
                }       
            }
            while (true);
        }
        static void Main(string[] args)
        {
            /*2.Создать класс Triangle, разработав следующие элементы класса:
            Поля:
            int a, b, c;
            Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
            Методы, позволяющие:
            вывести длины сторон треугольника на экран;
            рассчитать периметр треугольника;
            рассчитать площадь треугольника.
            Свойства:
            позволяющее получить-установить длины сторон треугольника(доступное для чтения и записи);
            позволяющее установить, существует ли треугольник с данными длинами сторон(доступное только для чтения).*/
            bool f;
            int a=0, b=0, c=0;
            Triangle triangles;
            do {
                Console.WriteLine("Введите стороны треугольника:");
                Console.Write("1 сторона треугольника: ");
                a = CheckNumber();
                Console.Write("2 сторона треугольника: ");
                b = CheckNumber();
                Console.Write("3 сторона треугольника: ");
                c = CheckNumber();
                triangles = new Triangle(a, b, c);
                f = triangles.Exists;
                if (f == false)
                {
                    Console.WriteLine("Введите правильные параметры треугольника!");                  
                }
            } while (!(f== true&& a>0 &&b>0 && c>0));                           
            triangles.Display();
            triangles.Perimetr();
            triangles.Square();            
            Console.Read();           
        }
    }
}
