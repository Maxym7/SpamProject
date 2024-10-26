using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamProject
{
    public interface ICustomer
    {
        void Update(string category, string message);
    }
}
