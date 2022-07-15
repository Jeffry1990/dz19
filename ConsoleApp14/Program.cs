using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 100000;
            string randomMessage = "exit";
            string userInput;

            for (int i=0; i<tryCount; i++)
            {
                Console.Write("Введите любое слово для повторения или exit чтобы закрыть приложение: ");
                userInput = Console.ReadLine();
                if(randomMessage == userInput)
                {
                    Console.WriteLine("Условия выполнены. Закрываемся");
                    break;
                }
                else
                {
                    Console.WriteLine("Повторите ввод");
                }
            }
        }
    }
}
