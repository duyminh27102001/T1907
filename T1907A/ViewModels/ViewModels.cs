using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using T1907A.Models;
namespace T1907A.ViewModels
{
    class ViewModel
    {
        public static List<Mail> MailList = new List<Mail>();
        public static List<Customer> CustomerList = new List<Customer>();
        public ViewModel()
        {
          if(MailList.Count == 0)
            {
                MailList.Add(new Mail("duyminh@gmail.com", "Thu Moi", "thu moi"));
                MailList.Add(new Mail("duyminh@gmail.com", "Thu Moi", "thu moi")); 
            }   

          if(CustomerList.Count == 0)
            {
                CustomerList.Add(new Customer("THanh", "1829312837193"));
            }
        }
        public List<Customer> Customers
        {
            get => CustomerList;
        }
        public List<Mail> Mails
        {
            get => MailList;
        }

        
    }
}
