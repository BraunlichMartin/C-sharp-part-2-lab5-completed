using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSetterExceptions();
            TestCustomerListConstructor();
            TestCustomerListAdd();
            TestCustomerListRemove();
            Console.ReadLine();

        }
        //MWB_3/4/2019
        static void TestSetterExceptions()
        {
            Customer c1 = new Customer();
        }

        static void TestCustomerListConstructor()
        {
            CustomerList cList = new CustomerList();

            Console.WriteLine("testing constructor");
            Console.WriteLine("Default constructor. expecting count of 0: " + cList.Count);
            Console.WriteLine("Default constructor. Expecting empty string: " + cList);
            Console.WriteLine();
        }

        static void TestCustomerListAdd()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("Amy", "Johnson", "johnsona@lanecc.edu");
            Customer c3 = new Customer("Sam", "Barber", "barbers@lanecc.edu");

            Console.WriteLine("Testing Add");
            cList.Add(c1);
            Console.WriteLine("Add that takes a customer parameter");
            Console.WriteLine("Expecting count of 1: " + cList.Count);
            Console.WriteLine("Expecting list of 1 customers:\n" + cList);
            cList.Add("Juan", "Lopez", "lopezj@lanecc.edu");
            Console.WriteLine("Add that takes individual customer attributes and");
            Console.WriteLine("Expecting count of 2: " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers:\n" + cList);
        }

        static void TestCustomerListRemove()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("Amy", "Johnson", "johnsona@lanecc.edu");
            Customer c3 = new Customer("Sam", "Barber", "barbers@lanecc.edu");

            cList.Add(c1);
            cList.Add("Juan", "Lopez", "lopezj@lanecc.edu");
            cList.Add(c3);

            Console.WriteLine("Testing Remove");
            Console.WriteLine("Remove with same object");
            cList.Remove(c1);
            Console.WriteLine("Expecting count of 2: " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers. Amy Johnson not listed");
            Console.WriteLine(cList);

            //13-1part3-MWB_3/6/2019
            //cList.Add("Juan", "Lopez", "lopezj123456789010111213141516171819202122232425262728@lanecc.edu");
            Console.WriteLine("cList is: \n" + cList);
            Console.WriteLine("testing +, \n");
            cList = cList + c1;
            Console.WriteLine("expecting cList + c1: \n" + cList);

            Console.WriteLine("testing -, \n");
            cList = cList - c3;
            Console.WriteLine("expecting cList - c3: \n" + cList);
            

        }
    }
}