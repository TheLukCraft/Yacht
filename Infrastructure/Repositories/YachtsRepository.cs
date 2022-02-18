using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class YachtsRepository : IYachtsRepository
    {
        private static readonly ISet<Yachts> _yachts = new HashSet<Yachts>()
        {
            new Yachts(1, 1, "Balt 818 Tytan (2022)", "Balt 818 Tytan jest to wyjątkowy jacht motorowy - to pierwszy houseboat, który posiada kadłub pół poślizgowy, a jego długość to aż 8m! To rozwiązanie pozwala na uzyskiwanie odpowiedniej mocy oraz szybkości, szczególnie wtedy, kiedy warunki na danym zbiorniku wodnym są niekorzystne. Jacht może płynąć z prędkością do 25km/h w wersji 115KM lub do 15 km/h przy silniku 40KM. Oba warianty znajdą Państwo w naszej ofercie!", 2, 1, 5,  0, 2022,false, 440),
            new Yachts(2,1,"Balt 918 Tytan", "Balt 918 Tytan to elegancki jacht spacerowy z kokpitem salonowym, którego budowa sprzyja biesiadowaniu. Stanowi następcę Balta 818, który zdobył miano Jachtu Roku 2015. To najnowszy produkt renomowanej polskiej Stoczni Balt-Yacht z Augustowa, która za jakość produkowanych jachtów jest chwalona i ceniona w polskim i zagranicznym środowisku żeglarskim.", 2, 1, 9,0,2015,false,520),
            new Yachts(3,2, "Nexus 870 Revo", "Nexus 870 Revo to nowoczesny i ergonomiczny w użytkowaniu jacht motorowy stoczni Northman. Stworzony na bazie walorów nautycznych swojego poprzednika Nexusa 850 i dopracowany pod kątem praktyczności. Szerokie półpokłady, obszerny kokpit z pełną wysokością stania (1,86 m wysokości) to jego niewątpliwe zalety, które każdemu zapewnią komfort użytkowania.", 4, 1, 7, 0, 2014, false, 450 )
        };
        public IEnumerable<Yachts> GetAll()
        {
            return _yachts;
        }

        public Yachts GetById(int id)
        {
            return _yachts.SingleOrDefault(x => x.Id == id);
        }
        public Yachts Add(Yachts yacht)
        {
            yacht.Id = _yachts.Count() + 1;
            yacht.Created = DateTime.UtcNow;
            _yachts.Add(yacht);
            return yacht;
        }
        public void Update(Yachts yacht)
        {
            yacht.LastModified = DateTime.UtcNow;
        }

        public void Delete(Yachts yacht)
        {
            _yachts.Remove(yacht);
        }
    }
}
