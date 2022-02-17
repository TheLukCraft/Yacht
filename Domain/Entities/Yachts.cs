using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Yachts
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
        public Yachts()
        {
                
        }
        public Yachts(int id, int idYachtType, string name, string description, int numberOfSeats, int numberOfCabins,
            int lenght, int numberOfBathrooms, int yearOfConstruction, bool wiFi, double pricePerDay)
        {
            (Id, IdYachtType, Name, Description, NumberOfSeats, NumberOfCabins, Lenght, NumberOfBathrooms, YearOfConstruction, WiFi, PricePerDay) =
                (id, idYachtType, name, description, numberOfSeats, numberOfCabins, lenght, NumberOfBathrooms, yearOfConstruction, wiFi, pricePerDay);
        }
    }
}
