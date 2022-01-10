using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_classes5
{
    class ArrayInt
    {
        //Поля:int [] IntArray; int n.
        int[] IntArray;
        int n;

        //Конструктор, позволяющий создать массив размерности n.
        public ArrayInt(int n)
        {
            this.n = n;
            IntArray = new int[n];
        }
        //возвращающее размерность массива (доступное только для чтения);
        public int N
        {
            get
            {
                return n;
            }
        }
        //позволяющее домножить все элементы массива на скаляр (доступное только для записи).
        public int ScalarArray
        {
            set
            {
                for (int i = 0; i < IntArray.Length; i++)
                    IntArray[i] = IntArray[i] * value;
            }
        }
        // Ввести элементы массива с клавиатуры;
        public void ReadArray()
        {           
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.WriteLine("Введите элементы массива");
                Console.Write("IntArray[{0}] = ", i);
                if (Int32.TryParse(Console.ReadLine(), out int x))
                {
                    IntArray[i] = x;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                    i--;
                }
            }
        }
        //вывести элементы массива на экран;
        public void Show()
        {
            Console.WriteLine("Массив:");

            foreach (int i in IntArray)
                Console.Write(" {0} ", i);
            Console.WriteLine();
        }
        //отсортировать элементы массива в порядке возрастания.
        public void Sort()
        {
            int temp;
            bool a = true;
            while (a)
            {
                a = false;
                for (int j = 0; j < IntArray.Length - 1; j++)
                {
                    if (IntArray[j] > IntArray[j + 1])
                    {
                        temp = IntArray[j + 1];
                        IntArray[j + 1] = IntArray[j];
                        IntArray[j] = temp;
                        a = true;
                    }
                }
            }
        }       
    }
}
