using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06practice
{
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
