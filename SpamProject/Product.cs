using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamProject
{
    public class Product
    {
        public string Name { get; set; }
        public bool IsIntegesting { get; set; }

        public Product(string name)
        {
            Name = name;
            IsIntegesting = false;
        }
        public Product(string name, bool isIntegesting)
        {
            Name = name;
            IsIntegesting = isIntegesting;
        }
    }
}
