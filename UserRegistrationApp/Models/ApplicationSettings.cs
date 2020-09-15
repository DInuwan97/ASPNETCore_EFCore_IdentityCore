using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationApp.Models
{
    public class ApplicationSettings
    {
        public String JWT_Secret { get; set; }

        public String Clinet_URL { get; set; }
    }
}
