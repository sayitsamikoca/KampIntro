using System;
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() 
            { Id=1,
              FullName="Sayit Sami Koca",
              AccountNumber="12349090",
              AccountBalance=2000
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                FullName = "Rasmus Lerdorf",
                AccountNumber = "23435679",
                AccountBalance = 1850
            };

            Customer customer3 = new Customer()
            {
                Id = 3,
                FullName = "Kevin Mittnick",
                AccountNumber = "30303012",
                AccountBalance = 500
            };


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            Console.WriteLine("\n---------------------------------------\n");
            customerManager.ListAll(customers);

        }
    }
}
