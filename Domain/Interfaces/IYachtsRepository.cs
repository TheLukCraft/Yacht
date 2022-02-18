using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IYachtsRepository
    {
        IEnumerable<Yachts> GetAll();
        Yachts GetById(int id);
        Yachts Add(Yachts yacht);
        void Update(Yachts yacht);
        void Delete(Yachts yacht);
    }
}
