using Brewery.DataAccess.Contracts;
using System.Collections.Generic;
using System.Linq;
using Brewery.Domain;

namespace Brewery.DataAccess.Repositories
{
    public class BeerRepository : AbstractRepository, IBeerRepository
    {
        //<inheritdoc />
        public int Create(Beer beer)
        {
            context.Beers.Add(beer);
            context.SaveChanges();

            return beer.Id;
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetAll()
        {
            return context.Beers;
        }

        //<inheritdoc />
        public Beer GetById(int id)
        {
            return context.Beers.Where(b => b.Id == id).FirstOrDefault();
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByName(string name)
        {
            return context.Beers.Where(b => b.Name.Contains(name));
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByAlcoholPercentage(double alcoholPercentage)
        {
            decimal percentage = (decimal)alcoholPercentage;

            return context.Beers.Where(b => b.AlcoholPercentage == percentage);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByIBU(double ibu)
        {
            decimal ibuDecimal = (decimal)ibu;

            return context.Beers.Where(b => b.IBU == ibuDecimal);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByBeerTypeId(int beerTypeId)
        {
            return context.Beers.Where(b => b.BeerTypeId == beerTypeId);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByQuantity(int quantity)
        {
            return context.Beers.Where(b => b.Quantity == quantity);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByBreweryId(int breweryId)
        {
            return context.Beers.Where(b => b.BreweryId == breweryId);
        }

        //<inheritdoc />
        public IEnumerable<Beer> FindByFilters(string name,
            double? alcoholPercentage = null, 
            double? ibu = null,
            int? beerTypeId = null,
            int? quantity = null,
            int? breweryId = null)
        {
            IEnumerable<Beer> allBeers = GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                allBeers = allBeers.Where(b => b.Name.Contains(name));
            }

            if (alcoholPercentage != null)
            {
                decimal alcoholPercentageDecimal = (decimal)alcoholPercentage;

                allBeers = allBeers.Where(b => b.AlcoholPercentage == alcoholPercentageDecimal);
            }

            if (ibu != null)
            {
                decimal ibuDecimal = (decimal)ibu;

                allBeers = allBeers.Where(b => b.IBU == ibuDecimal);
            }
            
            if (beerTypeId != null)
            {
                allBeers = allBeers.Where(b => b.BeerTypeId == beerTypeId);
            }

            if (quantity != null)
            {
                allBeers = allBeers.Where(b => b.Quantity == quantity);
            }

            if (breweryId != null)
            {
                allBeers = allBeers.Where(b => b.BreweryId == breweryId);
            }
            
            return allBeers;
        }

        //<inheritdoc />
        public int Update(Beer beer)
        {
            Beer found = context.Beers.Where(b => b.Id == beer.Id).FirstOrDefault();

            if (found != null)
            {
                found.Name = beer.Name;
                found.AlcoholPercentage = beer.AlcoholPercentage;
                found.IBU = beer.IBU;
                found.BeerTypeId = beer.BeerTypeId;
                found.BreweryId = beer.BreweryId;

                return found.Id;
            }

            return -1;
        }

        //<inheritdoc />
        public void Delete(int id)
        {
            Beer found = context.Beers.Where(b => b.Id == id).FirstOrDefault();

            if (found != null)
            {
                context.Beers.Remove(found);
                context.SaveChanges();
            }
        }
    }
}
