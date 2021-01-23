/*           
* Author          : nozcan
* Date            : 1/23/2021 8:15:35 PM
* Description     :               
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("*** Add Customer ***");
            Console.WriteLine("This customer is added : ");
            Console.WriteLine("Customer Id: " + customer.Id);
            Console.WriteLine("Customer name: : " + customer.Name);
            Console.WriteLine("Customer surname: : " + customer.Surname);
            Console.WriteLine("Customer age: " + customer.Age);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("*** Delete Customer ***");
            Console.WriteLine("This customer is deleted : ");
            Console.WriteLine("Customer id : " + customer.Id);
            Console.WriteLine("Customer name : " + customer.Name);
            Console.WriteLine("Customer surname : " + customer.Surname);
            Console.WriteLine("Customer age is : " + customer.Age);
        }

        public void ListCustomers(Customer customer)
        {
            customers.Add(customer);

            Console.WriteLine("*** List Customer **");
            foreach (Customer customerInfo in customers)
            {
                Console.WriteLine("Customer Id : " + customer.Id);
                Console.WriteLine("Customer Name : " + customer.Name);
                Console.WriteLine("Customer Surname : " + customer.Surname);
                Console.WriteLine("Customer Age : " + customer.Age);
            }
        }
    }
}
