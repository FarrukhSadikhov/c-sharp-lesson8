using System;

namespace exercises_classes5
{
    class Program
    {
        static int CheckNumber()
        {
            int n;
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
            }
            while (true);
        }
        static void Main(string[] args)
        {
           /* 5.Создать класс для работы с одномерным массивом целых чисел. Разработать следующие элементы класса:
            Поля:
            int[] IntArray;
            int n.
            Конструктор, позволяющий создать массив размерности n.
            Методы, позволяющие:
            ввести элементы массива с клавиатуры;
            вывести элементы массива на экран;
            отсортировать элементы массива в порядке возрастания.
            Свойства:
            возвращающее размерность массива(доступное только для чтения);
            позволяющее умножить все элементы массива на скаляр(доступное только для записи).*/
            Console.WriteLine("Введите размер массива: ");
            int n = CheckNumber();
            ArrayInt arr = new ArrayInt(n);
            Console.WriteLine("Введите элементы массива с клавиатуры:");
            int m = CheckNumber();
            arr.ReadArray();
            arr.Show();
            Console.WriteLine("Отсортировать элементы массива в порядке возрастания:");
            arr.Sort();
            arr.Show();
            Console.WriteLine($"Размерность массива:  {+ arr.N}");
            Console.WriteLine("Домножить все элементы массива на скаляр");
            Console.WriteLine(" Введите число скаляр: ");
            arr.ScalarArray = CheckNumber();
            arr.Show();
            Console.ReadLine();
        }
    }
}
