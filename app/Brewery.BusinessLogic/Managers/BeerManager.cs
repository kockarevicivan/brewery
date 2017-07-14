using Brewery.BusinessLogic.Contracts;
using System.Collections.Generic;
using Brewery.Domain;
using Brewery.DataAccess.Contracts;
using Brewery.DataAccess.Repositories;

namespace Brewery.BusinessLogic.Managers
{
    public class BeerManager : IBeerManager
    {
        private IBeerRepository _repository;

        public BeerManager()
        {
            _repository = new BeerRepository();
        }

        //<inheritdoc />
        public int Create(Beer beer)
        {
            return _repository.Create(beer);
        }

        //<inheritdoc />
        public IEnumerable<Beer> FindByFilters(string name,
            double? alcoholPercentage = default(double?),
            double? ibu = default(double?),
            int? beerTypeId = default(int?),
            int? quantity = default(int?),
            int? breweryId = default(int?))
        {
            return _repository.FindByFilters(name,alcoholPercentage,ibu,beerTypeId,quantity,breweryId);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetAll()
        {
            return _repository.GetAll();
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByAlcoholPercentage(double alcoholPercentage)
        {
            return _repository.GetByAlcoholPercentage(alcoholPercentage);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByBeerTypeId(int beerTypeId)
        {
            return _repository.GetByBeerTypeId(beerTypeId);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByBreweryId(int breweryId)
        {
            return _repository.GetByBreweryId(breweryId);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByIBU(double ibu)
        {
            return _repository.GetByIBU(ibu);
        }

        //<inheritdoc />
        public Beer GetById(int id)
        {
            return _repository.GetById(id);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        //<inheritdoc />
        public IEnumerable<Beer> GetByQuantity(int quantity)
        {
            return _repository.GetByQuantity(quantity);
        }

        //<inheritdoc />
        public int Update(Beer beer)
        {
            return _repository.Update(beer);
        }

        //<inheritdoc />
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
                _repository?.Dispose();
        }
    }
}
