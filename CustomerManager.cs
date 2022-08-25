using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void CreateCustomer(Customer customer)
        {
            Console.WriteLine("New customer record created for "+customer.Name+" "+customer.Surname);
        }
        public void ShowAllCustomers(params Customer [] customers)
        {
            foreach (Customer item in customers)
            {
                Console.WriteLine(item.Name+" "+item.Surname);
            }
        }
        public void DeleteCustomerRecord(Customer customer)
        {
            Console.WriteLine("Customer record "+customer.CustomerId+ " has been deleted succesfully");
        }
    }
}
