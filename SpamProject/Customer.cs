using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamProject
{
    public class Customer : ICustomer
    {
        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Update(string category, string message)
        {
            Console.WriteLine($"For {Name}: {category} - {message}");
        }
    }
}
