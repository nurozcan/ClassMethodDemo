using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12;
            customer1.Name = "Nur";
            customer1.Surname = "Ozcan";
            customer1.Age = 26;

            Customer customer2 = new Customer();
            customer2.Id = 4;
            customer2.Name = "Anıl";
            customer2.Surname = "Ozcan";
            customer2.Age = 23;

            CustomerManager customerManager = new CustomerManager();          

            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
            customerManager.ListCustomers(customer2);
                      
        }
    }
}
