using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Get(Customer customer)
        {
            Console.WriteLine("\n" + "CustomerID: " + customer.CustomerID + " | CustomerName: " + customer.CustomerName +" | CustomerLastName: " + customer.CustomerLastName);
        }

        public List<Customer> GetAll(List<Customer> customerList)
        {
            foreach (var customer in customerList)
            {
                Console.WriteLine("CustomerID: " + customer.CustomerID + " | CustomerName: " + customer.CustomerName + " | CustomerLastName: " + customer.CustomerLastName + "\n");
            }

            return customerList;
        }

        public List<Customer> Add(Customer customer, List<Customer> customerList)
        {
            customerList.Add(customer);
            Console.WriteLine(customer.CustomerID + " " +customer.CustomerName + " " +customer.CustomerLastName + " | Added! \n");
            GetAll(customerList);
            return customerList;
        }

        public void Delete(Customer customer, List<Customer> customerList)
        {
            customerList.Remove(customer);
            GetAll(customerList);
            Console.WriteLine("Deleted!");
        }

        public List<Customer> Update(object updatedInfo, object availableValue, object changedValue, List<Customer> customerList)
        {
            if (updatedInfo == "CustomerID")
            {
                foreach (var item in customerList)
                {
                    if (item.CustomerID == Convert.ToInt32(availableValue))
                    {
                        item.CustomerID = Convert.ToInt32(changedValue);
                    }
                }
            }

            if (updatedInfo == "CustomerName")
            {
                foreach (var item in customerList)
                {
                    if (item.CustomerName == availableValue.ToString())
                    {
                        item.CustomerName = changedValue.ToString();
                    }
                }
            }

            if (updatedInfo == "CustomerLastName")
            {
                foreach (var item in customerList)
                {
                    if (item.CustomerLastName == availableValue.ToString())
                    {
                        item.CustomerLastName= changedValue.ToString();
                    }
                }
            }


            Console.WriteLine("Updated!\n");
            GetAll(customerList);
            return customerList;
        }

    }
}
