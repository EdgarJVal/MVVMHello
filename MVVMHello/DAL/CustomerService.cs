using MVVMHello.Models;
using System;
using System.Collections.Generic;

namespace MVVMHello.DAL
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomer()
        {
            var customers = new List<Customer>();

            for (int i = 1; i <= 20; i++)
            {
                customers.Add(new Customer()
                {
                    ID = i,
                    FirstName = Guid.NewGuid().ToString(),
                    SecondName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    IsEnable = i > 10,
                    LastLogin = DateTime.Now.AddDays(i)
                });
            }

            return customers;
        }
    }
}

