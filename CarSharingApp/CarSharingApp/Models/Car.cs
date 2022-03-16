using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarNumber { get; set; }
        public int PricePerMinute { get; set; }
        public string Status { get; set; }
        public bool IsFree { get; set; }
        public string CarImg { get; set; }
        public int Mileage { get; set; }
        public string Transmission { get; set; }
        public string Type { get; set; }
    }
}
