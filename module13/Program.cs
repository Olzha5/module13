using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueManager queueManager = new QueueManager();

            while (true)
            {
                Console.WriteLine("\n1. Встать в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("Выберите действие:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddClientToQueue(queueManager);
                        break;
                    case "2":
                        queueManager.ServeClient();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                        break;
                }
            }
        }

        static void AddClientToQueue(QueueManager queueManager)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Выберите услугу: 1 - Кредитование, 2 - Открытие вклада, 3 - Консультация");
            ServiceType service = (ServiceType)(int.Parse(Console.ReadLine()) - 1);

            Client client = new Client(name, service);
            queueManager.AddClient(client);
        }
    }
}
