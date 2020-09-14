using MVVMHello.Models;
using System.Collections.Generic;

namespace MVVMHello.DAL
{
    public interface ICustomerService
    {
        List<Customer> GetCustomer();
    }
}
