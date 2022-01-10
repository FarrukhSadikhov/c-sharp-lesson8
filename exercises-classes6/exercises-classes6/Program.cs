using System;

namespace exercises_classes6
{
    class Program
    {
        static double CheckDouble()
        {

            double x;
            do
            {
                if (Double.TryParse(Console.ReadLine(), out x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }
            static int CheckNumber()
            {
                int n, m;
                do
                {
                    if (Int32.TryParse(Console.ReadLine(), out n))
                    {
                        return n;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!Введите корректные данные");
                    }
                    if (Int32.TryParse(Console.ReadLine(), out m))
                    {

                        return m;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!Введите корректные данные");
                    }
                }while (true);
            }       
            static void Main(string[] args)
            {
                /*6.Создать класс для работы с двумерным массивом вещественных чисел. Разработать следующие элементы класса:
                Поля:
                double[][] DoubelArray;
                int n, m.
                Конструктор, позволяющий создать массив размерности n×m.
                Методы, позволяющие:
                ввести элементы массива с клавиатуры;
                вывести элементы массива на экран;
                отсортировать элементы каждой строки массива в порядке убывания.
                Свойства:
                возвращает общее количество элементов в массиве(доступное только для чтения);
                позволяющее увеличить значение всех элементов массива на скаляр(доступное только для записи).*/

                int n, m;
                Console.WriteLine("Введите колчество столбцов: ");
                n = CheckNumber();
                Console.WriteLine("Введите колчество строк: ");
                m = CheckNumber();
                ArrayDouble array = new ArrayDouble(n, m);

                Console.WriteLine("Ввод массива:");
                array.EnterArray();

                Console.WriteLine("Показать массив:");
                array.DisplayArray();

                Console.WriteLine("Отсортировать массив в порядке убывания:");
                array.Sort();

                Console.WriteLine("Показать отсортированный массив:");
                array.DisplayArray();

                Console.WriteLine(array.TotalElements);
                Console.WriteLine("Введите значение скаляр: ");
                array.ArrayScal = CheckDouble();
                array.DisplayArray();
                Console.ReadKey();
            }
    }
}
