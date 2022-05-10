using System;

namespace Guess_The_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number,lower,longer;
            int tryCount = 5;
            Random rand = new Random();
            int userInput;
            
            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number - 1);
            longer = rand.Next(number + 1, number + 10);
            
            Console.WriteLine($"Мы загадали вам число. Оно больше {lower}, но меньше{longer}");
            Console.WriteLine($"У вас есть {tryCount} попыток.");
            Console.WriteLine("Что это за число?");
            while (tryCount-- > 0)
            {
                Console.Write("Это число:");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("Поздравляю, вы угодали.");
                    break;
                }
                else if(tryCount == 1)
                {
                    Console.WriteLine($"Призовите на помощ всё своё везение, это последняя попытка.");
                }
                else 
                {
                    Console.WriteLine("Вы не угодали, попробуйте еще раз");
                    Console.WriteLine($"Остальсь попыток: {tryCount}");
                }
            }
        }
    }
}