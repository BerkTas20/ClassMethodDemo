using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : " + customer.NameSurname);
        }
        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Customer Deleted : " + customer.NameSurname);
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Customer List : " + customer.NameSurname);
            foreach(var x in customers)
            {
                Console.WriteLine("Customer Id" + customer.Id);
                Console.WriteLine("Customer Id" + customer.NameSurname);
                Console.WriteLine("Customer Id" + customer.PhoneNumber);
                Console.WriteLine("Customer Id" + customer.Identify);
                Console.WriteLine("Customer Id" + customer.Adress);
                Console.WriteLine("Customer Id" + customer.Email);
                Console.WriteLine("Customer Id" + customer.Limit);


            }
        }
    }
}
