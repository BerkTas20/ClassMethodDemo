using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.NameSurname = "John Doe";
            customer1.PhoneNumber = 0000000000;
            customer1.Identify = 00000000000;
            customer1.Adress = "United States";
            customer1.Email = "CustomerJohnDoe@hotmail.com";
            customer1.Limit = 5000;

            Customer customer2 = new Customer();
            customer2.NameSurname = "Lisa Doe";
            customer2.PhoneNumber = 0000000000;
            customer2.Identify = 00000000000;
            customer2.Adress = "United Kingdom";
            customer2.Email = "CustomerLisaDoe@hotmail.com";
            customer2.Limit = 7000;

            
            

            Customer customer3 = new Customer();
            customer3.NameSurname = "Crazy Turk";
            customer3.PhoneNumber = 0000000000;
            customer3.Identify = 00000000000;
            customer3.Adress = "Turkey";
            customer3.Email = "CrazyTurk@hotmail.com";
            customer3.Limit = 8000;



            Customer[] customers = new Customer[] { customer1 , customer2, customer3 };
            

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.NameSurname,);
                Console.WriteLine(customer.PhoneNumber);
                Console.WriteLine(customer.Identify);
                Console.WriteLine(customer.Adress);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Limit);



            }

            Console.WriteLine(">>>>>>>>>>>>>>>");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            customerManager.List(customer1);






        }
    }
}
