using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module13
{
    public class QueueManager
    {
        private Queue<Client> clients = new Queue<Client>();
        private List<Client> servedClients = new List<Client>();

        public void AddClient(Client client)
        {
            clients.Enqueue(client);
            DisplayQueue();
        }

        public void ServeClient()
        {
            if (clients.Any())
            {
                Client client = clients.Dequeue();
                Console.WriteLine($"Обслуживается клиент: {client}");
                servedClients.Add(client);
                DisplayQueue();
            }
            else
            {
                Console.WriteLine("Очередь пуста.");
            }
        }

        private void DisplayQueue()
        {
            Console.WriteLine("Текущее состояние очереди:");
            foreach (var client in clients)
            {
                Console.WriteLine(client);
            }
        }
    }

}
