using Brewery.Domain;
using Brewery.Presentation.Models;
using System.Collections.Generic;

namespace Brewery.Presentation.MapperProfiles
{
    public class BeerMapperProfile
    {
        public BeerViewmodel Map(Beer raw)
        {
            return new BeerViewmodel()
            {
                Id = raw.Id,
                Name = raw.Name,
                AlcoholPercentage = raw.AlcoholPercentage,
                IBU = raw.IBU,
                Quantity = raw.Quantity,
                BeerTypeId = raw.BeerTypeId,
                BreweryId = raw.BreweryId
            };
        }

        public List<BeerViewmodel> MapRange(List<Beer> raw)
        {
            List<BeerViewmodel> mapped = new List<BeerViewmodel>();

            foreach (var b in raw)
            {
                BeerViewmodel temp = new BeerViewmodel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    AlcoholPercentage = b.AlcoholPercentage,
                    IBU = b.IBU,
                    Quantity = b.Quantity,
                    BeerTypeId = b.BeerTypeId,
                    BreweryId = b.BreweryId
                };

                mapped.Add(temp);
            }

            return mapped;
        }

        public Beer ReverseMap(BeerViewmodel raw)
        {
            return new Beer()
            {
                Id = raw.Id,
                Name = raw.Name,
                AlcoholPercentage = raw.AlcoholPercentage,
                IBU = raw.IBU,
                Quantity = raw.Quantity,
                BeerTypeId = raw.BeerTypeId,
                BreweryId = raw.BreweryId
            };
        }

        public List<Beer> ReverseMapRange(List<BeerViewmodel> raw)
        {
            List<Beer> mapped = new List<Beer>();

            foreach (var b in raw)
            {
                Beer temp = new Beer()
                {
                    Id = b.Id,
                    Name = b.Name,
                    AlcoholPercentage = b.AlcoholPercentage,
                    IBU = b.IBU,
                    Quantity = b.Quantity,
                    BeerTypeId = b.BeerTypeId,
                    BreweryId = b.BreweryId
                };

                mapped.Add(temp);
            }

            return mapped;
        }
    }
}