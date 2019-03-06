using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList
    {
        public override string ToString()
        {
            string str = "";
            foreach (Customer c in customers)
            {
                str += (c.ToString() + "\n");
            }
            return str;
        }


            private List<Customer> customers;
            public CustomerList()
            {
                customers = new List<Customer>();

        }
            public int Count
            {
                get { return customers.Count; }
            }
            public void Add(Customer customer)
            {
                customers.Add(customer);
            }

            public void Add(string firstName, string lastName, string email)
            {
                Customer c = new Customer(firstName, lastName, email);
                customers.Add(c);
            }

           


        //MWB_3/4/2019
       
        public Customer GetProductByIndex(int i)
        {
            return customers[i];
        }
        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }
        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }
        public void Save() => CustomerDB.SaveCustomers(customers);

        public static CustomerList operator +(CustomerList c1, Customer c)
        {
            c1.Add(c);
            return c1;
        }
        public static CustomerList operator -(CustomerList c1, Customer c)
        {
            c1.Remove(c);
            return c1;
        }

    }
}
