using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06practice
{
    class Banc
    {
        private Client[] clients;

        public Banc()
        {
            clients = new Client[0];
        }

        public void AddClient(Client client)
        {
            Array.Resize(ref clients, clients.Length + 1);
            clients[clients.Length - 1] = client;
        }

        public Client AuthenticateClient(string cardNumber, string password)
        {
            foreach (Client client in clients)
            {
                if (client.CardNumber == cardNumber && client.Password == password)
                {
                    return client;
                }
            }
            return null;
        }
    }
}
