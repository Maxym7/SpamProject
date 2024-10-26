using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamProject
{
    public class DiscountNotification
    {
        private Dictionary<string, List<ICustomer>> _subscriptions = new();

        public void Subscribe(string category, ICustomer customer)
        {
            if (!_subscriptions.ContainsKey(category))
            {
                _subscriptions[category] = new List<ICustomer>();
            }
            _subscriptions[category].Add(customer);
        }

        public void Unsubscribe(string category, ICustomer customer)
        {
            if (_subscriptions.ContainsKey(category))
            {
                _subscriptions[category].Remove(customer);
            }
        }

        public void Notify(string category, string message)
        {
            if (_subscriptions.ContainsKey(category))
            {
                foreach (var customer in _subscriptions[category])
                {
                    customer.Update(category, message);
                }
            }
        }
    }
}
