using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_classes4
{
    class Money
    {
        //Поля:
        int first;//номинал купюры
        int second; //количество купюр
        //Конструктор, позволяющий создать экземпляр класса с заданными значениям полей.
        public  Money (int first,int second)
        {
            this.first = first;
            this.second = second;
        }
        //Свойства: позволяющее получить-установить значение полей(доступное для чтения и записи);
        public int First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }
        //Свойства: позволяющее рассчитать сумму денег(доступное только для чтения).
        public int Total
        {
            get
            {
                return first * second;
            }
        }
        //вывести номинал и количество купюр;
        public string Display()
        {
            return $"номинал купюры: {first}  количество купюр: {second}";
        }
        //определить, хватит ли денежных средств на покупку товара на сумму N рублей.
        public bool Calculation(int n)
        {
            if ((first*second)>=n)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //определить, сколько шт товара стоимости n рублей можно купить на имеющиеся денежные средства.
        public int Count(int n)
        {
            return (first * second) / n;
        }

    }
}
