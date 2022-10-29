using System;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : " + customer.FullName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.FullName);
        }

        public void ListAll(Customer[] customers) // Customer tipinde dizi al ve foreach ile ...bunları dön
        {
            Console.WriteLine("Customer List: ");
            foreach (var customer in customers)
            {
                Console.WriteLine("\nCustomer ID : " + customer.Id + "\nCustomer FullName : " + customer.FullName +
                    "\nCustomer Account Number : " + customer.AccountNumber +
                    "\nCustomer Account Balance : " + customer.AccountBalance);
            }
        }


    }
}
