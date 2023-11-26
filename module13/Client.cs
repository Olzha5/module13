using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module13
{
    public class Client
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public ServiceType Service { get; set; }

        public Client(string name, ServiceType service)
        {
            Id = Guid.NewGuid();
            Name = name;
            Service = service;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name} - {Service}";
        }
    }

    public enum ServiceType
    {
        Credit,
        Deposit,
        Consultation
    }

}
