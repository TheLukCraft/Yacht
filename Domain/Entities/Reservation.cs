using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Reservation : AuditableEntity
    {
        public int Id { get; set; }
        public int IdYachts { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public bool Active { get; set; }
        public Reservation()
        {

        }
        public Reservation(int id, int idYachts, DateTime dateFrom, DateTime dateTo, string email, int phoneNumber, bool active)
        {
            (Id, IdYachts, DateFrom, DateTo, Email, PhoneNumber, Active) = (id, idYachts, dateFrom, dateTo, email, phoneNumber, active);
        }
    }
}
