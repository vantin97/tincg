using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models
{
    public class Schedule
    {
        public int id { get; set; }
        public int idVehicle { get; set; }
        public string vehicleNumber { get; set; }
        public string seat { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime entryDate { get; set; }
        public int idCountryFrom { get; set; }
        public int idCityFrom { get; set; }
        public int idToCountry { get; set; }
        public int idToCity { get; set; }
        public string note { get; set; }
        public int idUser { get; set; }

    }
}
