using System;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            //получаю число
            int N =Convert.ToInt32( Console.ReadLine());
            //создаю переменные
            bool prostoeChisloFlag = true;
            int i = 2;
            //создаю цикл
            while(i<N-1 && prostoeChisloFlag==true)
            {
               // bool celoeChislo = false;
                
                if( N%i == 0)
                {
                    prostoeChisloFlag = false;                    
                }
               
                i++;
               
            }
            if (prostoeChisloFlag)
            {
                Console.WriteLine($"число {N} простое");
            }
            else
            {
                Console.WriteLine($"число {N} состовное число");
            }
            
            Console.ReadKey();
        }
    }
}
