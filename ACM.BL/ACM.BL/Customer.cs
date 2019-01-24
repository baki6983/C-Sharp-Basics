using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public string  Email { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                return FirstName +" "+ LastName;
            }
        }
    }
}
