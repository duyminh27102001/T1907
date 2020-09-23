using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A.Models
{
    class Customer
    {
        private string name;
        private string phonenumber;

        public Customer(string name, string phonenumber)
        {
            Name = name;
            Phonenumber = phonenumber;
        }

        public string Name
        {
            get => name;
            set => name = value;

        }

        public string Phonenumber
        {
            get => phonenumber;
            set => phonenumber = value;
        }
    }

    
}
