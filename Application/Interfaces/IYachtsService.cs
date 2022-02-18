using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IYachtsService
    {
        IEnumerable<YachtsDto> GetAllYachts();
        Yachts GetYachtById(int id);
        
    }
}
