﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationApp.Models
{
    public class ApplicationUserModel
    {
        public String UserName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String PhoneNumber{get;set;}
    }
}
