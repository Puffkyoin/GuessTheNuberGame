using System;
using System.Runtime.InteropServices;

namespace Guess_The_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int number;
            int low;
            int high;
            int tryCount = 5;
            int minNumber = 1;
            int maxNumber = 101;
            int minSpread = 1;
            int maxSpread = 10;
            int userInput;
            
            number = rand.Next(minNumber, maxNumber);
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