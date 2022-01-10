using System;

namespace exercises_classes4
{
    class Program
    {
        static int CheckNumber()
        {
            int first, second;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out first))
                {
                    return first;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
                if (Int32.TryParse(Console.ReadLine(), out second))
                {

                    return second;
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
            /*4.Создать класс Money, разработав следующие элементы класса:
            Поля:
            int first;//номинал купюры
            int second; //количество купюр
            Конструктор, позволяющий создать экземпляр класса с заданными значениям полей.
            Методы, позволяющие:
            вывести номинал и количество купюр;
            определить, хватит ли денежных средств на покупку товара на сумму N рублей.
            определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства.
            Свойства:
            позволяющее получить-установить значение полей(доступное для чтения и записи);
            позволяющее рассчитать сумму денег(доступное только для чтения).*/
            Console.WriteLine("номинал купюры");
            int first = CheckNumber();
            Console.WriteLine("количество купюр");
            int second = CheckNumber();
            Money mony = new Money(first,second);
            Console.Write("У вас: ");
            Console.WriteLine(mony.Display()); 
            Console.WriteLine("Введите сумму товара: ");
            int t = CheckNumber();
            if (mony.Calculation(t))
            {
                Console.WriteLine("Достаточно денежных средств ");
            }
            else { Console.WriteLine("Недостаточно денежных средств "); }
            Console.WriteLine($"купить на имеющиеся денежные средства можно: {mony.Count(t)} шт ");
            Console.ReadKey();
        }
    }
}
