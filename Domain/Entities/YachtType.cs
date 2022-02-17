using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class YachtType : AuditableEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public YachtType()
        {

        }
        public YachtType(int id, string type)
        {
            (Id, Type) = (id, type);
        }
    }
}
