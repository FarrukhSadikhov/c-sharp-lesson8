using System;

namespace exercises_classes1
{
    class Program
    {
        static int CheckNumber()
        {  int a;
            do
            { 
                if (Int32.TryParse(Console.ReadLine(), out  a))
                {
                    return a;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректное значение");
                }
            }
            while (true);
        } 
        static void Main(string[] args)
        {
          /*  1.Создать класс Point, разработав следующие элементы класса:
            Поля:
            int x, y;
            Конструкторы, позволяющие создать экземпляр класса:
            с нулевыми координатами;
            с заданными координатами.
            Методы, позволяющие:
            вывести координаты точки на экран;
            рассчитать расстояние от начала координат до точки;
            переместить точку на плоскости на вектор(a, b).
            Свойства:
            получить - установить координаты точки(доступное для чтений и записи);
            позволяющие умножить координаты точки на скаляр(доступное только для записи).*/
            Point point = new Point();
            point.Coordinates();
            Console.WriteLine("Введите точки координаты: ");
            int number1 = CheckNumber();
            int number2 = CheckNumber();           
            Point pointNew = new Point(number1,number2);
            pointNew.Coordinates();
            pointNew.Сomputation();
            Console.WriteLine("Введите точки координат для перемещения вектора: ");
            int vector1 = CheckNumber();
            int vector2 = CheckNumber();
            pointNew.Vector(vector1, vector2);
            Console.WriteLine("Точки вектора измененны: ");
            pointNew.Coordinates();
            Console.WriteLine("Введите число скаляра");
            int s = CheckNumber();
            Console.WriteLine("Точки вектора измененны. Точки скаляр доступное только для записи.");
            pointNew.Scalar =  s;            
            Console.Read();
        }
    }
}
