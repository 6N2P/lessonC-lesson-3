using System;

namespace Lesson_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую!!!");
            Console.WriteLine("Играем? Нажмите Y для продолжения или любую клавишу для закрытия игры.");

            string startGame =  Console.ReadLine();
            while (startGame == "Y")

            {
                int nuberOfPlayers = 0;
                bool flagNumberPlayer = false;
                while (flagNumberPlayer==false)
                    {
                      Console.WriteLine("Введите количество игроков. от 2х до 4х:");
                       nuberOfPlayers = Convert.ToInt32(Console.ReadLine());

                       if (nuberOfPlayers < 2 || nuberOfPlayers > 4)
                       {                        
                        flagNumberPlayer = false;
                       }
                       else
                       {
                        flagNumberPlayer = true;
                       }
                    }

                string userTryName1 = string.Empty;
                string userTryName2 = string.Empty;
                string userTryName3 = string.Empty;
                string userTryName4 = string.Empty;

                
                    
                    Console.WriteLine("Введите имя 1го игрока");
                    //Принемаю имя 1го игрока
                    userTryName1 = Console.ReadLine();

                if (nuberOfPlayers > 1)
                {
                    Console.WriteLine("Введите имя 2го игрока");
                    //Принемаю имя 2го игрока
                    userTryName2 = Console.ReadLine();
                }
                
                 if (nuberOfPlayers>2)
                {
                    Console.WriteLine("Введите имя 3го игрока");
                    //Принемаю имя 3го игрока
                    userTryName3 = Console.ReadLine();
                }
                 if (nuberOfPlayers>3)
                {
                    Console.WriteLine("Введите имя 4го игрока");
                    //Принемаю имя 4го игрока
                    userTryName4 = Console.ReadLine();
                }                                           
                                                           

                //генерирую класс случайных чисел
                Random random = new Random();

                int slojnost=1;
                bool slojChislBool = false;
                while(slojChislBool==false)
                {
                    //выбор сложности
                    Console.WriteLine("Выберите сложность 1 или 2");
                     slojnost = Convert.ToInt32(Console.ReadLine());
                    //проверяю число
                    if (slojnost == 1 || slojnost==2)
                    {
                        slojChislBool = true;
                        
                    }
                    else
                    {
                        Console.WriteLine("Введено не правильное число");
                        slojChislBool = false;                        
                    }
                }
                int gameNumber=1;
                //устонавливаю сложность
                switch (slojnost)
                {
                    case 1:
                        //генерирую случайно число от 12 до 120
                        gameNumber = random.Next(12, 121);
                        break;
                    case 2:
                        //генерирую случайно число от 120 до 200
                        gameNumber = random.Next(120, 200);
                        break;
                }
                
                //показываю число
                Console.WriteLine($"Число: {gameNumber}");
                int minus = 1;
                
                string pobeditel="P";
                string userTryName = "P";
                int i = 1;
               
                    for (i=1; i < nuberOfPlayers+1 && gameNumber>0;)
                    {
                        if(i==1)
                        {
                            userTryName = userTryName1;
                        }
                        else if(i==2)
                            {
                            userTryName = userTryName2;
                        }
                        else if(i==3)
                        {
                            userTryName = userTryName3;
                        }
                        else if(i==4)
                        {
                            userTryName = userTryName4;
                        }

                        bool numberTrue = false;
                        while (numberTrue == false)
                        {


                            Console.Write($"Ход {userTryName}: ");
                            minus = Convert.ToInt32(Console.ReadLine());
                            if (minus > 0 && minus < 5)
                            {
                                gameNumber = gameNumber - minus;
                                Console.WriteLine($"Число: {gameNumber}");
                                pobeditel = userTryName;
                                numberTrue = true;
                                break;

                            }
                            else
                            {
                                Console.WriteLine("Нужно вводить число от 0 до 4х");
                                Console.WriteLine($"Число: {gameNumber}");
                                numberTrue = false;
                            }
                        }

                        
                        if (i == nuberOfPlayers)
                        {
                            i = 1;
                        }
                        else
                        {
                            i++;
                        }
                    }                                                       
                               
                    /*if (i == 1)
                    {
                        userTryName = userTryName1;
                    }
                    else if (i == 2)
                    {
                        userTryName = userTryName2;
                    }
                    else if (i == 3)
                    {
                        userTryName = userTryName3;
                    }
                    else if (i == 4)
                    {
                        userTryName = userTryName4;
                    }
                    */
                    Console.WriteLine($"Победил: {userTryName}");               
                               
                Console.WriteLine("Играем? Нажмите Y для продолжения или любую клавишу для закрытия игры.");
                startGame = Console.ReadLine();
            }           

        }
    }
}
