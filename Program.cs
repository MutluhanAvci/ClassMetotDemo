using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Mutluhan Yılmaz";
            customer.Surname = "Avcı";
            customer.CustomerId = 123;
            CustomerManager customerManager = new CustomerManager();
            customerManager.CreateCustomer(customer);
            customerManager.ShowAllCustomers(customer);
            customerManager.DeleteCustomerRecord(customer);
        }
    }
}
