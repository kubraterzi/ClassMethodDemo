using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer 
            {
                CustomerID =1,
                CustomerName = "Kübra",
                CustomerLastName="Terzi"
            };

            Customer customer2 = new Customer
            {
                CustomerID = 2,
                CustomerName = "Engin",
                CustomerLastName = "Demiroğ"
            };

            Customer customer3 = new Customer
            {
                CustomerID =3,
                CustomerName = "Metin",
                CustomerLastName = "Sezer"
            };

            Customer customer4 = new Customer
            {
                CustomerID = 4,
                CustomerName = "Elif",
                CustomerLastName = "Soylu"
            };

            CustomerManager customerManager = new CustomerManager();

            List<Customer> customerList = new List<Customer>(){ customer1, customer2, customer3};

            // Add
            // customerManager.Add(customer4, customerList);

            // Delete
            // customerManager.Delete(customer1, customerList);

            //Update
            //customerManager.Update("CustomerLastName", "Sezer", "Yılmaz", customerList);
            //customerManager.Update("CustomerID" , 2, 5 , customerList);

            // Get Customer Info
            // customerManager.Get(customer3);

            // Get All Customer Info
            // customerManager.GetAll(customerList);


        }
    }
}
