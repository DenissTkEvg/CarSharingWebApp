using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int IsAdmin { get; set; }
        public List<CarSharingHistory> CarSharingHistory { get; set; }
    }
}
