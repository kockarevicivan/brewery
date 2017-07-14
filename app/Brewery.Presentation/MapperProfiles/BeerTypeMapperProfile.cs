using Brewery.Domain;
using Brewery.Presentation.Models;
using System.Collections.Generic;

namespace Brewery.Presentation.MapperProfiles
{
    public class BeerTypeMapperProfile
    {
        public BeerTypeViewmodel Map(BeerType raw)
        {
            return new BeerTypeViewmodel()
            {
                Id = raw.Id,
                Name = raw.Name
            };
        }

        public List<BeerTypeViewmodel> MapRange(List<BeerType> raw)
        {
            List<BeerTypeViewmodel> mapped = new List<BeerTypeViewmodel>();

            foreach (var b in raw)
            {
                BeerTypeViewmodel temp = new BeerTypeViewmodel()
                {
                    Id = b.Id,
                    Name = b.Name
                };

                mapped.Add(temp);
            }

            return mapped;
        }

        public BeerType ReverseMap(BeerTypeViewmodel raw)
        {
            return new BeerType()
            {
                Id = raw.Id,
                Name = raw.Name
            };
        }

        public List<BeerType> ReverseMapRange(List<BeerTypeViewmodel> raw)
        {
            List<BeerType> mapped = new List<BeerType>();

            foreach (var b in raw)
            {
                BeerType temp = new BeerType()
                {
                    Id = b.Id,
                    Name = b.Name
                };

                mapped.Add(temp);
            }

            return mapped;
        }
    }
}