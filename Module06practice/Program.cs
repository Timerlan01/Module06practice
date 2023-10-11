using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Banc banc = new Banc();

            Client client1 = new Client("1234567890123456", "1234");
            banc.AddClient(client1);

            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                Client authenticatedClient = banc.AuthenticateClient(client1.CardNumber, password);

                if (authenticatedClient != null)
                {
                    Console.WriteLine("Добро пожаловать!");
                    while (true)
                    {
                        Console.WriteLine("Меню:");
                        Console.WriteLine("a. Вывести баланс");
                        Console.WriteLine("b. Пополнить счет");
                        Console.WriteLine("c. Снять деньги");
                        Console.WriteLine("d. Выйти");
                        Console.Write("Выберите действие: ");
                        char choice = Console.ReadKey().KeyChar;
                        Console.WriteLine();

                        switch (choice)
                        {
                            case 'a':
                                Console.WriteLine($"Баланс: {authenticatedClient.Account.Balance}");
                                break;
                            case 'b':
                                Console.Write("Введите сумму для пополнения: ");
                                double depositAmount = double.Parse(Console.ReadLine());
                                authenticatedClient.Account.Deposit(depositAmount);
                                break;
                            case 'c':
                                Console.Write("Введите сумму для снятия: ");
                                double withdrawAmount = double.Parse(Console.ReadLine());
                                authenticatedClient.Account.Withdraw(withdrawAmount);
                                break;
                            case 'd':
                                Console.WriteLine("До свидания!");
                                return;
                            default:
                                Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                                break;
                        }
                    }
                }
                else
                {
                    attempts--;
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts}");
                }
            }

            Console.WriteLine("Исчерпаны попытки. До свидания!");
        }
    }
}

