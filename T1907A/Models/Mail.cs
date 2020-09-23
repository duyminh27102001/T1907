﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1907A.Models
{
    class Mail
    {
        private string email;
        private string subject;
        private string description;


        public Mail(string email, string subject, string content)
        {
            Email = email;
            Subject = subject;
            Description = content;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}
