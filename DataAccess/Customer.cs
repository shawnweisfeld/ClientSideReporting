using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static List<Customer> Get()
        {
            return new List<Customer>()
            {
                new Customer() { FirstName = "George", LastName = "Washington", Age = 10},
                new Customer() { FirstName = "Thomas", LastName = "Jefferson", Age = 11},
                new Customer() { FirstName = "Abe", LastName = "Lincoln", Age = 12},
                new Customer() { FirstName = "George", LastName = "Bush", Age = 13},
                new Customer() { FirstName = "Bill", LastName = "Clinton", Age = 14},
            };
        }
    }
}
