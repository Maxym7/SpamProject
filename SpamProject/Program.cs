using SpamProject;
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main()
        {
            Store store = new Store();
            Customer customer1 = new Customer("Max");

            store.SubscribeCustomer("Clothes", customer1);

            store.NotifyDiscounts("Clothes", "Discount 20% on clothes");

        }
    }
}
