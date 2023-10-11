using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06practice
{
    class Account
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Сумма {amount} успешно зачислена на счет {AccountNumber}.");
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Сумма {amount} успешно снята со счета {AccountNumber}.");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
                return false;
            }
        }
    }

    class Client
    {
        public string CardNumber { get; private set; }
        public string Password { get; private set; }
        public Account Account { get; private set; }

        public Client(string cardNumber, string password)
        {
            CardNumber = cardNumber;
            Password = password;
            Account = new Account(Guid.NewGuid().ToString());
        }
    }
}
