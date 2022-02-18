using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class YachtsDto
    {
        public int Id { get; set; }
        public int IdYachtType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfCabins { get; set; }
        public int Lenght { get; set; }
        public int NumberOfBathrooms { get; set; }
        public int YearOfConstruction { get; set; }
        public bool WiFi { get; set; }
        public double PricePerDay { get; set; }
    }
}
