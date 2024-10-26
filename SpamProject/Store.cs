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
        private  List<string> _categories = new() { "Електроніка", "Одяг", "Іграшки" };
        private  DiscountNotification _notification = new();

        public void SubscribeCustomer(string category, ICustomer customer)
        {
            _notification.Subscribe(category, customer);
        }

        public void UnsubscribeCustomer(string category, ICustomer customer)
        {
            _notification.Unsubscribe(category, customer);
        }

        public void NotifyDiscounts(string category, string discountMessage)
        {
            Console.WriteLine($"Магазин: нова знижка в категорії {category}");
            _notification.Notify(category, discountMessage);
        }
    }
}
