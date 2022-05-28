using System;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!! Сколько у вас карт на руках?");
            //Создаю счёчик
            int caunt = int.Parse(Console.ReadLine());
            //вывожу количество карт
            Console.WriteLine("количество карт:"+caunt);
            //Правила ввода карт
            Console.WriteLine("Введите номинал каждой карты. \nДля карт с числовым номиналом, введите только цифру. " +
                "\nДля «картинок»: Валет = J, Дама = Q, Король = K, Туз = T ");
            //Создаю переменную для подщёта суммы
            int sum = 0;
            //Создаю цикл завищящий от колличества карт (count)
            for (int i = 0; i < caunt; i++)
            {
                //принимаю номиналы карт пользователя
                string sCard = Console.ReadLine();
                //создаю переменную для преобразования считанных карт в числове значение
                int card;
                //проверка внесённых значений
                if ( sCard == "2" || sCard == "3" || sCard == "4" || sCard == "5" || sCard == "6" || sCard == "7" || sCard == "8" || sCard == "9")
                {
                     card = Convert.ToInt32(sCard);
                }
                else
                {
                    if (sCard == "T" || sCard == "J" || sCard == "Q" || sCard == "K")
                    {
                        card = 10;
                    }
                    else
                    {
                        card = 0;
                    }
                }
                //создаю переменную весса карт
                int weightCard = 0;                

                switch(card)
                {
                    case 1:
                        weightCard = 1;
                        break;
                    case 2:
                        weightCard = 2;
                        break;
                    case 3:
                        weightCard = 3;
                        break;
                    case 4:
                        weightCard = 4;
                        break;
                    case 5:
                        weightCard = 5;
                        break;
                    case 6:
                        weightCard = 6;
                        break;
                    case 7:
                        weightCard = 7;
                        break;
                    case 8:
                        weightCard = 8;
                        break;
                    case 9:
                        weightCard = 9;
                        break;
                    case 10:
                        weightCard = 10;
                        break;                       

                }
                //считаю сумму карт
                sum = sum +weightCard;
            }
            //вывожу значение суммы карт
            Console.WriteLine($"Сумма карт = {sum}");
            Console.ReadKey();
        }
    }
}
