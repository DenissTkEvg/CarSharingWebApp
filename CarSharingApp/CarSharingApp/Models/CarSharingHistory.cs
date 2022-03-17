using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSharingApp.Models
{
    public class CarSharingHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SharingPointId { get; set; }
        public int ChoosenCarId { get; set; }
        public DateTime SharingDate { get; set; }
        public int MinutesCount { get; set; }
        public int FinalPrice { get; set; }
    }
}
