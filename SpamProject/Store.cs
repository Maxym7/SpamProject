using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamProject
{
    public class Store
    {
        private  List<string> _categories = new() { "Clothes", "Products", "Toys" };
        private  DiscountNotification _notification = new();

        public void SubscribeCustomer(string category, ICustomer customer)
        {
            _notification.Subscribe(category, customer);
        }

        public void NotifyDiscounts(string category, string discountMessage)
        {
            Console.WriteLine($"Shop: new discount on {category}");
            _notification.Notify(category, discountMessage);
        }
    }
}
