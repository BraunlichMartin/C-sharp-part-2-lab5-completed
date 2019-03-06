using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
     
    public class Customer
    {
        private string firstname;
        private string lastname;
        private string email;
        //Constructors-MWB_2/16/2019
        public Customer() { }
        public Customer(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

      

        //Properties-MWB_2/16/2019
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (value.Length > 30)
                {
                    throw new System.ArgumentException("FirstName");
                }
                
                    firstname = value;
                
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (value.Length > 30)
                {
                    throw new System.ArgumentException("LastName");
                }
                
                    lastname = value;
                
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Length > 30)
                {
                    throw new System.ArgumentException("Email");
                    
                    /////MWB_3/4/2019
                }
                    email = value;
                
            }
        }

        //Methods-MWB_2/16/2019
        public string GetDisplayText(string sep) => firstname + sep + lastname + sep + email;

        //MWB_3/6/2019
        public override string ToString()
        {
            return GetDisplayText(",");
        }
        
        //MWB_3/4/2019
       
    }
}
