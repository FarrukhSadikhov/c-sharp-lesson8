using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_classes6
{
    class ArrayDouble
    {
        // Поля: •	double [][] DoubleArray; •	int n, m.
        int n, m;
        double[,] DoubleArray;
        // Конструктор, позволяющий создать массив размерности n×m.
        public ArrayDouble(int n, int m)
        {
            this.n = n;
            this.m = m;

            DoubleArray = new double[n, m];
        }
        // Возвращающее общее количество элементов в массиве (доступное только для чтения);
        public int TotalElements
        {
            get
            {
                return n * m;
            }
        }

        // Позволяющее увеличить значение всех элементов массива на скаляр (доступное только для записи).
        public double ArrayScal
        {
            set
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        DoubleArray[i, j] += value;
            }
        }
        // Ввести элементы массива с клавиатуры;
        public void EnterArray()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Введите элемент DoubleArray[{0},{1}] = ", i, j);
                    if (Double.TryParse(Console.ReadLine(), out  double x))
                    {
                        DoubleArray[i,j]= x;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка!!!Введите корректные данные");
                        j--;
                    }
                }
        }
        // Вывести элементы массива на экран
        public void DisplayArray()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" " + DoubleArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // Отсортировать элементы каждой строки массива в порядке убывания.
        public void Sort()
        {
            bool a;
            double temp;
            for (int i = 0; i < n; i++)
            {
                a = true;
                while (a)
                {
                    a = false;
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (DoubleArray[i, j] < DoubleArray[i, j + 1])
                        {
                            temp = DoubleArray[i, j];
                            DoubleArray[i, j] = DoubleArray[i, j + 1];
                            DoubleArray[i, j + 1] = temp;
                            a = true;
                        }
                    }
                }
            }
        }       
    }
}
