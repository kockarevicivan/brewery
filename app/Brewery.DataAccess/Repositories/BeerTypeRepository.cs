using Brewery.DataAccess.Contracts;
using System.Collections.Generic;
using Brewery.Domain;
using System.Linq;

namespace Brewery.DataAccess.Repositories
{
    public class BeerTypeRepository : AbstractRepository, IBeerTypeRepository
    {
        //<inheritdoc />
        public int Create(BeerType beerType)
        {
            context.BeerTypes.Add(beerType);

            return beerType.Id;
        }

        //<inheritdoc />
        public IEnumerable<BeerType> GetAll()
        {
            return context.BeerTypes;
        }

        //<inheritdoc />
        public BeerType GetById(int id)
        {
            return context.BeerTypes.Where(b => b.Id == id).FirstOrDefault();
        }

        //<inheritdoc />
        public int Update(BeerType beerType)
        {
            BeerType found = context.BeerTypes.Where(b => b.Id == beerType.Id).FirstOrDefault();

            if (found != null)
            {
                found.Name = beerType.Name;

                return found.Id;
            }

            return -1;
        }

        //<inheritdoc />
        public void Delete(int id)
        {
            BeerType found = context.BeerTypes.Where(b => b.Id == id).FirstOrDefault();

            if (found != null)
            {
                context.BeerTypes.Remove(found);
                context.SaveChanges();
            }
        }
    }
}
