using System;

namespace Lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Введите целое число:");
                int namber = int.Parse(Console.ReadLine());
                if (namber % 2 == 0)
                {
                    Console.WriteLine("Число чётное");
                }
                else
                {
                    Console.WriteLine("Число не чётное");
                }
            }
            
        }
    }
}
