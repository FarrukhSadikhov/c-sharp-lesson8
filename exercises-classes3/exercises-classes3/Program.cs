using System;

namespace exercises_classes3
{
    class Program
    {
        static int CheckNumber()
        {
            int a, b;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out a))
                { return a;
                }
                else
                { Console.WriteLine("Ошибка!!!Введите сторону трекгольника корректно");
                }
                if (Int32.TryParse(Console.ReadLine(), out b))
                {

                    return b;
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
            /*3.Создать класс Rectangle, разработав следующие элементы класса:
            Поля:
            int a, b;
            Конструктор, позволяющий создать экземпляр класса с заданными длинами сторон.
            Методы, позволяющие:
            вывести длины сторон прямоугольника на экран;
            рассчитать периметр прямоугольника;
            рассчитать площадь прямоугольника.
            Свойства:
            получить - установить длины сторон прямоугольника(доступное для чтения и записи);
            позволяющее установить, является ли данный прямоугольник квадратом(доступное только для чтения).*/
           int a = 0, b = 0;
            Rectangle rectangles;
            do
            {
                Console.WriteLine("Введите стороны прямоугольника:");
                a = CheckNumber();
                b = CheckNumber();
                rectangles = new Rectangle(a, b);
                if (!(a > 0 && b > 0))
                {
                    Console.WriteLine("Введенно не верно");
                }
                if (rectangles.Exists)
                {
                    Console.WriteLine("Вы ввели стороны квaдрата!");
                }
            } while (!(a > 0 && b > 0));
                rectangles.Display();
                rectangles.Perimetr();
                rectangles.Square();       
            Console.ReadKey();
        }
    }
}
