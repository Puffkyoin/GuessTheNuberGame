using System;
using System.Runtime.InteropServices;

namespace Guess_The_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number,low,high;
            int tryCount = 5;
            Random rand = new Random();
            int minSpread = 1, maxSpread = 10;
            int userInput;
            
            number = rand.Next(0, 101);
            low = rand.Next(number - maxSpread, number - minSpread);
            high = rand.Next(number + minSpread, number + maxSpread);
            
            Console.WriteLine($"Мы загадали вам число. Оно больше {low}, но меньше {high}");
            Console.WriteLine($"У вас есть {tryCount} попыток.");
            Console.WriteLine("Что это за число?");
            
            for (int i = 1; i <= tryCount; i++)
            {
                Console.WriteLine($"\nПопытка №{i}");
                Console.Write("Это число:");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine($"Поздравляю, вы смогли угадать с {i}-ой попытки.");
                    break;
                }
                else if(tryCount == i)
                {
                    Console.WriteLine("Вы проиграли.");
                    Console.WriteLine($"Было загадано число {number}.");
                    break;
                }
                else if(i == tryCount - 1)
                {
                    Console.WriteLine($"Призовите на помощь всё своё везение, это последняя попытка.");
                }
                else
                {
                    Console.WriteLine("Вы не угодали, попробуйте еще раз.");
                    Console.WriteLine($"Осталось попыток: {tryCount-i}");
                }
            }
        }
    }
}