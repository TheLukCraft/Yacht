using Application.Dto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class YachtsService : IYachtsService
    {
        private readonly IYachtsRepository _yachtsRepository;
        private readonly IMapper _mapper;
        public YachtsService(IYachtsRepository yachtsRepository, IMapper mapper)
        {
            _yachtsRepository = yachtsRepository;
            _mapper = mapper;
        }

        public IEnumerable<YachtsDto> GetAllYachts()
        {
            var yacht = _yachtsRepository.GetAll();
            return _mapper.Map<IEnumerable<YachtsDto>>(yacht);
        }
        public YachtsDto GetYachtById(int id)
        {
            var yacht = _yachtsRepository.GetById(id);
            return _mapper.Map<YachtsDto>(yacht);
        }
    }
}
