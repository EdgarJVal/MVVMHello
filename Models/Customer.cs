using System;

namespace MVVMHello.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public bool IsEnable { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
