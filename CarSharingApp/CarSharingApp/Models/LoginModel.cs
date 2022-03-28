using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Models
{
    public class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Full_name { get; set; }
        public string Phone { get; set; }
        public string ErrorMessage { get; set; }
    }
}
