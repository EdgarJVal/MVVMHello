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
            var rnd = new Random();

            for (int i = 1; i <= 20; i++)
            {
                customers.Add(new Customer()
                {
                    ID = i,
                    FirstName = Guid.NewGuid().ToString(),
                    SecondName = Guid.NewGuid().ToString(),
                    LastName = Guid.NewGuid().ToString(),
                    IsEnable = rnd.Next(1, 20)>10 ? true : false,
                    LastLogin = DateTime.Now.AddDays(i)
                });
            }

            return customers;
        }
    }
}

