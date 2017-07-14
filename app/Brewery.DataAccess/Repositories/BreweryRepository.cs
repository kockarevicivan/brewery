using Brewery.DataAccess.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Brewery.DataAccess.Repositories
{
    public class BreweryRepository : AbstractRepository, IBreweryRepository
    {
        //<inheritdoc />
        public int Create(Domain.Brewery brewery)
        {
            context.Breweries.Add(brewery);

            return brewery.Id;
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetAll()
        {
            return context.Breweries;
        }

        //<inheritdoc />
        public Domain.Brewery GetById(int id)
        {
            return context.Breweries.Where(b => b.Id == id).FirstOrDefault();
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetByName(string name)
        {
            return context.Breweries.Where(b => b.Name.Contains(name));
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetByPIN(string pin)
        {
            return context.Breweries.Where(b => b.PIN.Contains(pin));
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> GetByState(string state)
        {
            return context.Breweries.Where(b => b.State.Contains(state));
        }

        //<inheritdoc />
        public IEnumerable<Domain.Brewery> FindByFilters(string name, string pin, string state)
        {
            IEnumerable<Domain.Brewery> allBreweries = GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                allBreweries = allBreweries.Where(b => b.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(pin))
            {
                allBreweries = allBreweries.Where(b => b.PIN.Contains(pin));
            }

            if (!string.IsNullOrEmpty(state))
            {
                allBreweries = allBreweries.Where(b => b.State.Contains(state));
            }

            return allBreweries;
        }

        //<inheritdoc />
        public int Update(Domain.Brewery brewery)
        {
            Domain.Brewery found = context.Breweries.Where(b => b.Id == brewery.Id).FirstOrDefault();

            if (found != null)
            {
                found.Name = brewery.Name;
                found.PIN = brewery.PIN;
                found.State = brewery.State;

                return found.Id;
            }

            return -1;
        }

        //<inheritdoc />
        public void Delete(int id)
        {
            Domain.Brewery found = context.Breweries.Where(b => b.Id == id).FirstOrDefault();

            if (found != null)
            {
                context.Breweries.Remove(found);
                context.SaveChanges();
            }
        }
    }
}
