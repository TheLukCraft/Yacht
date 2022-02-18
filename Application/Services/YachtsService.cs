using Application.Dto;
using Application.Interfaces;
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
        public YachtsService(IYachtsRepository yachtsRepository)
        {
            _yachtsRepository = yachtsRepository;
        }

        public IEnumerable<YachtsDto> GetAllYachts()
        {
            var yacht = _yachtsRepository.GetAll();
            return yacht.Select(yacht => new YachtsDto 
            {
                Id = yacht.Id,
                IdYachtType = yacht.IdYachtType,
                Name = yacht.Name,
                Description = yacht.Description,
                NumberOfSeats = yacht.NumberOfSeats,
                NumberOfCabins = yacht.NumberOfCabins,
                Lenght = yacht.Lenght,
                NumberOfBathrooms = yacht.NumberOfBathrooms,
                YearOfConstruction = yacht.YearOfConstruction,
                WiFi = yacht.WiFi,
                PricePerDay = yacht.PricePerDay,

            });
        }
        public Yachts GetYachtById(int id)
        {
            var yacht = _yachtsRepository.GetById(id);
            return new YachtsDto()
            {
                Id = yacht.Id,
                IdYachtType = yacht.IdYachtType,
                Name = yacht.Name,
                Description = yacht.Description,
                NumberOfSeats = yacht.NumberOfSeats,
                NumberOfCabins = yacht.NumberOfCabins,
                Lenght = yacht.Lenght,
                NumberOfBathrooms = yacht.NumberOfBathrooms,
                YearOfConstruction = yacht.YearOfConstruction,
                WiFi = yacht.WiFi,
                PricePerDay = yacht.PricePerDay,
            };
        }
    }
}
