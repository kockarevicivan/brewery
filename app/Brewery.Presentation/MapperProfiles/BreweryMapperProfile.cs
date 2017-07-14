using Brewery.Presentation.Models;
using System.Collections.Generic;

namespace Brewery.Presentation.MapperProfiles
{
    public class BreweryMapperProfile
    {
        public BreweryViewmodel Map(Domain.Brewery raw)
        {
            return new BreweryViewmodel()
            {
                Id = raw.Id,
                Name = raw.Name,
                PIN = raw.PIN,
                State = raw.State
            };
        }

        public List<BreweryViewmodel> MapRange(List<Domain.Brewery> raw)
        {
            List<BreweryViewmodel> mapped = new List<BreweryViewmodel>();

            foreach (var b in raw)
            {
                BreweryViewmodel temp = new BreweryViewmodel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    PIN = b.PIN,
                    State = b.State
                };

                mapped.Add(temp);
            }

            return mapped;
        }

        public Domain.Brewery ReverseMap(BreweryViewmodel raw)
        {
            return new Domain.Brewery()
            {
                Id = raw.Id,
                Name = raw.Name,
                PIN = raw.PIN,
                State = raw.State
            };
        }

        public List<Domain.Brewery> ReverseMapRange(List<BreweryViewmodel> raw)
        {
            List<Domain.Brewery> mapped = new List<Domain.Brewery>();

            foreach (var b in raw)
            {
                Domain.Brewery temp = new Domain.Brewery()
                {
                    Id = b.Id,
                    Name = b.Name,
                    PIN = b.PIN,
                    State = b.State
                };

                mapped.Add(temp);
            }

            return mapped;
        }
    }
}